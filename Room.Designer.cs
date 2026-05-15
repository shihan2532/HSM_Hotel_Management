namespace HotelManagementSystem
{
    partial class Room
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblroomnumber = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.lblbedtype = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblroomstatus = new System.Windows.Forms.Label();
            this.txtroomnumber = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbroomtype = new System.Windows.Forms.ComboBox();
            this.cmbbed = new System.Windows.Forms.ComboBox();
            this.cmbroomstatus = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cyan;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MintCream;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(22, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(112, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(142, 527);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 44);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 385);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblroomnumber
            // 
            this.lblroomnumber.AutoSize = true;
            this.lblroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomnumber.Location = new System.Drawing.Point(834, 127);
            this.lblroomnumber.Name = "lblroomnumber";
            this.lblroomnumber.Size = new System.Drawing.Size(114, 16);
            this.lblroomnumber.TabIndex = 3;
            this.lblroomnumber.Text = "Room Number :";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomtype.Location = new System.Drawing.Point(834, 209);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(96, 16);
            this.lblroomtype.TabIndex = 4;
            this.lblroomtype.Text = "Room Type :";
            // 
            // lblbedtype
            // 
            this.lblbedtype.AutoSize = true;
            this.lblbedtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbedtype.Location = new System.Drawing.Point(834, 286);
            this.lblbedtype.Name = "lblbedtype";
            this.lblbedtype.Size = new System.Drawing.Size(83, 16);
            this.lblbedtype.TabIndex = 5;
            this.lblbedtype.Text = "Bed Type :";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(839, 362);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(51, 16);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "Price :";
            // 
            // lblroomstatus
            // 
            this.lblroomstatus.AutoSize = true;
            this.lblroomstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblroomstatus.Location = new System.Drawing.Point(834, 434);
            this.lblroomstatus.Name = "lblroomstatus";
            this.lblroomstatus.Size = new System.Drawing.Size(103, 16);
            this.lblroomstatus.TabIndex = 7;
            this.lblroomstatus.Text = "Room Status :";
            // 
            // txtroomnumber
            // 
            this.txtroomnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomnumber.Location = new System.Drawing.Point(837, 167);
            this.txtroomnumber.Name = "txtroomnumber";
            this.txtroomnumber.Size = new System.Drawing.Size(303, 22);
            this.txtroomnumber.TabIndex = 9;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(837, 392);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(303, 22);
            this.txtprice.TabIndex = 12;
            // 
            // btnclear
            // 
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(837, 527);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(125, 34);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(250, 527);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 44);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbroomtype
            // 
            this.cmbroomtype.FormattingEnabled = true;
            this.cmbroomtype.Items.AddRange(new object[] {
            "Select your bed",
            "Ac",
            "Non-Ac"});
            this.cmbroomtype.Location = new System.Drawing.Point(842, 247);
            this.cmbroomtype.Name = "cmbroomtype";
            this.cmbroomtype.Size = new System.Drawing.Size(298, 21);
            this.cmbroomtype.TabIndex = 16;
            // 
            // cmbbed
            // 
            this.cmbbed.FormattingEnabled = true;
            this.cmbbed.Items.AddRange(new object[] {
            "Select your Room Type",
            "Double",
            "Single"});
            this.cmbbed.Location = new System.Drawing.Point(842, 326);
            this.cmbbed.Name = "cmbbed";
            this.cmbbed.Size = new System.Drawing.Size(298, 21);
            this.cmbbed.TabIndex = 17;
            // 
            // cmbroomstatus
            // 
            this.cmbroomstatus.FormattingEnabled = true;
            this.cmbroomstatus.Items.AddRange(new object[] {
            "select status",
            "Available",
            "Occupied"});
            this.cmbroomstatus.Location = new System.Drawing.Point(837, 466);
            this.cmbroomstatus.Name = "cmbroomstatus";
            this.cmbroomstatus.Size = new System.Drawing.Size(298, 21);
            this.cmbroomstatus.TabIndex = 18;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.cmbroomstatus);
            this.Controls.Add(this.cmbbed);
            this.Controls.Add(this.cmbroomtype);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtroomnumber);
            this.Controls.Add(this.lblroomstatus);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblbedtype);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.lblroomnumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.panel1);
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblroomnumber;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Label lblbedtype;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblroomstatus;
        private System.Windows.Forms.TextBox txtroomnumber;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbroomtype;
        private System.Windows.Forms.ComboBox cmbbed;
        private System.Windows.Forms.ComboBox cmbroomstatus;
    }
}