namespace IOOP_project
{
    partial class Mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainpage));
            this.label1 = new System.Windows.Forms.Label();
            this.functiongrpb = new System.Windows.Forms.GroupBox();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.updateMPbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Paymentbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.greetinglbl2 = new System.Windows.Forms.Label();
            this.greetinglbl = new System.Windows.Forms.Label();
            this.functiongrpb.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(155, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "The Receptionist Page";
            // 
            // functiongrpb
            // 
            this.functiongrpb.BackColor = System.Drawing.Color.OldLace;
            this.functiongrpb.Controls.Add(this.Logoutbtn);
            this.functiongrpb.Controls.Add(this.updateMPbtn);
            this.functiongrpb.Controls.Add(this.Deletebtn);
            this.functiongrpb.Controls.Add(this.Paymentbtn);
            this.functiongrpb.Controls.Add(this.Updatebtn);
            this.functiongrpb.Controls.Add(this.Registerbtn);
            this.functiongrpb.Controls.Add(this.greetinglbl2);
            this.functiongrpb.Controls.Add(this.greetinglbl);
            this.functiongrpb.Font = new System.Drawing.Font("Stencil Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.functiongrpb.ForeColor = System.Drawing.Color.SteelBlue;
            this.functiongrpb.Location = new System.Drawing.Point(166, 79);
            this.functiongrpb.Name = "functiongrpb";
            this.functiongrpb.Size = new System.Drawing.Size(585, 532);
            this.functiongrpb.TabIndex = 3;
            this.functiongrpb.TabStop = false;
            this.functiongrpb.Text = "Welcome!";
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.ForeColor = System.Drawing.Color.SkyBlue;
            this.Logoutbtn.Location = new System.Drawing.Point(240, 412);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(131, 46);
            this.Logoutbtn.TabIndex = 7;
            this.Logoutbtn.Text = "Log out";
            this.Logoutbtn.UseVisualStyleBackColor = true;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // updateMPbtn
            // 
            this.updateMPbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.updateMPbtn.Location = new System.Drawing.Point(164, 318);
            this.updateMPbtn.Name = "updateMPbtn";
            this.updateMPbtn.Size = new System.Drawing.Size(271, 46);
            this.updateMPbtn.TabIndex = 6;
            this.updateMPbtn.Text = "Update my profile";
            this.updateMPbtn.UseVisualStyleBackColor = true;
            this.updateMPbtn.Click += new System.EventHandler(this.updateMPbtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Deletebtn.Location = new System.Drawing.Point(165, 265);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(270, 46);
            this.Deletebtn.TabIndex = 5;
            this.Deletebtn.Text = "Delete Section";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Paymentbtn
            // 
            this.Paymentbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Paymentbtn.Location = new System.Drawing.Point(165, 213);
            this.Paymentbtn.Name = "Paymentbtn";
            this.Paymentbtn.Size = new System.Drawing.Size(270, 46);
            this.Paymentbtn.TabIndex = 4;
            this.Paymentbtn.Text = "Payment Section";
            this.Paymentbtn.UseVisualStyleBackColor = true;
            this.Paymentbtn.Click += new System.EventHandler(this.Paymentbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Updatebtn.Location = new System.Drawing.Point(165, 159);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(270, 46);
            this.Updatebtn.TabIndex = 3;
            this.Updatebtn.Text = "Update Subject";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.Font = new System.Drawing.Font("Stencil Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Registerbtn.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Registerbtn.Location = new System.Drawing.Point(164, 107);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(271, 46);
            this.Registerbtn.TabIndex = 2;
            this.Registerbtn.Text = "Register student";
            this.Registerbtn.UseVisualStyleBackColor = true;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // greetinglbl2
            // 
            this.greetinglbl2.AutoSize = true;
            this.greetinglbl2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.greetinglbl2.Font = new System.Drawing.Font("Stencil Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greetinglbl2.Location = new System.Drawing.Point(131, 479);
            this.greetinglbl2.Name = "greetinglbl2";
            this.greetinglbl2.Size = new System.Drawing.Size(353, 26);
            this.greetinglbl2.TabIndex = 1;
            this.greetinglbl2.Text = "like to proceed with today?";
            // 
            // greetinglbl
            // 
            this.greetinglbl.AutoSize = true;
            this.greetinglbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.greetinglbl.Font = new System.Drawing.Font("Stencil Std", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.greetinglbl.Location = new System.Drawing.Point(204, 47);
            this.greetinglbl.Name = "greetinglbl";
            this.greetinglbl.Size = new System.Drawing.Size(180, 26);
            this.greetinglbl.TabIndex = 0;
            this.greetinglbl.Text = "What will you";
            // 
            // Mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 610);
            this.Controls.Add(this.functiongrpb);
            this.Controls.Add(this.label1);
            this.Name = "Mainpage";
            this.Text = " ";
            this.functiongrpb.ResumeLayout(false);
            this.functiongrpb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox functiongrpb;
        private Button Logoutbtn;
        private Button updateMPbtn;
        private Button Deletebtn;
        private Button Paymentbtn;
        private Button Updatebtn;
        private Button Registerbtn;
        private Label greetinglbl2;
        private Label greetinglbl;
    }
}