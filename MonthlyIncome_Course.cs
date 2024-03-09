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
using System.Xml.Linq;

namespace IOOP_project
{
    public partial class MonthlyIncome_Course : Form
    {
        public MonthlyIncome_Course()
        {
            InitializeComponent();
        }

        private void MonthlyIncome_Course_Load(object sender, EventArgs e)
        {
            ArrayList SubjectProfit = new ArrayList();
            SubjectProfit = Admin.generateReport("subject");
            foreach (string i in SubjectProfit)
            {
                ListViewItem item = new ListViewItem(i.Split(","));
                listView.Items.Add(item);
            }



            /*            ArrayList SubjectProfit= new ArrayList();
                        SubjectProfit = IncomeReport.generateReport("subject");
                        foreach (string i in SubjectProfit) 
                        {
                            listBoxSubject.Items.Add(i.Split(",")[0]);
                            listBoxProfit.Items.Add(i.Split(",")[1]);
                        }
            */
        }
    }
}
