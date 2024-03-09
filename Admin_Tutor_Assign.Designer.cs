namespace IOOP_project
{
    partial class Admin_Tutor_Assign
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
            this.cmbTutorList = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkListLevel = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDeleteNavi = new System.Windows.Forms.Button();
            this.btnRegisterNavi = new System.Windows.Forms.Button();
            this.btnAssign = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTutorList
            // 
            this.cmbTutorList.FormattingEnabled = true;
            this.cmbTutorList.Location = new System.Drawing.Point(74, 82);
            this.cmbTutorList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTutorList.Name = "cmbTutorList";
            this.cmbTutorList.Size = new System.Drawing.Size(167, 33);
            this.cmbTutorList.TabIndex = 0;
            this.cmbTutorList.SelectedIndexChanged += new System.EventHandler(this.cmbTutorList_SelectedIndexChanged);
            // 
            // cmbSubject
            // 
            this.cmbSubject.Enabled = false;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(74, 171);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(167, 33);
            this.cmbSubject.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tutor :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(74, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(344, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Level :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(428, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 52);
            this.label4.TabIndex = 7;
            this.label4.Text = "Assign Tutor";
            // 
            // checkListLevel
            // 
            this.checkListLevel.BackColor = System.Drawing.Color.Snow;
            this.checkListLevel.Enabled = false;
            this.checkListLevel.FormattingEnabled = true;
            this.checkListLevel.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5"});
            this.checkListLevel.Location = new System.Drawing.Point(344, 82);
            this.checkListLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkListLevel.Name = "checkListLevel";
            this.checkListLevel.Size = new System.Drawing.Size(166, 116);
            this.checkListLevel.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnDeleteNavi);
            this.panel1.Controls.Add(this.btnRegisterNavi);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 578);
            this.panel1.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IOOP_project.Properties.Resources.IOOP_TuitionLogo;
            this.pictureBox2.Location = new System.Drawing.Point(36, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 301);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Assign Tutors";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(0, 514);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 48);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Back";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteNavi
            // 
            this.btnDeleteNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnDeleteNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteNavi.Location = new System.Drawing.Point(0, 242);
            this.btnDeleteNavi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteNavi.Name = "btnDeleteNavi";
            this.btnDeleteNavi.Size = new System.Drawing.Size(198, 60);
            this.btnDeleteNavi.TabIndex = 1;
            this.btnDeleteNavi.Text = "Delete Tutors";
            this.btnDeleteNavi.UseVisualStyleBackColor = false;
            this.btnDeleteNavi.Click += new System.EventHandler(this.btnDeleteNavi_Click);
            // 
            // btnRegisterNavi
            // 
            this.btnRegisterNavi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnRegisterNavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterNavi.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegisterNavi.Location = new System.Drawing.Point(0, 179);
            this.btnRegisterNavi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterNavi.Name = "btnRegisterNavi";
            this.btnRegisterNavi.Size = new System.Drawing.Size(198, 65);
            this.btnRegisterNavi.TabIndex = 0;
            this.btnRegisterNavi.Text = " Register Tutors";
            this.btnRegisterNavi.UseVisualStyleBackColor = false;
            this.btnRegisterNavi.Click += new System.EventHandler(this.btnRegisterNavi_Click);
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAssign.Font = new System.Drawing.Font("MV Boli", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssign.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAssign.Location = new System.Drawing.Point(446, 425);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(149, 54);
            this.btnAssign.TabIndex = 22;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkListLevel);
            this.panel2.Controls.Add(this.cmbTutorList);
            this.panel2.Controls.Add(this.cmbSubject);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(244, 115);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 282);
            this.panel2.TabIndex = 23;
            // 
            // Admin_Tutor_Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Admin_Tutor_Assign";
            this.Text = "Tutor_Assign";
            this.Load += new System.EventHandler(this.Tutor_Assign_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbTutorList;
        private ComboBox cmbSubject;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ToolTip toolTip1;
        private CheckedListBox checkListLevel;
        private Panel panel1;
        private Button btnExit;
        private Button btnDeleteNavi;
        private Button btnRegisterNavi;
        private Button button1;
        private Button btnAssign;
        private Panel panel2;
        private PictureBox pictureBox2;
    }
}