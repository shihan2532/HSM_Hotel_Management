using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem
{
    public partial class CustomerDetails : Form
    {

        private string username;
        public CustomerDetails(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome, " + username;
        }

        // back button

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ManagerDashBoard managerdashboard = new ManagerDashBoard(username);
            managerdashboard.Show();
            this.Hide();
        }
    }
}
