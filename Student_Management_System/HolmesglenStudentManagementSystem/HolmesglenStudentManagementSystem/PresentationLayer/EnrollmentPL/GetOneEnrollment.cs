using ConsoleTables;
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
                // create table and table heading
                var table = new ConsoleTable("EnrollmentID", "StudentID_FK", "SubjectID_FK");

                // add table content
                table.AddRow(enrollment.Id, enrollment.StudentIDFK, enrollment.SubjectIDFK);

                // present table
                Console.WriteLine(table);
            }

        }
    }
}
