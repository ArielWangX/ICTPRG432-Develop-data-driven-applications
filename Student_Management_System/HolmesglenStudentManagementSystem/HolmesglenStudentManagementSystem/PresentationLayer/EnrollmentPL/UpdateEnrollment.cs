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

            // enter old student id and subject id to find the target enrollment id
            Console.WriteLine("First, enter the old student ID: ");
            enrollment.StudentIDFK = Console.ReadLine();
            Console.Write("Enter old subject ID: ");
            enrollment.SubjectIDFK = Console.ReadLine();

            Console.Write("Enter updated student ID: ");
            var updateStudentIDFK = Console.ReadLine();
            Console.Write("Enter updated subject ID: ");
            var updateSubjectIDFK = Console.ReadLine();
            

            var enrollmentBLL = new EnrollmentBLL();
            var result = enrollmentBLL.Update(enrollment, updateStudentIDFK, updateSubjectIDFK);

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
