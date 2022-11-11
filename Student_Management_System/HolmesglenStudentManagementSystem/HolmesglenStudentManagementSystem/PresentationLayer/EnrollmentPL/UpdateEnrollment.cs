using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentPL
{
    public class UpdateEnrollment : PLBase
    {
        public override void Run()
        {
            var enrollment = new Enrollment();
            Console.WriteLine("Updating a new enrollment");
            Console.Write("Enter student ID: ");
            enrollment.StudentIDFK = Console.ReadLine();
            Console.Write("Enter subject ID: ");
            enrollment.SubjectIDFK = Console.ReadLine();
            

            var enrollmentBLL = new EnrollmentBLL();
            var result = enrollmentBLL.Update(enrollment);

            if (result == false)
            {
                Console.WriteLine($"Update enrollment unsuccessful");
            }
            else
            {
                Console.WriteLine($"Update enrollment successful");
            }
        }
    }
}
