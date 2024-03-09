using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_project
{
    public partial class Admin_Receptionist_Register : Form
    {
        public Admin_Receptionist_Register()
        {
            InitializeComponent();
        }

        private void btnDeleteNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Receptionist_Delete receptionist_Delete = new Admin_Receptionist_Delete();
            receptionist_Delete.StartPosition = FormStartPosition.Manual;
            receptionist_Delete.Location = new Point(100, 100);
            receptionist_Delete.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtFullname.Text)) || (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(txtAddress.Text)) || (string.IsNullOrWhiteSpace(txtRegisterReceptionistUsername.Text)) || (string.IsNullOrWhiteSpace(txtIC.Text)) || (string.IsNullOrWhiteSpace(txtContact.Text)))
                MessageBox.Show("All Information must be filled in.");

            else
            {
                User obj1 = new User("receptionist", txtRegisterReceptionistUsername.Text, txtFullname.Text, txtIC.Text, txtEmail.Text, txtContact.Text, txtAddress.Text);

                if (obj1.register())
                {
                    txtRegisterReceptionistUsername.Text = string.Empty;
                    txtFullname.Text = string.Empty;
                    txtIC.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtContact.Text = string.Empty;
                    txtAddress.Text = string.Empty;
                }
            }

            txtRegisterReceptionistUsername.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
