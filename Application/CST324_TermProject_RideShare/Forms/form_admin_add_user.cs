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

namespace CST324_TermProject_RideShare.Forms
{
    public partial class form_admin_add_user : Form
    {
        User user;
        OIT_RideShare _dbContext;
        Driver driver;
        public form_admin_add_user()
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
            user = new User();
            driver = new Driver();
         
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            user.Location = tb_Location.Text;
            user.Admin = Convert.ToInt32(tb_Admin.Text);

            
            if (tb_RiderID.Text != string.Empty)
            {
                var ifexist = _dbContext.Riders.ToList().FirstOrDefault(d => d.RiderID.Equals(Convert.ToInt32(tb_RiderID.Text)));
                if (ifexist != null)
                {
                    user.Rider = ifexist;
                    user.RiderID = Convert.ToInt32(tb_RiderID.Text);
                }
                else
                {
                    Rider rider = new Rider();
                    rider.RiderID = Convert.ToInt32(tb_RiderID.Text);
                    user.Rider = rider;
                    user.RiderID = Convert.ToInt32(tb_RiderID.Text);
                }

            }
            

            if (tb_DriverID.Text != string.Empty)
            {
                var ifexist = _dbContext.Drivers.ToList().FirstOrDefault(d => d.DriverID.Equals( Convert.ToInt32(tb_DriverID.Text)));
                if (ifexist != null)
                {
                    user.Driver = ifexist;
                    user.DriverID = Convert.ToInt32(tb_DriverID.Text);
                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();
                    MessageBox.Show("Successfully Added User!");
                    tb_Location.Text = string.Empty;
                    tb_Admin.Text = string.Empty;
                    tb_DriverID.Text = string.Empty;
                    tb_RiderID.Text = string.Empty;
                }
                else
                {

                    Form form = new form_admin_add_user_driver(user);
                    form.Show();
                    tb_Location.Text = string.Empty;
                    tb_Admin.Text = string.Empty;
                    tb_DriverID.Text = string.Empty;
                    tb_RiderID.Text = string.Empty;
                }
            }
            else
            {
                _dbContext.Users.Add(user);
                _dbContext.SaveChanges();
                MessageBox.Show("Successfully Added User!");
                tb_Location.Text = string.Empty;
                tb_Admin.Text = string.Empty;
                tb_DriverID.Text = string.Empty;
                tb_RiderID.Text = string.Empty;
            }

        }
    }
}
