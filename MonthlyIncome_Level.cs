using System;
using System.Collections;
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
    public partial class MonthlyIncome_Level : Form
    {
        public MonthlyIncome_Level()
        {
            InitializeComponent();
        }

        private void MonthlyIncome_Level_Load(object sender, EventArgs e)
        {
            ArrayList SubjectProfit = new ArrayList();
            SubjectProfit = Admin.generateReport("level");
            int ctr = 0;
            foreach (string i in SubjectProfit)
            {
                listView.Items[ctr].SubItems.Add(i);
                ctr++;
            }



            /*            ArrayList SubjectProfit = new ArrayList();
                        SubjectProfit = IncomeReport.generateReport("level");
                        foreach (string i in SubjectProfit)    
                        {
                            listBoxProfit.Items.Add(i);
                        }

            */
        }

    }
}
