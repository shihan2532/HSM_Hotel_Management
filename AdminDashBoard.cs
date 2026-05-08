using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;");
            con.Open();
            //string query = "SELECT COUNT(*) FROM [user] where role = 'ADMIN'";
            string query = "SELECT COUNT(*) FROM [user] ";
            SqlCommand cmd = new SqlCommand(query, con);
            
            var result = cmd.ExecuteScalar();

            lblUsersCount.Text = result.ToString();
            con.Close();
        }

       
    }
}
