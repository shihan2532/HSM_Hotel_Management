using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagementSystem
{
   
    public partial class Form1 : Form
    {
        private string roleName;
        private string username,name;
        private string password;


        public Form1()
        {
            InitializeComponent();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtname_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtname.Text == "Enter your name")
            {
                txtname.Clear();
            }
  
        }

        private void txtpassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtpassword.Text == "Enter your password")
            {
                txtpassword.Clear();
                txtpassword.PasswordChar = '*';
            }
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblerrorname.Text = lblerrorpassword.Text = "";

            if (txtname.Text.Trim() == "")
            {
                lblerrorname.Text = "Please enter your name";

            }
            if (txtpassword.Text.Trim() == "")
            {
                lblerrorpassword.Text = "Please enter your password";
            }


            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string query = "Select role,userName,password from [user] where userName = @username and password = @password";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtname.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);


            var role = cmd.ExecuteReader();





            if (role.HasRows)
            {
                role.Read();
                roleName = role["role"].ToString();
                username = role["userName"].ToString();
                password = role["password"].ToString();



            }

            con.Close();
            if (txtname.Text != "" && txtpassword.Text != "")
            { 
                if( username == txtname.Text.Trim() && password == txtpassword.Text.Trim())
                {
                    if (roleName == "ADMIN")
                    {
                        MessageBox.Show("Succesfully Loged In", "Message", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                        AdminDashBoard adminDashboard = new AdminDashBoard(username);
                        adminDashboard.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid username or password","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


            

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }


    }
}
