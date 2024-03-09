namespace IOOP_project
{
    partial class Admin_Tutor_Delete
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
            this.cmbTutorList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAssignNavi = new System.Windows.Forms.Button();
            this.btnDeleteNavi = new System.Windows.Forms.Button();
            this.btnRegisterNavi = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIC = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTutorList
            // 
            this.cmbTutorList.FormattingEnabled = true;
            this.cmbTutorList.Location = new System.Drawing.Point(449, 184);
            this.cmbTutorList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTutorList.Name = "cmbTutorList";
            this.cmbTutorList.Size = new System.Drawing.Size(167, 33);
            this.cmbTutorList.TabIndex = 3;
            this.cmbTutorList.SelectedIndexChanged += new System.EventHandler(this.cmbTutorList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(371, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutor :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnAssignNavi);
            this.panel1.Controls.Add(this.btnDeleteNavi);
            this.panel1.Controls.Add(this.btnRegisterNavi);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 578);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IOOP_project.Properties.Resources.IOOP_TuitionLogo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnAssignNavi
            // 
            this.btnAssignNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAssignNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssignNavi.Location = new System.Drawing.Point(0, 308);
            this.btnAssignNavi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssignNavi.Name = "btnAssignNavi";
            this.btnAssignNavi.Size = new System.Drawing.Size(197, 60);
            this.btnAssignNavi.TabIndex = 38;
            this.btnAssignNavi.Text = "Assign Tutors";
            this.btnAssignNavi.UseVisualStyleBackColor = false;
            this.btnAssignNavi.Click += new System.EventHandler(this.btnAssignNavi_Click);
            // 
            // btnDeleteNavi
            // 
            this.btnDeleteNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNavi.Location = new System.Drawing.Point(0, 249);
            this.btnDeleteNavi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteNavi.Name = "btnDeleteNavi";
            this.btnDeleteNavi.Size = new System.Drawing.Size(197, 60);
            this.btnDeleteNavi.TabIndex = 37;
            this.btnDeleteNavi.Text = "Delete Tutors";
            this.btnDeleteNavi.UseVisualStyleBackColor = false;
            // 
            // btnRegisterNavi
            // 
            this.btnRegisterNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnRegisterNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterNavi.Location = new System.Drawing.Point(0, 185);
            this.btnRegisterNavi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterNavi.Name = "btnRegisterNavi";
            this.btnRegisterNavi.Size = new System.Drawing.Size(197, 65);
            this.btnRegisterNavi.TabIndex = 36;
            this.btnRegisterNavi.Text = " Register Tutors";
            this.btnRegisterNavi.UseVisualStyleBackColor = false;
            this.btnRegisterNavi.Click += new System.EventHandler(this.btnRegisterNavi_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(0, 516);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(197, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDelete.Location = new System.Drawing.Point(449, 468);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 54);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.Controls.Add(this.lblContact);
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblEmail);
            this.panel2.Controls.Add(this.lblIC);
            this.panel2.Controls.Add(this.lblFullname);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(269, 281);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 156);
            this.panel2.TabIndex = 37;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblContact.Location = new System.Drawing.Point(327, 50);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(0, 22);
            this.lblContact.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(91, 119);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 22);
            this.lblAddress.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(82, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 22);
            this.lblEmail.TabIndex = 7;
            // 
            // lblIC
            // 
            this.lblIC.AutoSize = true;
            this.lblIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblIC.Location = new System.Drawing.Point(56, 50);
            this.lblIC.Name = "lblIC";
            this.lblIC.Size = new System.Drawing.Size(0, 22);
            this.lblIC.TabIndex = 6;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblFullname.Location = new System.Drawing.Point(103, 15);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(0, 22);
            this.lblFullname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(257, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "IC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fullname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(436, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 52);
            this.label7.TabIndex = 39;
            this.label7.Text = "Delete Tutor";
            // 
            // Admin_Tutor_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTutorList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin_Tutor_Delete";
            this.Text = "Tutor_Delete";
            this.Load += new System.EventHandler(this.Tutor_Delete_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox cmbTutorList;
        private Label label1;
        private Panel panel1;
        private Button btnAssignNavi;
        private Button btnDeleteNavi;
        private Button btnRegisterNavi;
        private Button btnExit;
        private Button btnDelete;
        private Panel panel2;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label lblContact;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblIC;
        private Label lblFullname;
        private PictureBox pictureBox1;
    }
}