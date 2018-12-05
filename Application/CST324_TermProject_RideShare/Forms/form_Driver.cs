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
        public form_Driver(int id)
        {
            InitializeComponent();
            _dbContext = new OIT_RideShare();
            var driver = _dbContext.Drivers.SingleOrDefault(c => c.DriverID == id);
    
        }


    }
}
