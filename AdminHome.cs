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
    public partial class AdminHome : Form
    {
        private static string name;

        public AdminHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "Hello, " + name;
        }

        private void btnTutorManage_Click(object sender, EventArgs e)
        {
            TutorManagement tutorManagement= new TutorManagement(name);
            tutorManagement.ShowDialog();
        }

        private void btnReceptManage_Click(object sender, EventArgs e)
        {
            ReceptionistManagement receptionistManagement = new ReceptionistManagement(name);
            receptionistManagement.ShowDialog();
        }

        private void btnMonthlyIncomeReport_Click(object sender, EventArgs e)
        {
            MonthlyIncomeReport monthlyIncomeReport = new MonthlyIncomeReport();
            monthlyIncomeReport.ShowDialog();
        }

        private void btnUpdateOwnProfile_Click(object sender, EventArgs e)
        {
            Admin_UpdateProfile updateOwnAdminProfile = new Admin_UpdateProfile(name);
            updateOwnAdminProfile.ShowDialog();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
