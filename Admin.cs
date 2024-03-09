using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_project
{
    internal class Admin
    {
        public Admin() { }

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());



        public static ArrayList viewTutorRespectiveLevelAndClass(string username)
        {
            ArrayList tutorInformation = new ArrayList();
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TutorRespectiveLevelAndSubject where username = '" + username + "';", con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tutorInformation.Add(rd.GetString(2) + "," + rd.GetString(3));
            }
            con.Close();
            return tutorInformation;
        }

        public void assign(string tutor, string subject, ArrayList list)
        {
            con.Open();

            SqlCommand cmd2 = new SqlCommand("Delete from TutorRespectiveLevelAndSubject where username = '" + tutor + "';", con);
            cmd2.ExecuteNonQuery();

            foreach (int i in list)
            {
                SqlCommand cmd = new SqlCommand("insert into TutorRespectiveLevelAndSubject (username,subject,level) values ('" + tutor + "','" + subject + "','" + (i + 1) + "');", con);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Successfully Assign Tutor.");
            con.Close();
        }

        public bool delete(string role, string username)
        {
            bool status = false;

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + role + " WHERE username = '" + username + "'", con);
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Users WHERE username = '" + username + "'", con);

            if (role == "tutors")
            {
                SqlCommand cmd3 = new SqlCommand("DELETE FROM TutorRespectiveLevelAndSubject WHERE username = '" + username + "'", con);
                cmd3.ExecuteNonQuery();
            }

            if (cmd.ExecuteNonQuery() != -1)
            {
                cmd2.ExecuteNonQuery();
                status = true;
            }
            else
                MessageBox.Show("Fail to Delete");
            con.Close();
            return status;

        }

        public static ArrayList generateReport(string catogory)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(subject) from subjects;", con); //Subject Number/Quantity
            int subjectQuantity = Convert.ToInt32(cmd.ExecuteScalar().ToString());


            int totalprofit = 0;

            string[] subject = new string[subjectQuantity];
            int[] subjectCharges = new int[subjectQuantity];
            int[] studentEmrolledQuantity = new int[subjectQuantity];

            ArrayList SubjectProfit = new ArrayList();


            SqlCommand cmd2 = new SqlCommand("select subject from subjects;", con); //subject Name
            SqlDataReader rd = cmd2.ExecuteReader();

            int ctr = 0;
            while (rd.Read())
            {
                subject[ctr] = (rd.GetString(0));
                ctr++;
            }
            rd.Close();



            SqlCommand cmd3 = new SqlCommand("select chargesPerMonth from subjects;", con); //fee
            rd = cmd3.ExecuteReader();

            ctr = 0;
            while (rd.Read())
            {
                subjectCharges[ctr] = Convert.ToInt32(rd.GetString(0));
                ctr++;
            }
            rd.Close();

            if (catogory == "subject")
            {
                ctr = 0;
                foreach (object s in subject)
                {
                    SqlCommand cmd4 = new SqlCommand("select count(subject) from SubjectEnrollment where subject = '" + s.ToString() + "';", con);
                    studentEmrolledQuantity[ctr] = (Convert.ToInt32(cmd4.ExecuteScalar().ToString())); //Store number of student in certain Subject into Array
                    ctr++;
                }

                for (int i = 0; i < subjectQuantity; i++)
                {

                    int StudentNumber = Convert.ToInt32(studentEmrolledQuantity[i].ToString());
                    int SubjectCharge = Convert.ToInt32(subjectCharges[i].ToString());

                    totalprofit += StudentNumber * SubjectCharge;
                    SubjectProfit.Add(subject[i] + "," + (StudentNumber * SubjectCharge));

                    if (i == subjectQuantity - 1)
                    {
                        SubjectProfit.Add(" , ");
                        SubjectProfit.Add("Total:," + totalprofit); //Can make the total profit looks nicer
                    }
                }

            }

            else //Level
            {
                int totalProfit = 0;

                for (int level = 1; level <= 5; level++)
                {
                    int profit = 0;

                    foreach (object s in subject)
                    {
                        SqlCommand cmd5 = new SqlCommand("select count(*) from SubjectEnrollment where subject = '" + s.ToString() + "' AND level = '" + level.ToString() + "';", con);
                        int studentNumber = (Convert.ToInt32(cmd5.ExecuteScalar())); //Store number of student in certain Subject of certain level into Array

                        SqlCommand cmd6 = new SqlCommand("select chargesPerMonth from subjects where subject = '" + s.ToString() + "'", con);
                        int subjectCharge = Convert.ToInt32(cmd6.ExecuteScalar()); //Fee for certain subject

                        profit += (subjectCharge * studentNumber);

                    }

                    totalprofit += profit;
                    SubjectProfit.Add(profit.ToString());
                }
                SubjectProfit.Add("");
                SubjectProfit.Add(totalprofit.ToString());

            }


            con.Close();
            return SubjectProfit;
        }



    }
}
