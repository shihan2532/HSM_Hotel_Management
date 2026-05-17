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
    public partial class Room : Form
    {

        public Room()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT * FROM Room";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                con.Close();

            }


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtroomnumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbroomtype.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbbed.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbroomstatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbroomtype.SelectedIndex == 0 || cmbbed.SelectedIndex == 0 || string.IsNullOrEmpty(cmbroomtype.Text) || string.IsNullOrEmpty(cmbbed.Text))
            {
                MessageBox.Show("Please select both Room Type and Bed Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "SELECT * FROM Room WHERE roomType = @roomType AND bedType = @bedType  AND roomStatus = 'Available'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roomType", cmbroomtype.Text);
                cmd.Parameters.AddWithValue("@bedType", cmbbed.Text);
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
            txtroomnumber.Clear();
            cmbroomtype.SelectedIndex = 0;
            cmbbed.SelectedIndex = 0;
            txtprice.Clear();
            cmbroomstatus.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtroomnumber.Text))
            {
                MessageBox.Show("Please select a room Number to delete.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE FROM Room WHERE roomNumber = @roomNumber";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@roomNumber", txtroomnumber.Text);
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Room deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=FHMSDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            string checkQuery = "SELECT COUNT(*) FROM Room WHERE roomNumber = @roomNumber";
            SqlCommand checkCmd = new SqlCommand(checkQuery, con);
            checkCmd.Parameters.AddWithValue("@roomNumber", txtroomnumber.Text);
            int existingCount = (int)checkCmd.ExecuteScalar();


            if (string.IsNullOrEmpty(txtroomnumber.Text) || cmbroomtype.SelectedIndex == 0 || cmbbed.SelectedIndex == 0 || string.IsNullOrEmpty(txtprice.Text) || cmbroomstatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill in all fields. expecept Room status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (existingCount > 0)
                {
                    MessageBox.Show("Room with this number already exists or is currently unavailable.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    string query = "INSERT INTO Room (roomNumber, roomType, bedType, price, roomStatus) VALUES (@roomNumber, @roomType, @bedType, @price,@roomStatus)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@roomNumber", txtroomnumber.Text);
                    cmd.Parameters.AddWithValue("@roomType", cmbroomtype.Text);
                    cmd.Parameters.AddWithValue("@bedType", cmbbed.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    cmd.Parameters.AddWithValue("@roomStatus", cmbroomstatus.Text);
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Room added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashBoard adminDashboard = new AdminDashBoard("");
            adminDashboard.Show();
            this.Hide();
        }
    }
            

}
