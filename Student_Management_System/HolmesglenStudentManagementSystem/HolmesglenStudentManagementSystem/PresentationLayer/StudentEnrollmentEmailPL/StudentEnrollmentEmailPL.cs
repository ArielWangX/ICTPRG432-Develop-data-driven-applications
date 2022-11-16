using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.StudentEnrollmentEmailPL
{
    public class StudentEnrollmentEmailPL : PLBase
    {
        public override void Run()
        {
            // get student id
            Console.WriteLine("Getting student enrollment email");
            Console.WriteLine("Enter the student ID ");
            var studentID = Console.ReadLine();

            var studentEnrollmentEmailBLL = new StudentEnrollmentEmailBLL();
            var result = studentEnrollmentEmailBLL.GetStudentEnrollmentEmail(studentID);

            if (result.Count == 0)
            {
                Console.WriteLine("This student id does not exist.");
            }
            else
            {
                var studentName = "";
                var studentEmail = "";
                var subjectTitle_Id = "";

                foreach (var item in result)
                {
                    // get student name and email
                    studentName = item.StudentName;
                    studentEmail = item.StudentEmail;

                    // get subject title and subject id
                    subjectTitle_Id += $"> {item.SubjectTitle} ({item.SubjectID}) \n";
                }

                var emailTemplate = new EmailTemplate();
                var studentEnrollmentEmail = emailTemplate.GetEmailTemplate(studentEmail, studentName, subjectTitle_Id);

                Console.WriteLine(studentEnrollmentEmail);
            }
            
        }
    }
}
