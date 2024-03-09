namespace IOOP_project
{
    partial class Admin_Tutor_Register
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
            this.components = new System.ComponentModel.Container();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssignNavi = new System.Windows.Forms.Button();
            this.btnDeleteNavi = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRegisterTutor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRegisterTutorUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(237, 160);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(349, 27);
            this.txtFullname.TabIndex = 1;
            // 
            // txtIC
            // 
            this.txtIC.Location = new System.Drawing.Point(237, 223);
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(193, 27);
            this.txtIC.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(237, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(481, 223);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(193, 27);
            this.txtContact.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(237, 366);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(349, 27);
            this.txtAddress.TabIndex = 5;
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Black;
            this.toolTip1.ToolTipTitle = "IC & CONTACT Must Contain Only Numeric.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IOOP_project.Properties.Resources.IOOP_TuitionLogo;
            this.pictureBox1.Location = new System.Drawing.Point(33, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(0, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.btnAssignNavi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDeleteNavi);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 462);
            this.panel1.TabIndex = 34;
            // 
            // btnAssignNavi
            // 
            this.btnAssignNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnAssignNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssignNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssignNavi.Location = new System.Drawing.Point(0, 246);
            this.btnAssignNavi.Name = "btnAssignNavi";
            this.btnAssignNavi.Size = new System.Drawing.Size(178, 48);
            this.btnAssignNavi.TabIndex = 9;
            this.btnAssignNavi.Text = "Assign Tutors";
            this.btnAssignNavi.UseVisualStyleBackColor = false;
            this.btnAssignNavi.Click += new System.EventHandler(this.btnAssignNavi_Click);
            // 
            // btnDeleteNavi
            // 
            this.btnDeleteNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNavi.Location = new System.Drawing.Point(0, 199);
            this.btnDeleteNavi.Name = "btnDeleteNavi";
            this.btnDeleteNavi.Size = new System.Drawing.Size(178, 48);
            this.btnDeleteNavi.TabIndex = 8;
            this.btnDeleteNavi.Text = "Delete Tutors";
            this.btnDeleteNavi.UseVisualStyleBackColor = false;
            this.btnDeleteNavi.Click += new System.EventHandler(this.btnDeleteNavi_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FloralWhite;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(0, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = " Register Tutors";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnRegisterTutor
            // 
            this.btnRegisterTutor.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegisterTutor.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterTutor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRegisterTutor.Location = new System.Drawing.Point(636, 356);
            this.btnRegisterTutor.Name = "btnRegisterTutor";
            this.btnRegisterTutor.Size = new System.Drawing.Size(134, 43);
            this.btnRegisterTutor.TabIndex = 6;
            this.btnRegisterTutor.Text = "Register";
            this.btnRegisterTutor.UseVisualStyleBackColor = false;
            this.btnRegisterTutor.Click += new System.EventHandler(this.btnRegisterTutor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(237, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "ADDRESS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(481, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "CONTACT:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(237, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "EMAIL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(237, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "IC:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(237, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "FULLNAME:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(362, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 45);
            this.label13.TabIndex = 23;
            this.label13.Text = "Register Tutor";
            // 
            // txtRegisterTutorUsername
            // 
            this.txtRegisterTutorUsername.Location = new System.Drawing.Point(238, 101);
            this.txtRegisterTutorUsername.Name = "txtRegisterTutorUsername";
            this.txtRegisterTutorUsername.Size = new System.Drawing.Size(192, 27);
            this.txtRegisterTutorUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(237, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "USERNAME:";
            // 
            // Tutor_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegisterTutor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIC);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtRegisterTutorUsername);
            this.Name = "Tutor_Register";
            this.Text = "Tutor_Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtFullname;
        private TextBox txtIC;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtAddress;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Panel panel1;
        private Button btnRegisterTutor;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtRegisterTutorUsername;
        private Button btnAssignNavi;
        private Button btnDeleteNavi;
        private Button button3;
        private Label label1;
    }
}