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
    public partial class form_admin_add_user_driver : Form
    {

        Driver driver;
        OIT_RideShare _dbContext;
        User add_user;
        public form_admin_add_user_driver(User user)
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
            add_user = user;
        }



        private void btn_Finish_Click(object sender, EventArgs e)
        {
            driver.FirstName = tb_FirstName.Text;
            driver.LicensePlate = tb_LicensePlate.Text;
            driver.VehicleType = tb_VehicleType.Text;
            add_user.Driver = driver;
            _dbContext.Drivers.Add(driver);
            _dbContext.Users.Add(add_user);
            _dbContext.SaveChanges();
            this.Close();

        }
    }
}
