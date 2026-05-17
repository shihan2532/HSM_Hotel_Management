namespace HotelManagementSystem
{
    partial class CheckInSystem
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.cmbroomType = new System.Windows.Forms.ComboBox();
            this.cmbbedType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtchekedin = new System.Windows.Forms.Label();
            this.dtpchekhout = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.dtpcheckedIn = new System.Windows.Forms.DateTimePicker();
            this.dtpchedout = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnuserIdSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtroomId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(106, 665);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(104, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 98);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(112, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 286);
            this.dataGridView1.TabIndex = 2;
           
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(112, 453);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(95, 48);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.Location = new System.Drawing.Point(245, 453);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(94, 48);
            this.btnAvailable.TabIndex = 5;
            this.btnAvailable.Text = "Available Room";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1172, 604);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(79, 45);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Room Id :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(365, 587);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 26);
            this.txtUserName.TabIndex = 8;
            // 
            // cmbroomType
            // 
            this.cmbroomType.FormattingEnabled = true;
            this.cmbroomType.Items.AddRange(new object[] {
            "Select Room Type",
            "Ac",
            "Non-Ac"});
            this.cmbroomType.Location = new System.Drawing.Point(365, 453);
            this.cmbroomType.Name = "cmbroomType";
            this.cmbroomType.Size = new System.Drawing.Size(153, 21);
            this.cmbroomType.TabIndex = 9;
            // 
            // cmbbedType
            // 
            this.cmbbedType.FormattingEnabled = true;
            this.cmbbedType.Items.AddRange(new object[] {
            "select Bed Type",
            "Single",
            "Double"});
            this.cmbbedType.Location = new System.Drawing.Point(365, 497);
            this.cmbbedType.Name = "cmbbedType";
            this.cmbbedType.Size = new System.Drawing.Size(153, 21);
            this.cmbbedType.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "User ID :";
            // 
            // dtchekedin
            // 
            this.dtchekedin.AutoSize = true;
            this.dtchekedin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtchekedin.Location = new System.Drawing.Point(677, 297);
            this.dtchekedin.Name = "dtchekedin";
            this.dtchekedin.Size = new System.Drawing.Size(99, 20);
            this.dtchekedin.TabIndex = 12;
            this.dtchekedin.Text = "Cheked in :";
            // 
            // dtpchekhout
            // 
            this.dtpchekhout.AutoSize = true;
            this.dtpchekhout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpchekhout.Location = new System.Drawing.Point(677, 374);
            this.dtpchekhout.Name = "dtpchekhout";
            this.dtpchekhout.Size = new System.Drawing.Size(100, 20);
            this.dtpchekhout.TabIndex = 13;
            this.dtpchekhout.Text = "check Out :";
            // 
            // txtuserid
            // 
            this.txtuserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserid.Location = new System.Drawing.Point(808, 225);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(285, 26);
            this.txtuserid.TabIndex = 14;
            // 
            // dtpcheckedIn
            // 
            this.dtpcheckedIn.Location = new System.Drawing.Point(808, 297);
            this.dtpcheckedIn.Name = "dtpcheckedIn";
            this.dtpcheckedIn.Size = new System.Drawing.Size(216, 20);
            this.dtpcheckedIn.TabIndex = 15;
            // 
            // dtpchedout
            // 
            this.dtpchedout.Location = new System.Drawing.Point(808, 374);
            this.dtpchedout.Name = "dtpchedout";
            this.dtpchedout.Size = new System.Drawing.Size(216, 20);
            this.dtpchedout.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(783, 453);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 35);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit ";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(945, 453);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(79, 35);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnuserIdSearch
            // 
            this.btnuserIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuserIdSearch.Location = new System.Drawing.Point(245, 565);
            this.btnuserIdSearch.Name = "btnuserIdSearch";
            this.btnuserIdSearch.Size = new System.Drawing.Size(94, 48);
            this.btnuserIdSearch.TabIndex = 19;
            this.btnuserIdSearch.Text = "Search User ID";
            this.btnuserIdSearch.UseVisualStyleBackColor = true;
            this.btnuserIdSearch.Click += new System.EventHandler(this.btnuserIdSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "User Name :";
            // 
            // txtroomId
            // 
            this.txtroomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroomId.Location = new System.Drawing.Point(808, 159);
            this.txtroomId.Name = "txtroomId";
            this.txtroomId.Size = new System.Drawing.Size(285, 26);
            this.txtroomId.TabIndex = 21;
            // 
            // CheckInSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.txtroomId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnuserIdSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpchedout);
            this.Controls.Add(this.dtpcheckedIn);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.dtpchekhout);
            this.Controls.Add(this.dtchekedin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbedType);
            this.Controls.Add(this.cmbroomType);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "CheckInSystem";
            this.Text = "CheckInSystem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ComboBox cmbroomType;
        private System.Windows.Forms.ComboBox cmbbedType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dtchekedin;
        private System.Windows.Forms.Label dtpchekhout;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.DateTimePicker dtpcheckedIn;
        private System.Windows.Forms.DateTimePicker dtpchedout;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnuserIdSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtroomId;
    }
}