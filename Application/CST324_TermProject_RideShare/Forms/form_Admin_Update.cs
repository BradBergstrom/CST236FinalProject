using CST324_TermProject_RideShare.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST324_TermProject_RideShare.Forms
{
    public partial class form_Admin_Update : Form
    {
        User current;
        private OIT_RideShare _dbContext;
        string willChange;
        public form_Admin_Update(User user)
        {
            InitializeComponent();
            current = user;
            _dbContext = new OIT_RideShare();
            UpdateUserData();
        }



        private void listb_User_Update_MouseClick(object sender, MouseEventArgs e)
        {
            willChange = listb_User_Update.GetItemText(listb_User_Update.SelectedItem);
            
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            var tochange = _dbContext.Users.FirstOrDefault(u => u.UserID == current.UserID) ;
            switch(willChange.Trim().ToLower())
            {
                case "userid":
                    tochange.UserID = Convert.ToInt32(tb_UpdateTo.Text);
                    break;
                case "location":
                    tochange.Location = tb_UpdateTo.Text;
                    break;
                case "admin":
                    tochange.Admin = Convert.ToInt32(tb_UpdateTo.Text);
                    break;
                case "riderid":
                    var ifexist = _dbContext.Riders.ToList().FirstOrDefault(d => d.RiderID.Equals(current.RiderID));
                    if(ifexist !=null)
                    {
                        tochange.RiderID = Convert.ToInt32(tb_UpdateTo.Text);
                        tochange.Rider = ifexist;
                    }
                    else
                    {
                        MessageBox.Show("There is no Rider under that ID!");
                    }
                    
                    break;
                case "driverid":
                    var temp = _dbContext.Drivers.ToList().FirstOrDefault(d => d.DriverID.Equals(current.DriverID));
                    if (temp != null)
                    {
                        tochange.DriverID = Convert.ToInt32(tb_UpdateTo.Text);
                        tochange.Driver = temp;
                    }
                    else
                    {
                        MessageBox.Show("There is no Driver under that ID!");
                    }
                    break;
            }
            
            _dbContext.SaveChanges();
            MessageBox.Show("Successfully Updated Database!");
            UpdateUserData();
        }

        public void UpdateUserData()
        {
            tb_userdata.Text = "UserID: " + current.UserID.ToString()
                                + Environment.NewLine + "RiderID: " + current.RiderID.ToString()
                                + Environment.NewLine + "DriverID: " + current.DriverID.ToString()
                                + Environment.NewLine + "Admin: " + current.Admin.ToString()
                                + Environment.NewLine + "Location: " + current.Location.ToString();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
