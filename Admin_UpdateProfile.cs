using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_project
{
    public partial class Admin_UpdateProfile : Form
    {
        private static string name;
        string userInformation;
        public Admin_UpdateProfile(string n)
        {
            InitializeComponent();
            name = n;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            User obj1 = new User("Admins", name, txtFullname.Text, txtIC.Text, txtEmail.Text, txtContact.Text, txtAddress.Text);
            MessageBox.Show(obj1.updateUserProfile());
        }

        private void UpdateOwnAdminProfile_Load(object sender, EventArgs e)
        {
            User obj1 = new User();
            ArrayList arrayList = new ArrayList();
            arrayList = User.getUserInformation("Admins", name);

            txtFullname.Text = arrayList[0].ToString();
            txtIC.Text = arrayList[1].ToString();
            txtEmail.Text = arrayList[2].ToString();
            txtContact.Text = arrayList[3].ToString();
            txtAddress.Text = arrayList[4].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            Admin_UpdatePassword updatePassword = new Admin_UpdatePassword(name);
            updatePassword.Show();
        }


    }
}
