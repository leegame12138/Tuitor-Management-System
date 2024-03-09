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
    public partial class Admin_Tutor_Assign : Form
    {

        public Admin_Tutor_Assign()
        {
            InitializeComponent();
        }

        private void Tutor_Assign_Load(object sender, EventArgs e)
        {

            User obj1 = new User();
            foreach (string s in (obj1.viewAll("tutors")).Split(','))
            {
                if (!(string.IsNullOrEmpty(s)))
                    cmbTutorList.Items.Add(s);
            }

            foreach (string s in (obj1.viewAll("subjects")).Split(','))
            {
                if (!(string.IsNullOrEmpty(s)))
                    cmbSubject.Items.Add(s);
            }

        }


        private void cmbTutorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTutorList.SelectedIndex != -1)
            {
                cmbSubject.Enabled = true;
                checkListLevel.Enabled = true;

                for(int i = 0; i < 5; i++)
                {
                    checkListLevel.SetItemChecked(i, false); //remove all previous checked list tick
                }

                ArrayList arrayList= new ArrayList();
                arrayList = Admin.viewTutorRespectiveLevelAndClass(cmbTutorList.SelectedItem.ToString());
                foreach(string i in arrayList)
                {
                    cmbSubject.Text = i.Split(',')[0];

                    checkListLevel.SetItemChecked((int.Parse(i.Split(',')[1]))-1,true); 
                }
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex != -1 && cmbTutorList.SelectedIndex != -1 && checkListLevel.CheckedItems.Count >0)
            {
                ArrayList list = new ArrayList();

                for (int i = 0; i < 5; i++)
                {
                    if (checkListLevel.GetItemChecked(i)) //check if the item is being tick 
                    {
                        list.Add(i);
                    }
                }

                Admin obj1 = new Admin();
                obj1.assign(cmbTutorList.Text, cmbSubject.Text, list);

            }
            else
                MessageBox.Show("All the tutor, subjects, and level column can not be empty.");
        }

        private void btnRegisterNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Tutor_Register tutor_Register = new Admin_Tutor_Register();
            tutor_Register.StartPosition = FormStartPosition.Manual;
            tutor_Register.Location = new Point(100, 100);
            tutor_Register.ShowDialog();
        }

        private void btnDeleteNavi_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Tutor_Delete tutor_Delete = new Admin_Tutor_Delete();
            tutor_Delete.StartPosition = FormStartPosition.Manual;
            tutor_Delete.Location = new Point(100, 100);
            tutor_Delete.ShowDialog();
        }
    }
}
