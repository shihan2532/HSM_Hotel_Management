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
    public partial class CheckedoutAdmin : Form
    {
        private string username, roomNumber, phoneNumber, email, nid, chekedIn, chekedOut;
        private int roomId;
        public CheckedoutAdmin()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            username = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            roomNumber = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            chekedIn = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            chekedOut = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneNumber = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            email = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            nid = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT [room].roomId,[user].userName, [room].roomNumber,[chekedin].chekedIn, [chekedin].chekedOut,[user].phoneNumber,[user].email,[user].nid FROM [user] inner join [chekedin] on [user].userId = [chekedin].userId inner join [room] on [chekedin].roomId = [room].roomId ";
            //string query = "select userName, roomNumber. from [chekedin]";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string quey = "SELECT * FROM [DETAILS] WHERE checkOut IS NOT NULL";
            SqlCommand cmd = new SqlCommand(quey, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnuserIdSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM [Details] ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CheckInSystem c1 = new CheckInSystem("");
            c1.Show();
            this.Hide();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            username = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            roomNumber = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            chekedIn = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            chekedOut = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            phoneNumber = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            email = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            nid = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(nid) || string.IsNullOrEmpty(chekedIn) )
            {
                MessageBox.Show("Please select a record from the table before checking out.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "INSERT INTO [Details] (roomId, userName,roomNumber,checkIn, checkOut,phoneNumber,email,nid) VALUES ( @roomId, @username, @roomNumber,@chekedin, @chekout,@phoneNumber,@email,@nid)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@roomId", roomId);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@roomNumber", roomNumber);
            cmd.Parameters.AddWithValue("@chekedin", chekedIn);
             cmd.Parameters.AddWithValue("@chekout", DateTime.Now);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nid", nid);
            cmd.ExecuteScalar();

            string query2 = "DELETE FROM [chekedin] WHERE roomId = @roomId ";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@roomId", roomId);
            cmd2.ExecuteNonQuery();

            string query3 = "UPDATE [room] SET roomStatus = 'Available' WHERE roomNumber = @roomNumber";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            cmd3.Parameters.AddWithValue("@roomNumber", roomNumber);
            cmd3.ExecuteNonQuery();

            con.Close();
            


        }



       
    }
}
