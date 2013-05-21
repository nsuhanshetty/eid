namespace eid
{
    partial class WinformEmpReg : WinformAbstract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinformEmpReg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrbContact = new System.Windows.Forms.GroupBox();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPresAdd = new System.Windows.Forms.TextBox();
            this.lblPresAdd = new System.Windows.Forms.Label();
            this.txtPermAdd = new System.Windows.Forms.TextBox();
            this.lblPermAdd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFthrName = new System.Windows.Forms.TextBox();
            this.lblFthrName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GrbContact.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.GrbContact);
            this.panel1.Location = new System.Drawing.Point(12, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 364);
            this.panel1.TabIndex = 5;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(6, 131);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(130, 28);
            this.Button1.TabIndex = 12;
            this.Button1.Text = "UPLOAD PHOTO";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(6, 11);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(128, 114);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 13;
            this.PictureBox1.TabStop = false;
            // 
            // GrbContact
            // 
            this.GrbContact.Controls.Add(this.txtMobNo);
            this.GrbContact.Controls.Add(this.lblMobile);
            this.GrbContact.Controls.Add(this.txtPhoneNo);
            this.GrbContact.Controls.Add(this.lblPhone);
            this.GrbContact.Controls.Add(this.txtPresAdd);
            this.GrbContact.Controls.Add(this.lblPresAdd);
            this.GrbContact.Controls.Add(this.txtPermAdd);
            this.GrbContact.Controls.Add(this.lblPermAdd);
            this.GrbContact.Location = new System.Drawing.Point(5, 261);
            this.GrbContact.Name = "GrbContact";
            this.GrbContact.Size = new System.Drawing.Size(586, 100);
            this.GrbContact.TabIndex = 6;
            this.GrbContact.TabStop = false;
            this.GrbContact.Text = "CONTACT DETAILS";
            // 
            // txtMobNo
            // 
            this.txtMobNo.Location = new System.Drawing.Point(388, 73);
            this.txtMobNo.Name = "txtMobNo";
            this.txtMobNo.Size = new System.Drawing.Size(107, 20);
            this.txtMobNo.TabIndex = 3;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(304, 76);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(58, 13);
            this.lblMobile.TabIndex = 75;
            this.lblMobile.Text = "Mobile No.";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(103, 73);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(107, 20);
            this.txtPhoneNo.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(8, 77);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 73;
            this.lblPhone.Text = "Phone No.";
            // 
            // txtPresAdd
            // 
            this.txtPresAdd.Location = new System.Drawing.Point(388, 18);
            this.txtPresAdd.Multiline = true;
            this.txtPresAdd.Name = "txtPresAdd";
            this.txtPresAdd.Size = new System.Drawing.Size(187, 49);
            this.txtPresAdd.TabIndex = 1;
            // 
            // lblPresAdd
            // 
            this.lblPresAdd.AutoSize = true;
            this.lblPresAdd.Location = new System.Drawing.Point(303, 20);
            this.lblPresAdd.Name = "lblPresAdd";
            this.lblPresAdd.Size = new System.Drawing.Size(84, 13);
            this.lblPresAdd.TabIndex = 72;
            this.lblPresAdd.Text = "Present Address";
            // 
            // txtPermAdd
            // 
            this.txtPermAdd.Location = new System.Drawing.Point(103, 18);
            this.txtPermAdd.Multiline = true;
            this.txtPermAdd.Name = "txtPermAdd";
            this.txtPermAdd.Size = new System.Drawing.Size(187, 49);
            this.txtPermAdd.TabIndex = 0;
            // 
            // lblPermAdd
            // 
            this.lblPermAdd.AutoSize = true;
            this.lblPermAdd.Location = new System.Drawing.Point(3, 20);
            this.lblPermAdd.Name = "lblPermAdd";
            this.lblPermAdd.Size = new System.Drawing.Size(99, 13);
            this.lblPermAdd.TabIndex = 70;
            this.lblPermAdd.Text = "Permanent Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PictureBox1);
            this.groupBox1.Controls.Add(this.Button1);
            this.groupBox1.Location = new System.Drawing.Point(580, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 166);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFthrName);
            this.groupBox2.Controls.Add(this.lblFthrName);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(5, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 155);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERSONAL DETAILS";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 73;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 13);
            this.lblName.TabIndex = 74;
            this.lblName.Text = "Name (In Full)";
            // 
            // txtFthrName
            // 
            this.txtFthrName.Location = new System.Drawing.Point(103, 48);
            this.txtFthrName.Name = "txtFthrName";
            this.txtFthrName.Size = new System.Drawing.Size(187, 20);
            this.txtFthrName.TabIndex = 75;
            // 
            // lblFthrName
            // 
            this.lblFthrName.AutoSize = true;
            this.lblFthrName.Location = new System.Drawing.Point(6, 51);
            this.lblFthrName.Name = "lblFthrName";
            this.lblFthrName.Size = new System.Drawing.Size(75, 13);
            this.lblFthrName.TabIndex = 76;
            this.lblFthrName.Text = "Father\'s Name";
            // 
            // WinformEmpReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 470);
            this.Controls.Add(this.panel1);
            this.Name = "WinformEmpReg";
            this.Text = "Employee Registry";
            this.Load += new System.EventHandler(this.WinformStaffDetail_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GrbContact.ResumeLayout(false);
            this.GrbContact.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.GroupBox GrbContact;
        internal System.Windows.Forms.TextBox txtMobNo;
        internal System.Windows.Forms.Label lblMobile;
        internal System.Windows.Forms.TextBox txtPhoneNo;
        internal System.Windows.Forms.Label lblPhone;
        internal System.Windows.Forms.TextBox txtPresAdd;
        internal System.Windows.Forms.Label lblPresAdd;
        internal System.Windows.Forms.TextBox txtPermAdd;
        internal System.Windows.Forms.Label lblPermAdd;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.TextBox txtFthrName;
        internal System.Windows.Forms.Label lblFthrName;
    }
}