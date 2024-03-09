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
    public partial class Mainpage : Form
    {
        public Mainpage(string un)
        {
            InitializeComponent();
            Receptionist_UpdateOP r1 = new Receptionist_UpdateOP(un);

        }
/*
        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receptionist_Register obj1 = new Receptionist_Register();
            obj1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }



        private void Deletebtn_Click(object sender, EventArgs e)
        {

        }


        }*/





        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Receptionist_Register obj1 = new Receptionist_Register();
            obj1.ShowDialog();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Receptionist_AcceptUpdate receptionist_AcceptUpdate = new Receptionist_AcceptUpdate();
            receptionist_AcceptUpdate.ShowDialog();
        }

        private void Paymentbtn_Click(object sender, EventArgs e)
        {
            Receptionist_AcceptPayment receptionist_AcceptPayment = new Receptionist_AcceptPayment();
            receptionist_AcceptPayment.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            RegisterStudent registerStudent = new RegisterStudent();
            registerStudent.ShowDialog();
        }

        private void updateMPbtn_Click(object sender, EventArgs e)
        {
            Receptionist_UpdateOP obj1 = new Receptionist_UpdateOP();
            obj1.ShowDialog();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
