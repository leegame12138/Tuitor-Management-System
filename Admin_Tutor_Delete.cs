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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_project
{
    public partial class Admin_Tutor_Delete : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public Admin_Tutor_Delete()
        {
            InitializeComponent();
        }
            
        private void Tutor_Delete_Load(object sender, EventArgs e)
        {

            User obj1 = new User();
            foreach (string s in (obj1.viewAll("tutors")).Split(','))
            {
                if(!(string.IsNullOrEmpty(s)))
                    cmbTutorList.Items.Add(s);
            }

            lblAddress.Text= string.Empty;
            lblContact.Text= string.Empty;
            lblEmail.Text= string.Empty;
            lblFullname.Text= string.Empty;
            lblIC.Text= string.Empty;

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

        private void btnRegisterNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Tutor_Register tutor_Register = new Admin_Tutor_Register();
            tutor_Register.StartPosition = FormStartPosition.Manual;
            tutor_Register.Location = new Point(100, 100);
            tutor_Register.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string stat = null;

            if (cmbTutorList.SelectedIndex != -1) //Make Sure User selected something in ComboBox
            {
                string selection = cmbTutorList.SelectedItem.ToString();

                Admin obj1 = new Admin();

                if (obj1.delete("tutors", selection))
                {
                    stat = "Successfully Deleted";
                    cmbTutorList.Items.Remove(selection);
                    cmbTutorList.Text = "";
                    lblFullname.Text = "";
                    lblIC.Text = "";
                    lblEmail.Text = "";
                    lblContact.Text = "";
                    lblAddress.Text = "";
                }
                else
                    stat = "Fail to Delete";
            }
            else
                stat = "Selection cannot be empty.";

            MessageBox.Show(stat);
            con.Close();

        }

        private void cmbTutorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList informationList = new ArrayList();
            informationList = User.getUserInformation("tutors", cmbTutorList.Text);
            lblFullname.Text = informationList[0].ToString();
            lblIC.Text = informationList[1].ToString();
            lblEmail.Text = informationList[2].ToString();
            lblContact.Text = informationList[3].ToString();
            lblAddress.Text = informationList[4].ToString();

        }
    }
}
