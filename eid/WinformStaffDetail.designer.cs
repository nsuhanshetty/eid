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
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.grbPersonal = new System.Windows.Forms.GroupBox();
            this.grbMartial = new System.Windows.Forms.GroupBox();
            this.dtpDom = new System.Windows.Forms.DateTimePicker();
            this.lblDom = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.grbgender = new System.Windows.Forms.GroupBox();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.lblMartialStatus = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtDobProof = new System.Windows.Forms.TextBox();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtFthrName = new System.Windows.Forms.TextBox();
            this.lblFthrName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.GrbContact = new System.Windows.Forms.GroupBox();
            this.txtMobNo = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPresAdd = new System.Windows.Forms.TextBox();
            this.lblPresAdd = new System.Windows.Forms.Label();
            this.txtPermAdd = new System.Windows.Forms.TextBox();
            this.lblPermAdd = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtWifeName = new System.Windows.Forms.TextBox();
            this.lblWifeName = new System.Windows.Forms.Label();
            this.txtNoOfChild = new System.Windows.Forms.TextBox();
            this.lblNoOfChild = new System.Windows.Forms.Label();
            this.btnNoOfChildProof = new System.Windows.Forms.Button();
            this.txtNoOfChildProof = new System.Windows.Forms.TextBox();
            this.pnlStaff.SuspendLayout();
            this.grbPersonal.SuspendLayout();
            this.grbMartial.SuspendLayout();
            this.grbgender.SuspendLayout();
            this.grpImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.GrbContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStaff
            // 
            this.pnlStaff.Controls.Add(this.grbPersonal);
            this.pnlStaff.Controls.Add(this.grpImage);
            this.pnlStaff.Controls.Add(this.GrbContact);
            this.pnlStaff.Location = new System.Drawing.Point(0, 81);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(766, 438);
            this.pnlStaff.TabIndex = 5;
            // 
            // grbPersonal
            // 
            this.grbPersonal.Controls.Add(this.grbMartial);
            this.grbPersonal.Controls.Add(this.btnAttach);
            this.grbPersonal.Controls.Add(this.grbgender);
            this.grbPersonal.Controls.Add(this.lblMartialStatus);
            this.grbPersonal.Controls.Add(this.dtpDob);
            this.grbPersonal.Controls.Add(this.txtDobProof);
            this.grbPersonal.Controls.Add(this.lblDob);
            this.grbPersonal.Controls.Add(this.txtFthrName);
            this.grbPersonal.Controls.Add(this.lblFthrName);
            this.grbPersonal.Controls.Add(this.txtName);
            this.grbPersonal.Controls.Add(this.lblName);
            this.grbPersonal.Location = new System.Drawing.Point(5, 3);
            this.grbPersonal.Name = "grbPersonal";
            this.grbPersonal.Size = new System.Drawing.Size(569, 252);
            this.grbPersonal.TabIndex = 15;
            this.grbPersonal.TabStop = false;
            this.grbPersonal.Text = "PERSONAL DETAILS";
            // 
            // grbMartial
            // 
            this.grbMartial.Controls.Add(this.btnNoOfChildProof);
            this.grbMartial.Controls.Add(this.txtNoOfChildProof);
            this.grbMartial.Controls.Add(this.txtNoOfChild);
            this.grbMartial.Controls.Add(this.lblNoOfChild);
            this.grbMartial.Controls.Add(this.txtWifeName);
            this.grbMartial.Controls.Add(this.lblWifeName);
            this.grbMartial.Controls.Add(this.dtpDom);
            this.grbMartial.Controls.Add(this.lblDom);
            this.grbMartial.Location = new System.Drawing.Point(10, 131);
            this.grbMartial.Name = "grbMartial";
            this.grbMartial.Size = new System.Drawing.Size(527, 96);
            this.grbMartial.TabIndex = 83;
            this.grbMartial.TabStop = false;
            this.grbMartial.Enter += new System.EventHandler(this.grbMartial_Enter);
            // 
            // dtpDom
            // 
            this.dtpDom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDom.Location = new System.Drawing.Point(103, 12);
            this.dtpDom.Name = "dtpDom";
            this.dtpDom.Size = new System.Drawing.Size(187, 20);
            this.dtpDom.TabIndex = 81;
            this.dtpDom.Value = new System.DateTime(2013, 5, 21, 8, 15, 0, 0);
            // 
            // lblDom
            // 
            this.lblDom.AutoSize = true;
            this.lblDom.Location = new System.Drawing.Point(6, 18);
            this.lblDom.Name = "lblDom";
            this.lblDom.Size = new System.Drawing.Size(88, 13);
            this.lblDom.TabIndex = 80;
            this.lblDom.Text = "Date Of Marriage";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(439, 72);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(82, 23);
            this.btnAttach.TabIndex = 82;
            this.btnAttach.Text = "Attach Proof";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // grbgender
            // 
            this.grbgender.Controls.Add(this.rdbSingle);
            this.grbgender.Controls.Add(this.rdbMarried);
            this.grbgender.Location = new System.Drawing.Point(103, 97);
            this.grbgender.Name = "grbgender";
            this.grbgender.Size = new System.Drawing.Size(187, 28);
            this.grbgender.TabIndex = 81;
            this.grbgender.TabStop = false;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(102, 9);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(54, 17);
            this.rdbSingle.TabIndex = 1;
            this.rdbSingle.TabStop = true;
            this.rdbSingle.Text = "Single";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(19, 9);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(60, 17);
            this.rdbMarried.TabIndex = 0;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // lblMartialStatus
            // 
            this.lblMartialStatus.AutoSize = true;
            this.lblMartialStatus.Location = new System.Drawing.Point(6, 108);
            this.lblMartialStatus.Name = "lblMartialStatus";
            this.lblMartialStatus.Size = new System.Drawing.Size(71, 13);
            this.lblMartialStatus.TabIndex = 80;
            this.lblMartialStatus.Text = "Martial Status";
            // 
            // dtpDob
            // 
            this.dtpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDob.Location = new System.Drawing.Point(103, 74);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(187, 20);
            this.dtpDob.TabIndex = 79;
            this.dtpDob.Value = new System.DateTime(2013, 5, 21, 8, 15, 0, 0);
            // 
            // txtDobProof
            // 
            this.txtDobProof.Location = new System.Drawing.Point(307, 74);
            this.txtDobProof.Name = "txtDobProof";
            this.txtDobProof.Size = new System.Drawing.Size(126, 20);
            this.txtDobProof.TabIndex = 77;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(6, 80);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(71, 13);
            this.lblDob.TabIndex = 78;
            this.lblDob.Text = "Date Of Birth ";
            // 
            // txtFthrName
            // 
            this.txtFthrName.Location = new System.Drawing.Point(103, 49);
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
            // grpImage
            // 
            this.grpImage.Controls.Add(this.PictureBox1);
            this.grpImage.Controls.Add(this.Button1);
            this.grpImage.Location = new System.Drawing.Point(580, 3);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(138, 166);
            this.grpImage.TabIndex = 14;
            this.grpImage.TabStop = false;
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
            // txtWifeName
            // 
            this.txtWifeName.Location = new System.Drawing.Point(103, 40);
            this.txtWifeName.Name = "txtWifeName";
            this.txtWifeName.Size = new System.Drawing.Size(187, 20);
            this.txtWifeName.TabIndex = 82;
            // 
            // lblWifeName
            // 
            this.lblWifeName.AutoSize = true;
            this.lblWifeName.Location = new System.Drawing.Point(6, 42);
            this.lblWifeName.Name = "lblWifeName";
            this.lblWifeName.Size = new System.Drawing.Size(67, 13);
            this.lblWifeName.TabIndex = 83;
            this.lblWifeName.Text = "Wife\'s Name";
            // 
            // txtNoOfChild
            // 
            this.txtNoOfChild.Location = new System.Drawing.Point(103, 69);
            this.txtNoOfChild.Name = "txtNoOfChild";
            this.txtNoOfChild.Size = new System.Drawing.Size(187, 20);
            this.txtNoOfChild.TabIndex = 84;
            // 
            // lblNoOfChild
            // 
            this.lblNoOfChild.AutoSize = true;
            this.lblNoOfChild.Location = new System.Drawing.Point(6, 71);
            this.lblNoOfChild.Name = "lblNoOfChild";
            this.lblNoOfChild.Size = new System.Drawing.Size(79, 13);
            this.lblNoOfChild.TabIndex = 85;
            this.lblNoOfChild.Text = "No. Of Children";
            // 
            // btnNoOfChildProof
            // 
            this.btnNoOfChildProof.Location = new System.Drawing.Point(429, 67);
            this.btnNoOfChildProof.Name = "btnNoOfChildProof";
            this.btnNoOfChildProof.Size = new System.Drawing.Size(82, 23);
            this.btnNoOfChildProof.TabIndex = 87;
            this.btnNoOfChildProof.Text = "Attach Proof";
            this.btnNoOfChildProof.UseVisualStyleBackColor = true;
            // 
            // txtNoOfChildProof
            // 
            this.txtNoOfChildProof.Location = new System.Drawing.Point(297, 69);
            this.txtNoOfChildProof.Name = "txtNoOfChildProof";
            this.txtNoOfChildProof.Size = new System.Drawing.Size(126, 20);
            this.txtNoOfChildProof.TabIndex = 86;
            // 
            // WinformEmpReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 546);
            this.Controls.Add(this.pnlStaff);
            this.Name = "WinformEmpReg";
            this.Text = "Employee Registry";
            this.Load += new System.EventHandler(this.WinformStaffDetail_Load);
            this.Controls.SetChildIndex(this.pnlStaff, 0);
            this.pnlStaff.ResumeLayout(false);
            this.grbPersonal.ResumeLayout(false);
            this.grbPersonal.PerformLayout();
            this.grbMartial.ResumeLayout(false);
            this.grbMartial.PerformLayout();
            this.grbgender.ResumeLayout(false);
            this.grbgender.PerformLayout();
            this.grpImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.GrbContact.ResumeLayout(false);
            this.GrbContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlStaff;
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
        private System.Windows.Forms.GroupBox grbPersonal;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.TextBox txtFthrName;
        internal System.Windows.Forms.Label lblFthrName;
        internal System.Windows.Forms.TextBox txtDobProof;
        internal System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDob;
        internal System.Windows.Forms.Label lblMartialStatus;
        private System.Windows.Forms.GroupBox grbgender;
        private System.Windows.Forms.RadioButton rdbSingle;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.GroupBox grbMartial;
        private System.Windows.Forms.DateTimePicker dtpDom;
        internal System.Windows.Forms.Label lblDom;
        internal System.Windows.Forms.TextBox txtWifeName;
        internal System.Windows.Forms.Label lblWifeName;
        internal System.Windows.Forms.TextBox txtNoOfChild;
        internal System.Windows.Forms.Label lblNoOfChild;
        private System.Windows.Forms.Button btnNoOfChildProof;
        internal System.Windows.Forms.TextBox txtNoOfChildProof;
    }
}