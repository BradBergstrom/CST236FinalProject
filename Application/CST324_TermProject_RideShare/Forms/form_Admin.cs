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
    public partial class form_Admin : Form
        {
            private OIT_RideShare _dbContext;
        public form_Admin()
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
            var list = _dbContext.Users.ToList();
            foreach(var u in list)
            {
                listb_Users.Items.Add(u.UserID);
            }
            var temp = _dbContext.RideRequests.ToList();
            
            foreach(var u in temp)
            {
                listb_Requests.Items.Add(u.RideRequestID);
            }

        }



        private void btn_Rider_Delete_Click(object sender, EventArgs e)
        {
        }

        private void listb_Users_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void listb_Requests_MouseClick(object sender, MouseEventArgs e)
        {
            var request = _dbContext.RideRequests.ToList().FirstOrDefault(g => g.RideRequestID.Equals(Convert.ToInt32(listb_Requests.GetItemText(listb_Requests.SelectedItem))));
            var rider = _dbContext.Riders.ToList().FirstOrDefault(g => g.RideRequest.Equals(Convert.ToInt32(listb_Requests.GetItemText(listb_Requests.SelectedItem))));
            var driver = _dbContext.Drivers.ToList().FirstOrDefault(g => g.RideRequests.Equals(Convert.ToInt32(listb_Requests.GetItemText(listb_Requests.SelectedItem))));

            tb_Details_Requests.Text = "RequestID: " + request.RideRequestID.ToString()
                                + "\nDestination: " + request.Destination.ToString()
                                + "\nDesired Time " + request.Rider_Desired_Time.ToString()
                                + "\nDriver ETA: " + request.Driver_ETA.ToString()
                                + "\nCredit Card#: " + request.CreditCard_.ToString();
            if (rider != null)
            {
                tb_Details_Requests.Text += "\nRiderID: " + rider.RiderID.ToString();
            }
            if(driver != null)
            {
                tb_Details_Requests.Text += "\nDriverID: " + driver.DriverID.ToString();

            }
        }

        private void listb_Users_MouseClick(object sender, MouseEventArgs e)
        {
            var user = _dbContext.Users.ToList().FirstOrDefault(g => g.UserID.Equals(Convert.ToInt32(listb_Users.GetItemText(listb_Users.SelectedItem))));
            tb_Details_User.Text = "UserID: " + user.UserID.ToString()
                                + "\nRiderID: " + user.RiderID.ToString()
                                + "\nDriverID: " + user.DriverID.ToString()
                                + "\nAdmin: " + user.Admin.ToString()
                                + "\nLocation: " + user.Location.ToString();
        }
    }
}
