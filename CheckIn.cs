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
    public partial class CheckIn : Form
    {
        private string username;
        public CheckIn(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome, " + username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerDashBoard managerdashboard = new ManagerDashBoard( username);
            managerdashboard.Show();
            this.Hide();
        }
    }
}
