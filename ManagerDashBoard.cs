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
    public partial class ManagerDashBoard : Form
    {

        private string username;
        public ManagerDashBoard(string username)
        {
            InitializeComponent();
            this.username = username;
            lblWelcome.Text = "Welcome, " + username;
        }


        // button for show room
        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            ShowRoom showRoomForm = new ShowRoom(username);
            showRoomForm.Show();
            this.Hide();
        }


        // button for customer registration
        private void btnCustomerRegi_Click(object sender, EventArgs e)
        {
            CustomerRegistration cregiForm = new CustomerRegistration(username);
            cregiForm.Show();
            this.Hide();
        }

        // button for check in
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            CheckIn checkInForm = new CheckIn(username);
            checkInForm.Show();
            this.Hide();
        }

        // button for check out
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkOutForm = new CheckOut(username);
            checkOutForm.Show();
            this.Hide();
        }

        // button for customer details
        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            CustomerDetails customerDetailsForm = new CustomerDetails(username);
            customerDetailsForm.Show();
            this.Hide();
        }

        // button for add room

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom addRoomForm = new AddRoom(username);
            addRoomForm.Show();
            this.Hide();
        }

        // button for parking
        private void btnParking_Click(object sender, EventArgs e)
        {
            Parking parkingForm = new Parking(username);
            parkingForm.Show();
            this.Hide();
        }

        // button for swimming pool

        private void btnSwimmingPool_Click_1(object sender, EventArgs e)
        {
            SwimmingPool swimmingPoolForm = new SwimmingPool(username);
            swimmingPoolForm.Show();
            this.Hide();
        }


        // back button
        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

       
    }
}
