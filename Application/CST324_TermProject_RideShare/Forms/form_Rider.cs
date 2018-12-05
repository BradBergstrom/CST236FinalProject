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
    public partial class form_Rider : Form
    {
        private OIT_RideShare _dbContext;
        private Rider rider;
        private User user;
        private RideRequest request;
        public form_Rider()
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
            rider = new Rider();
            user = new User();
            request = new RideRequest();
        }


        private void btn_SubmitRideRequest_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                string values = txt_DesiredTime.Text;
                TimeSpan dtime = TimeSpan.Parse(values);
                user.Location = txt_destination.Text + " " + cb_State.Text + ", OR";
                request.Destination = txt_destination.Text + " " + cb_State.Text + ", OR";
                request.CreditCard_ = Convert.ToInt32(txt_CreditCard.Text);
                request.Rider_Desired_Time = dtime;
                rider.RideRequest1 = request;
                user.Rider = rider;
                _dbContext.RideRequests.Add(request);
                _dbContext.Riders.Add(rider);
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                this.Hide();
                form_register fr = new form_register();
                fr.ShowDialog();
            }

        }
        public bool IsValidTimeFormat(string input)
        {
            TimeSpan dummyOutput;
            return TimeSpan.TryParse(input, out dummyOutput);
        }

        private void txt_StreetAddress_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txt_StreetAddress.Text))
            {
                e.Cancel = true;
                txt_StreetAddress.Focus();
                Rider_ErrorProvider.SetError(txt_StreetAddress, "Please enter a street Address");
            }
            else
            {
                e.Cancel = true;
                Rider_ErrorProvider.SetError(txt_StreetAddress, null);
            }
            
        }

        private void txt_destination_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_destination.Text))
            {
                e.Cancel = true;
                txt_destination.Focus();
                Rider_ErrorProvider.SetError(txt_destination, "Please enter a street Address");
            }
            else
            {
                e.Cancel = true;
                Rider_ErrorProvider.SetError(txt_destination, null);
            }
        }

        private void txt_DesiredTime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_DesiredTime.Text))
            {
                e.Cancel = true;
                txt_DesiredTime.Focus();
                Rider_ErrorProvider.SetError(txt_DesiredTime, "Please enter a street Address");
            }
            else if (IsValidTimeFormat(txt_DesiredTime.Text))
            {
                e.Cancel = true;
                txt_DesiredTime.Focus();
                Rider_ErrorProvider.SetError(txt_DesiredTime, "Please check if Desired time is correct");

            }
            else
            {
                e.Cancel = true;
                Rider_ErrorProvider.SetError(txt_DesiredTime, null);
            }
        }





        private void txt_CreditCard_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_CreditCard.Text))
            {
                e.Cancel = true;
                txt_CreditCard.Focus();
                Rider_ErrorProvider.SetError(txt_CreditCard, "Please enter a street Address");
            }
            else if (txt_CreditCard.Text.Trim().Length != 16)
            {
                e.Cancel = true;
                txt_CreditCard.Focus();
                Rider_ErrorProvider.SetError(txt_CreditCard, "Please check if Credit Card is Correct");

            }
            else
            {
                e.Cancel = true;
                Rider_ErrorProvider.SetError(txt_CreditCard, null);
            }
        }
    }
}
