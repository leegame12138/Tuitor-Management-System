using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace IOOP_project
{
    public partial class Admin_Tutor_Register : Form
    {
        public Admin_Tutor_Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssignNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Tutor_Assign tutor_Assign = new Admin_Tutor_Assign();
            tutor_Assign.StartPosition = FormStartPosition.Manual;
            tutor_Assign.Location = new Point(100, 100);
            tutor_Assign.ShowDialog();
        }

        private void btnDeleteNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Tutor_Delete tutor_Delete = new Admin_Tutor_Delete();
            tutor_Delete.StartPosition = FormStartPosition.Manual;
            tutor_Delete.Location = new Point(100, 100);
            tutor_Delete.ShowDialog();
            
        }

        private void btnRegisterTutor_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtFullname.Text)) || (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(txtAddress.Text)) || (string.IsNullOrWhiteSpace(txtRegisterTutorUsername.Text)) || (string.IsNullOrWhiteSpace(txtIC.Text)) || (string.IsNullOrWhiteSpace(txtContact.Text)))
                MessageBox.Show("All Information must be filled in.");

            else
            {
                User obj1 = new User("tutor", txtRegisterTutorUsername.Text, txtFullname.Text, txtIC.Text, txtEmail.Text, txtContact.Text, txtAddress.Text);

                if (obj1.register())
                {
                    txtRegisterTutorUsername.Text = string.Empty;
                    txtFullname.Text = string.Empty;
                    txtIC.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtContact.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
            }

            txtRegisterTutorUsername.Focus();

        }
    }
}
