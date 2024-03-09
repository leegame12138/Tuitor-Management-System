namespace IOOP_project
{
    partial class MonthlyIncomeReport
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
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpboxMonthlyIncomeReport = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpboxMonthlyIncomeReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLevel
            // 
            this.btnLevel.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnLevel.Location = new System.Drawing.Point(152, 139);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(279, 48);
            this.btnLevel.TabIndex = 1;
            this.btnLevel.Text = "Category by Level";
            this.btnLevel.UseVisualStyleBackColor = true;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnSubject.Location = new System.Drawing.Point(152, 200);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(279, 48);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Category by Subjects";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(90, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Montly Income Report";
            // 
            // grpboxMonthlyIncomeReport
            // 
            this.grpboxMonthlyIncomeReport.BackColor = System.Drawing.Color.OldLace;
            this.grpboxMonthlyIncomeReport.Controls.Add(this.btnBack);
            this.grpboxMonthlyIncomeReport.Controls.Add(this.label3);
            this.grpboxMonthlyIncomeReport.Controls.Add(this.btnSubject);
            this.grpboxMonthlyIncomeReport.Controls.Add(this.label4);
            this.grpboxMonthlyIncomeReport.Controls.Add(this.btnLevel);
            this.grpboxMonthlyIncomeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpboxMonthlyIncomeReport.ForeColor = System.Drawing.Color.SteelBlue;
            this.grpboxMonthlyIncomeReport.Location = new System.Drawing.Point(98, 64);
            this.grpboxMonthlyIncomeReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxMonthlyIncomeReport.Name = "grpboxMonthlyIncomeReport";
            this.grpboxMonthlyIncomeReport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpboxMonthlyIncomeReport.Size = new System.Drawing.Size(558, 421);
            this.grpboxMonthlyIncomeReport.TabIndex = 11;
            this.grpboxMonthlyIncomeReport.TabStop = false;
            this.grpboxMonthlyIncomeReport.Text = "Welcome!";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Location = new System.Drawing.Point(235, 287);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(178, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "like to proceed with today?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "What will you";
            // 
            // MonthlyIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IOOP_project.Properties.Resources.Screenshot_2023_02_17_175947;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpboxMonthlyIncomeReport);
            this.Name = "MonthlyIncomeReport";
            this.Text = "MonthlyIncomeReport";
            this.grpboxMonthlyIncomeReport.ResumeLayout(false);
            this.grpboxMonthlyIncomeReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnLevel;
        private Button btnSubject;
        private Label label2;
        private GroupBox grpboxMonthlyIncomeReport;
        private Button btnBack;
        private Label label3;
        private Label label4;
    }
}