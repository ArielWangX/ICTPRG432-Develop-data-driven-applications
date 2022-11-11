using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentPL
{
    public class DeleteEnrollment : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Deleting an enrollment");
            Console.WriteLine("Enter student ID: ");
            var studentID = Console.ReadLine();
            Console.WriteLine("Enter subject ID: ");
            var subjectID = Console.ReadLine();

            var enrollmentBLL = new EnrollmentBLL();
            var result = enrollmentBLL.Delete(studentID, subjectID);

            if (result == false)
            {
                Console.WriteLine("Delete enrollment unsuccessful");
            }
            else
            {
                Console.WriteLine("Delete enrollment successful");
            }
        }
    }
}
