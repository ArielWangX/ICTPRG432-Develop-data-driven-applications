using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentPL
{
    public class GetOneEnrollment : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting an enrollment");
            Console.Write("Enter student ID: ");
            var studentID = Console.ReadLine();
            Console.Write("Enter subject ID: ");
            var subjectID = Console.ReadLine();

            var enrollmentBLL = new EnrollmentBLL();
            var enrollment = enrollmentBLL.GetOne(studentID, subjectID);
            if (enrollment == null)
            {
                Console.WriteLine($"Enrollment({studentID}\t{subjectID}) does not exist");
            }
            else
            {
                Console.WriteLine($"{enrollment.Id}\t{enrollment.StudentIDFK}\t{enrollment.SubjectIDFK}");
            }

        }
    }
}
