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
    public partial class MonthlyIncomeReport : Form
    {
        public MonthlyIncomeReport()
        {
            InitializeComponent();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            MonthlyIncome_Course monthlyIncome_Course = new MonthlyIncome_Course();
            monthlyIncome_Course.ShowDialog();
        }

        private void btnLevel_Click(object sender, EventArgs e)
        {
            MonthlyIncome_Level monthlyIncome_Level = new MonthlyIncome_Level();
            monthlyIncome_Level.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
