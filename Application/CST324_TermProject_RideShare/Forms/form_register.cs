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
    public partial class form_register : Form
    {
        private OIT_RideShare _dbContext;
        private string password = "cst3242018";
        public form_register()
        {
           // pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            InitializeComponent();
            _dbContext = new OIT_RideShare();
        }

        private void form_register_Load(object sender, EventArgs e)
        {

        }


        private void driver_btn_Click(object sender, EventArgs e)
        {
            driver_btn.Visible = false;
            admin_btn.Visible = false;
            rider_btn.Visible = false;

            loginQuestion_lb.Visible = true;
            register_tb.Visible = true;
            enter_btn.Visible = true;
            back_btn.Visible = true;
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            driver_btn.Visible = false;
            admin_btn.Visible = false;
            rider_btn.Visible = false;

            loginQuestion_lb.Text = "      Enter a Password";
            loginQuestion_lb.Visible = true;
            register_tb.Visible = true;
            enter_btn.Visible = true;
            back_btn.Visible = true;
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            //Provide logic to switch to the driver form with the provided firstname
            if (string.IsNullOrEmpty(register_tb.Text))
            {
                //e.Cancel = true;
                register_tb.Focus();
                register_ep.SetError(register_tb, "Please enter a first name");

            }
            else if (loginQuestion_lb.Text.ToString().Equals("      Enter a Password"))
            {
                if (!register_tb.Text.ToString().Equals(password))
                {
                  //  e.Cancel = true;
                    register_tb.Focus();
                    register_ep.SetError(register_tb, "Inncorrect Password");
                } else
                {
                    //TODO let the user go to admin page here
                    this.Hide();
                    var form3 = new form_Admin();
                    form3.Closed += (s, args) => this.Close();
                    form3.Show();

                }

            }
            else
            {

                //TODO check to see if first name added was in the driver database
                var driver = _dbContext.Drivers.SingleOrDefault(c => c.FirstName.Equals(register_tb.Text));
              
                if (driver == null)
                {
                    register_tb.Focus();
                    register_ep.SetError(register_tb, "Did not find a driver with that name");
                   // MessageBox.Show("Did not find a driver with that name");
                }
                else
                {
                    //Go to the driver form with the selected driver
                    int id = driver.DriverID;
                    _dbContext.SaveChanges();
                    this.Hide();
                    var form2 = new form_Driver(id);
                    form2.Closed += (s, args) => this.Close();
                    form2.Show();
                }

            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            driver_btn.Visible = true;
            admin_btn.Visible = true;
            rider_btn.Visible = true;

            loginQuestion_lb.Text = "      Enter First Name";
            loginQuestion_lb.Visible = false;
            register_tb.Visible = false;
            enter_btn.Visible = false;
            register_tb.Text = "";
            back_btn.Visible = false;
        }

        private void register_tb_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
    }
