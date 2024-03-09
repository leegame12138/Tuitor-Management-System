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
    public partial class Admin_UpdatePassword : Form
    {

        string name;
        public Admin_UpdatePassword(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User obj1 = new User(name,txtOldPass.Text,txtNewPass.Text,txtConfirmNewPass.Text);
            if (obj1.changePassword())
            {
                this.Close();
            }
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            Admin_UpdateProfile updateOwnAdminProfile = new Admin_UpdateProfile(name);
            updateOwnAdminProfile.Show();
        }

        private void checkboxShowOldPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxShowOldPass.Checked)
            {
                txtOldPass.UseSystemPasswordChar= false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
            }
        }

        private void checkboxShowNewPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxShowNewPass.Checked)
            {
                txtNewPass.UseSystemPasswordChar= false;
                txtConfirmNewPass.UseSystemPasswordChar= false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
                txtConfirmNewPass.UseSystemPasswordChar = true;
            }
        }
    }
}
