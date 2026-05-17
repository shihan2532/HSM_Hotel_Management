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
    public partial class CheckInSystem : Form
    {
        string username;
        
        public CheckInSystem(string username)
        {
            InitializeComponent();
            this.username = username;
            cmbroomType.SelectedIndex = 0;
            cmbbedType.SelectedIndex = 0;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashboard = new AdminDashBoard(username);
            adminDashboard.Show();
            this.Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT [user].userName, [room].roomNumber,[chekedin].chekedIn, [chekedin].chekedOut FROM [user] inner join [chekedin] on [user].userId = [chekedin].userId inner join [room] on [chekedin].roomId = [room].roomId";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            if (cmbroomType.SelectedIndex == 0 || cmbbedType.SelectedIndex == 0 || cmbbedType.SelectedIndex == -1|| cmbroomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both Room Type and Bed Type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM [room] where roomStatus = 'Available' AND roomType = @roomType AND bedType = @bedType";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@roomType", cmbroomType.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@bedType", cmbbedType.SelectedItem.ToString());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

       


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtroomId.Text) || string.IsNullOrWhiteSpace(txtuserid.Text) || string.IsNullOrWhiteSpace(dtchekedin.Text) || dtpcheckedIn.Value > dtpchedout.Value || dtpcheckedIn.Value == DateTime.MinValue || dtpchedout.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query1 = "INSERT INTO [chekedin] (roomId, userId, chekedIn, chekedOut) VALUES (@roomId, @userId, @chekedin, @chekout)";
            SqlCommand cmd = new SqlCommand(query1, con);
            cmd.Parameters.AddWithValue("@roomId", txtroomId.Text);
            cmd.Parameters.AddWithValue("@userId", txtuserid.Text);
            cmd.Parameters.AddWithValue("@chekedin", dtpcheckedIn.Value);
            cmd.Parameters.AddWithValue("@chekout", dtpchedout.Value);
                    
            var result = cmd.ExecuteNonQuery();

            if (Convert.ToInt32(result) > 0)
            {
                MessageBox.Show("Check-in successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Update room status to 'Occupied'
                string updateQuery = "UPDATE [room] SET roomStatus = 'Occupied' WHERE roomId = @roomId";
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.Parameters.AddWithValue("@roomId", txtroomId.Text);
                updateCmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Check-in failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string query = "UPDATE [room] SET roomStatus = 'Occupied' WHERE roomId = @roomId";
            SqlCommand cmdUpdate = new SqlCommand(query, con);
            cmdUpdate.Parameters.AddWithValue("@roomId", txtroomId.Text);
            cmdUpdate.ExecuteNonQuery(); 
            

            con.Close();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtuserid.Clear();
            dtchekedin.Text = DateTime.Now.ToString("yyyy-MM-dd");
            dtpchekhout.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnuserIdSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT firstName,lastName,userId,userName FROM [user] WHERE userName = @userName";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@userName", txtUserName.Text);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();

        }
    }
}
