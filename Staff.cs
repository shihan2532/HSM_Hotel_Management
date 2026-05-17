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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelManagementSystem
{
    public partial class Staff : Form
    {
        private string username;

        public Staff(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.Trim() == "" || txtlname.Text.Trim() == "" || txtusername.Text.Trim() == "" || txtemail.Text.Trim() == "" || txtnid.Text.Trim() == "" || txtPhone.Text.Trim() == "" || richTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all the fields And You can change only name and adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "UPDATE [user] SET firstName = @fname,lastName = @lname ,address = @address WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@address", richTextBox1.Text);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            var count = (int)cmd.ExecuteNonQuery();

            if (count > 0)
            {
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim() == "")
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);
            string query = "DELETE FROM [user] WHERE username = @username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            con.Open();
            var result = (int)cmd.ExecuteNonQuery();

            if (result > 0)
            {
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnclear_Click(sender, e);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
            string query = "SELECT * FROM [user] where role = 'MANAGER'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtfname.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a first name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                string query = "SELECT * FROM [user] WHERE firstName = @firstName AND role = 'MANAGER'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@firstName", txtfname.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfname.Clear();
            txtlname.Clear();
            txtusername.Clear();
            txtemail.Clear();
            txtnid.Clear();
            txtPhone.Clear();
            richTextBox1.Clear();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            RegistrantionAdmin registrantionAdmin = new RegistrantionAdmin(username);
            registrantionAdmin.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtfname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtusername.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtnid.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
    }
}
