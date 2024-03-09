using System;
using System.Collections;
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

namespace IOOP_project
{
    public partial class Admin_Receptionist_Delete : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Admin_Receptionist_Delete()
        {
            InitializeComponent();
        }

        private void Receptionist_Delete_Load(object sender, EventArgs e)
        {
            User obj1 = new User();
            foreach (string s in (obj1.viewAll("Receptionists")).Split(','))
            {
                if (!(string.IsNullOrEmpty(s)))
                    cmbReceptionistList.Items.Add(s);
            }

            lblAddress.Text = string.Empty;
            lblContact.Text = string.Empty;
            lblEmail.Text = string.Empty;
            lblFullname.Text = string.Empty;
            lblIC.Text = string.Empty;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string stat = null;

            if (cmbReceptionistList.SelectedIndex != -1) //Make Sure User selected something in ComboBox
            {
                string selection = cmbReceptionistList.SelectedItem.ToString();

                Admin obj1 = new Admin();

                if (obj1.delete("Receptionists", selection))
                {
                    stat = "Successfully Deleted";
                    cmbReceptionistList.Items.Remove(selection);
                    cmbReceptionistList.Text = string.Empty;
                    lblFullname.Text = string.Empty;
                    lblIC.Text = string.Empty;
                    lblEmail.Text = string.Empty;
                    lblContact.Text = string.Empty;
                    lblAddress.Text = string.Empty;
                }
                else
                    stat = "Fail to Delete";
            }
            else
                stat = "Selection cannot be empty.";

            MessageBox.Show(stat);
            con.Close();

        }

        private void cmbReceptionistList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList informationList = new ArrayList();
            informationList = User.getUserInformation("Receptionists", cmbReceptionistList.Text);
            lblFullname.Text = informationList[0].ToString();
            lblIC.Text = informationList[1].ToString();
            lblEmail.Text = informationList[2].ToString();
            lblContact.Text = informationList[3].ToString();
            lblAddress.Text = informationList[4].ToString();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnRegisterNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Receptionist_Register receptionist_Register = new Admin_Receptionist_Register();
            receptionist_Register.StartPosition = FormStartPosition.Manual;
            receptionist_Register.Location = new Point(100, 100);
            receptionist_Register.ShowDialog();

        }

    }


}

