using CST324_TermProject_RideShare.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324_TermProject_RideShare
{
    public partial class form_Driver : Form
    {
        private OIT_RideShare _dbContext;
        private Driver driver;
        private RideRequest selected;
        public form_Driver(int id)
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
            var driver = _dbContext.Drivers.SingleOrDefault(c => c.DriverID == id);

            var list = _dbContext.RideRequests.ToList();
            foreach (var u in list)
            {
                if (u.Driver_ETA == null)
                {
                    driverRequest_lbox.Items.Add(u.RideRequestID);
                }
            }
        }

        private void driverRequest_lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var request = _dbContext.RideRequests.ToList().FirstOrDefault(g => g.RideRequestID.Equals(Convert.ToInt32(driverRequest_lbox.GetItemText(driverRequest_lbox.SelectedItem))));
            selected = request;

            driverRequestDetails_tb.Text =
                                "Destination: " + request.Destination.ToString() 
                                + Environment.NewLine + "Desired Time " + request.Rider_Desired_Time.ToString();
                                
                              
        }

        private void driverUpdate_btn_Click(object sender, EventArgs e)
        {
            driverRequest_lbox.Items.Clear();
            var list = _dbContext.RideRequests.ToList();
            foreach (var u in list)
            {
                if (u.Driver_ETA == null)
                {
                    driverRequest_lbox.Items.Add(u.RideRequestID);
                }
            }
        }

        private void chooseRequest_btn_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                driverEta_lb.Visible = true;
                driverETA_tb.Visible = true;
                driverSubmit_btn.Visible = true;
            }
        }

        private void driverSubmit_btn_Click(object sender, EventArgs e)
        {
            if(selected.Driver_ETA != null)
            {
                //throw error 
                MessageBox.Show("Sorry this student has already been picked up");
            } else if (driverETA_tb.Text.ToString().Equals(""))
            {
                MessageBox.Show("You must enter a estimated time of arrival");
            }
            else
            {
                //update database with the eta time, and kick driver back to register form

                TimeSpan ts = TimeSpan.Parse(driverETA_tb.Text.ToString());
                selected.Driver_ETA = ts;

                _dbContext.SaveChanges();

                this.Hide();
                var form1 = new form_register();
                form1.Closed += (s, args) => this.Close();
                form1.Show();

            }
        }
    }
}
