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

namespace HotelManagementSystem
{
    public partial class Registration : Form
    {
        private string fname, lname, email, password, nid, phone, address, role, dob, luserId;
        private int userId;
        

        private void Registration_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT MAX(userId) FROM [user]";
            SqlCommand cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteScalar();
            

            //last user id will be stored in luserId and add in user name to make it unique

            if (result != DBNull.Value)
            {
                luserId = result.ToString();
                userId = Convert.ToInt32(luserId);

            }
            else
            {
                luserId = "0";
            }
            con.Close();

        }

        private void btnback_Click(object sender, EventArgs e)
        {
           Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        public Registration()
        {
            InitializeComponent();
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);


            //this is For  assign null to all error labels before validation
            lblerrofname.Text = lblerrorlname.Text = lblerrorpassword.Text = lblerroremail.Text = lblerrornid.Text = lblerrorphonenumber.Text = lblerroraddress.Text = lblerrordob.Text = lblerrorrole.Text = "";

            if (txtFname.Text.Trim() == "")
            {
                lblerrofname.Text = "First name is required.";
            }
            if (txtLname.Text.Trim() == "")
            {
                lblerrorlname.Text = "Last name is required.";
            }
            if (txtEmail.Text.Trim() == "")
            {
                lblerroremail.Text = "Email is required.";
            }
            if (txtPassword.Text.Trim() == "")
            {
                lblerrorpassword.Text = "Password is required.";
            }
            if (txtNid.Text.Trim() == "")
            {
                lblerrornid.Text = "NID is required.";
            }
            if (txtPhoneNumber.Text.Trim() == "")
            {
                lblerrorphonenumber.Text = "Phone number is required.";
            }
            if (richTextBox1.Text.Trim() == "")
            {
                lblerroraddress.Text = "Address is required.";
            }
            if (dateTimePicker1.Value.Date >= DateTime.Now.Date)
            {
                lblerrordob.Text = "Date of birth must be in the past.";
            }
            if (comboBox1.SelectedIndex == -1)
            {
                lblerrorrole.Text = "Role selection is required.";
            }

            // Check if all fields are valid before proceeding with registration

            
           

            if (txtFname != null && txtLname != null && txtEmail != null && txtPassword != null && txtNid != null && txtPhoneNumber != null && richTextBox1 != null && dateTimePicker1.Value.Date < DateTime.Now.Date && comboBox1.SelectedIndex != -1)
            {
                fname = txtFname.Text.Trim();
                lname = txtLname.Text.Trim();

                // Check if email already exists in the database

               
                con.Open();
                string query1 = "SELECT COUNT(*) FROM [user] WHERE email = @email";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                cmd1.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                var count = (int)cmd1.ExecuteScalar();
                


                if (txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
                {
                   
                    if (count == 0)
                    {
                        lblerroremail.Text = "";
                        email = txtEmail.Text.Trim();
                    }
                    else
                    {
                        lblerroremail.Text = "Email already exists.";
                        return;
                    }
                }
                else
                {
                    lblerroremail.Text = "Invalid email format.";
                    return;
                }
                con.Close();



                password = txtPassword.Text.Trim();

                //nid validation only digits allowed and length must be more than 5 and unique

                con.Open();
                string query2 = "SELECT COUNT(*) FROM [user] WHERE nid = @nid";
                SqlCommand cmd4 = new SqlCommand(query2, con);
                cmd4.Parameters.AddWithValue("@nid", txtNid.Text.Trim());
                var count1 = (int)cmd4.ExecuteScalar();
 

                if (!txtNid.Text.All(char.IsDigit) || txtNid.Text.Length <= 5)
                {
                    lblerrornid.Text = "Invalid NID. Only digits allowed, length must be more than 5.";
                    return;
                }

                if (count1 == 0)
                {
                    lblerrornid.Text = "";
                    nid = txtNid.Text.Trim();

                }
                else
                {
                    lblerrornid.Text = "NID already exists.";
                    return;
                }
                con.Close();
                //phone number validation only digits allowed and length must be 11

                

                con.Open();
                string query3 = "SELECT COUNT(*) FROM [user] WHERE phoneNumber = @PhoneNumber";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                cmd3.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                var count2 = (int)cmd3.ExecuteScalar();

                if (!txtPhoneNumber.Text.All(char.IsDigit) || txtPhoneNumber.Text.Length != 11)
                {
                    lblerrorphonenumber.Text = "Invalid phone number. Only digits allowed, length must be 11.";
                    return;
                }

                if (count2 == 0)
                {
                    lblerrorphonenumber.Text = "";
                    phone = txtPhoneNumber.Text.Trim();
                }
                else
                {
                    lblerrorphonenumber.Text = "Phone number already exists.";
                    return;
                }

                con.Close();



                address = richTextBox1.Text.Trim();

                dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                role = comboBox1.SelectedItem.ToString();

               
                
                con.Open();
                string query = "INSERT INTO [user] (firstName,lastName ,userName, password, email, nid, phoneNumber, address, dob, role) VALUES (@fname,@lname, @userName,  @password, @email, @nid, @phone, @address, @dob, @role)";
                SqlCommand cmd2 = new SqlCommand(query, con);
                cmd2.Parameters.AddWithValue("@fname", fname);
                cmd2.Parameters.AddWithValue("@lname", lname);
                cmd2.Parameters.AddWithValue("@userName", txtFname.Text.Trim()+"#"+ txtLname.Text.Trim() + (userId + 1));
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@password", password);
                cmd2.Parameters.AddWithValue("@nid", nid);
                cmd2.Parameters.AddWithValue("@phone", phone);
                cmd2.Parameters.AddWithValue("@address", address);
                cmd2.Parameters.AddWithValue("@dob", dob);
                cmd2.Parameters.AddWithValue("@role", role);

                var result = cmd2.ExecuteNonQuery();
               

                if (result > 0)
                {
                    MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnReset_Click(sender, e); // Clear the form after successful registration
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                con.Close();


            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtPassword.Clear();
            txtNid.Clear();
            txtPhoneNumber.Clear();
            richTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
        
    }
}
