using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Applied
{

    public class SRPAppliedClass
    {
        public class StudentBusinessAccess
        {
            public StudentBusinessAccess()
            {

            }

            public bool SaveStudentDetails(StudentBO studentBO)
            {
                // Save or register the Student Information to Database
                new StudentDAL().SaveStudent(studentBO);

                // Send Email to Admin and Student for the Register Success
                // Send Email to Admin if Register Failed
                EMailUtil.SendEmail(new MailMessage(), "Student Registeration was Success");

                return true;
            }
        }

        public class EMailUtil
        {
            public static void SendEmail(MailMessage mailMessage, string subject)
            { 
            
            }
        }

        public class StudentDAL
        {
            public StudentDAL()
            {
                
            }

            public int SaveStudent(StudentBO studentBO)
            {
                return 1;
            }
        }
    }


    public class SRPNotAppliedClass
    {
        public class StudentBusinessAccess
        {
            public StudentBusinessAccess()
            {

            }

            /// <summary>
            /// This Method for example alone not for execute. To understand the concept.
            /// </summary>
            /// <param name="studentBO"></param>
            /// <returns></returns>
            public bool SaveStudentDetails(StudentBO studentBO)
            {
                // Collect and Map Student Informations IF EF

                StudentEntity studentEntity = new StudentEntity();
                studentEntity.Name = studentBO.Name;

                StudentContext ctx = new StudentContext();
                ctx.StudentEntity.Add(studentEntity);
                ctx.SaveChanges();


                // Save the Details to Database
                // Wirte Insert Query to Save Data to DB. IF ADO.NET
                string query = "Insert student Details query";
                SqlCommand command = new SqlCommand(query);

                // Send Email to Admin and Student for the Register Success
                // Send Email to Admin if Register Failed
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Send(mailMessage);

                return true;

            }
        }
    }

    internal class StudentContext
    {
        public StudentContext()
        {
        }

        public object StudentEntity { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }


    public class StudentBO
    {
        public string Name { get; set; }
    }
    public class StudentEntity
    {
        public string Name { get; set; }
    }
}
