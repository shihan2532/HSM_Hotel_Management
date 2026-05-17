namespace HotelManagementSystem
{
    partial class CheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckIn));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcustomerid = new System.Windows.Forms.Label();
            this.txtcustomerid = new System.Windows.Forms.TextBox();
            this.lblcustomername = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.lblnidnumber = new System.Windows.Forms.Label();
            this.txtnid = new System.Windows.Forms.TextBox();
            this.cmbroomstatus = new System.Windows.Forms.ComboBox();
            this.cmbbed = new System.Windows.Forms.ComboBox();
            this.cmbroomtype = new System.Windows.Forms.ComboBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.lblroomstatus = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblbedtype = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.lblcheckindate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.txtroomnumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MintCream;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(22, 312);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 44);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 155);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MintCream;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(22, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 306);
            this.dataGridView1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(112, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 100);
            this.panel2.TabIndex = 37;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(86, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(82, 20);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 661);
            this.panel1.TabIndex = 36;
            // 
            // lblcustomerid
            // 
            this.lblcustomerid.AutoSize = true;
            this.lblcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomerid.Location = new System.Drawing.Point(905, 118);
            this.lblcustomerid.Name = "lblcustomerid";
            this.lblcustomerid.Size = new System.Drawing.Size(99, 16);
            this.lblcustomerid.TabIndex = 39;
            this.lblcustomerid.Text = "Customer ID :";
            // 
            // txtcustomerid
            // 
            this.txtcustomerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomerid.Location = new System.Drawing.Point(908, 137);
            this.txtcustomerid.Name = "txtcustomerid";
            this.txtcustomerid.Size = new System.Drawing.Size(326, 22);
            this.txtcustomerid.TabIndex = 44;
            // 
            // lblcustomername
            // 
            this.lblcustomername.AutoSize = true;
            this.lblcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustomername.Location = new System.Drawing.Point(905, 170);
            this.lblcustomername.Name = "lblcustomername";
            this.lblcustomername.Size = new System.Drawing.Size(125, 16);
            this.lblcustomername.TabIndex = 52;
            this.lblcustomername.Text = "Customer Name :";
            // 
            // txtcustomername
            // 
            this.txtcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.Location = new System.Drawing.Point(908, 189);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(326, 22);
            this.txtcustomername.TabIndex = 53;
            // 
            // lblnidnumber
            // 
            this.lblnidnumber.AutoSize = true;
            this.lblnidnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnidnumber.Location = new System.Drawing.Point(905, 223);
            this.lblnidnumber.Name = "lblnidnumber";
            this.lblnidnumber.Size = new System.Drawing.Size(99, 16);
            this.lblnidnumber.TabIndex = 56;
            this.lblnidnumber.Text = "NID Number :";
            // 
            // txtnid
            // 
            this.txtnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnid.Location = new System.Drawing.Point(908, 245);
            this.txtnid.Name = "txtnid";
            this.txtnid.Size = new System.Drawing.Size(326, 22);
            this.txtnid.TabIndex = 57;
            // 
            // cmbroomstatus
            // 
            this.cmbroomstatus.FormattingEnabled = true;
            this.cmbroomstatus.Items.AddRange(new object[] {
            "select status",
            "Available",
            "Occupied"});
            this.cmbroomstatus.Location = new System.Drawing.Point(908, 549);
            this.cmbroomstatus.Name = "cmbroomstatus";
            this.cmbroomstatus.Size = new System.Drawing.Size(326, 21);
            this.cmbroomstatus.TabIndex = 67;
            // 
            // cmbbed
            // 
            this.cmbbed.FormattingEnabled = true;
            this.cmbbed.Items.AddRange(new object[] {
            "Select your Room Type",
            "Double",
            "Single"});
            this.cmbbed.Location = new System.Drawing.Point(908, 481);
            this.cmbbed.Name = "cmbbed";
            this.cmbbed.Size = new System.Drawing.Size(326, 21);
            this.cmbbed.TabIndex = 66;
            // 
            // cmbroomtype
            // 
            this.cmbroomtype.FormattingEnabled = true;
            this.cmbroomtype.Items.AddRange(new object[] {
            "Select your bed",
            "Ac",
            "Non-Ac"});
            this.cmbroomtype.Location = new System.Drawing.Point(908, 416);
            this.cmbroomtype.Name = "cmbroomtype";
            this.cmbroomtype.Size = new System.Drawing.Size(326, 21);
            this.cmbroomtype.TabIndex = 65;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(520, 467);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(333, 22);
            this.txtprice.TabIndex = 64;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphonenumber.Location = new System.Drawing.Point(908, 302);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(326, 22);
            this.txtphonenumber.TabIndex = 63;
            // 
            // lblroomstatus
            // 
            this.lblroomstatus.AutoSize = true;
            this.lblroomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomstatus.Location = new System.Drawing.Point(905, 520);
            this.lblroomstatus.Name = "lblroomstatus";
            this.lblroomstatus.Size = new System.Drawing.Size(103, 16);
            this.lblroomstatus.TabIndex = 62;
            this.lblroomstatus.Text = "Room Status :";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(517, 442);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(51, 16);
            this.lblprice.TabIndex = 61;
            this.lblprice.Text = "Price :";
            // 
            // lblbedtype
            // 
            this.lblbedtype.AutoSize = true;
            this.lblbedtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbedtype.Location = new System.Drawing.Point(905, 456);
            this.lblbedtype.Name = "lblbedtype";
            this.lblbedtype.Size = new System.Drawing.Size(83, 16);
            this.lblbedtype.TabIndex = 60;
            this.lblbedtype.Text = "Bed Type :";
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonenumber.Location = new System.Drawing.Point(905, 283);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(117, 16);
            this.lblphonenumber.TabIndex = 58;
            this.lblphonenumber.Text = "Phone Number :";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(905, 393);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(96, 16);
            this.lblroomtype.TabIndex = 59;
            this.lblroomtype.Text = "Room Type :";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.MintCream;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(22, 467);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 44);
            this.btnShow.TabIndex = 22;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(712, 526);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 44);
            this.btnClear.TabIndex = 68;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.Black;
            this.btnCheckIn.Location = new System.Drawing.Point(557, 526);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(101, 44);
            this.btnCheckIn.TabIndex = 69;
            this.btnCheckIn.Text = "Check-In";
            this.btnCheckIn.UseVisualStyleBackColor = false;
            // 
            // lblcheckindate
            // 
            this.lblcheckindate.AutoSize = true;
            this.lblcheckindate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheckindate.Location = new System.Drawing.Point(137, 442);
            this.lblcheckindate.Name = "lblcheckindate";
            this.lblcheckindate.Size = new System.Drawing.Size(112, 16);
            this.lblcheckindate.TabIndex = 70;
            this.lblcheckindate.Tag = "";
            this.lblcheckindate.Text = "Check-In Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(140, 466);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 71;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MintCream;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(22, 393);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 44);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomnumber.Location = new System.Drawing.Point(905, 340);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(114, 16);
            this.lblroomnumber.TabIndex = 72;
            this.lblroomnumber.Text = "Room Number :";
            // 
            // txtroomnumber
            // 
            this.txtroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomnumber.Location = new System.Drawing.Point(908, 359);
            this.txtroomnumber.Name = "txtroomnumber";
            this.txtroomnumber.Size = new System.Drawing.Size(326, 22);
            this.txtroomnumber.TabIndex = 73;
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.txtroomnumber);
            this.Controls.Add(this.lblroomnumber);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblcheckindate);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbroomstatus);
            this.Controls.Add(this.cmbbed);
            this.Controls.Add(this.cmbroomtype);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.lblroomstatus);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblbedtype);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.txtnid);
            this.Controls.Add(this.lblnidnumber);
            this.Controls.Add(this.txtcustomername);
            this.Controls.Add(this.lblcustomername);
            this.Controls.Add(this.txtcustomerid);
            this.Controls.Add(this.lblcustomerid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-In2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblcustomerid;
        private System.Windows.Forms.TextBox txtcustomerid;
        private System.Windows.Forms.Label lblcustomername;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label lblnidnumber;
        private System.Windows.Forms.TextBox txtnid;
        private System.Windows.Forms.ComboBox cmbroomstatus;
        private System.Windows.Forms.ComboBox cmbbed;
        private System.Windows.Forms.ComboBox cmbroomtype;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Label lblroomstatus;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblbedtype;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.Label lblcheckindate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.TextBox txtroomnumber;
    }
}