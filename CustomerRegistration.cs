using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CustomerRegistration : Form
    {

        private string username;
        public CustomerRegistration(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome, " + username;
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        

        private void btnback_Click(object sender, EventArgs e)
        {
            ManagerDashBoard managerdashboard = new ManagerDashBoard( username);
            managerdashboard.Show();
            this.Hide();
        }
    }
}
