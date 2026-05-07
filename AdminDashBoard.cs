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
    public partial class AdminDashBoard : Form
    {
         private string name;
        public AdminDashBoard(string name)
        {

            InitializeComponent();
            this.name = name;
            lblWelcome.Text = "Welcome, " + name;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
