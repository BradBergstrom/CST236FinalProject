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
        User current_User;
        RideRequest current_request;
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
            current_request = new RideRequest();
            current_User = new User();

        }





        private void listb_Requests_MouseClick(object sender, MouseEventArgs e)
        {
            var request = _dbContext.RideRequests.ToList().FirstOrDefault(g => g.RideRequestID.Equals(Convert.ToInt32(listb_Requests.GetItemText(listb_Requests.SelectedItem))));
            var rider = _dbContext.Riders.ToList().FirstOrDefault(g => g.RideRequest.Equals(Convert.ToInt32(listb_Requests.GetItemText(listb_Requests.SelectedItem))));
            var driver = _dbContext.Drivers.ToList().FirstOrDefault(g => g.RideRequests.Equals(Convert.ToInt32(listb_Requests.GetItemText(listb_Requests.SelectedItem))));
            current_request = request;
            tb_Details_Requests.Text = "RequestID: " + request.RideRequestID.ToString()
                                + Environment.NewLine+"Destination: " + request.Destination.ToString()
                                + Environment.NewLine+"Desired Time " + request.Rider_Desired_Time.ToString()
                                + Environment.NewLine+"Driver ETA: " + request.Driver_ETA.ToString()
                                + Environment.NewLine + "Credit Card#: " + request.CreditCard_.ToString();
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
            current_User = user;
            tb_Details_User.Text = "UserID: " + user.UserID.ToString()
                                +Environment.NewLine+ "RiderID: " + user.RiderID.ToString()
                                +Environment.NewLine+ "DriverID: " + user.DriverID.ToString()
                                +Environment.NewLine+ "Admin: " + user.Admin.ToString()
                                + Environment.NewLine + "Location: " + user.Location.ToString();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {

        }
    }
}
