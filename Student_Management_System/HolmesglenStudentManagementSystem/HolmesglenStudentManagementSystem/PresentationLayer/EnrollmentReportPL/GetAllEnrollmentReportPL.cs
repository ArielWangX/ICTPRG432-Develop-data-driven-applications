using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentReportPL
{
    public class GetAllEnrollmentReportPL : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting all enrollment report information");
            Console.WriteLine("It includes studentID, student name, subjectID, subject title");

            var enrollmentReportBLL = new EnrollmentReportBLL();
            var result = enrollmentReportBLL.GetAllEnrollmentReport();
            if (result.Count == 0)
            {
                Console.WriteLine("table is empty");
            }
            else
            {
                // create table and table heading
                var table = new ConsoleTable("Student ID", "Name", "Subject ID", "Subject Title");

                // add table content
                foreach (var item in result)
                {
                    table.AddRow(item.StudentID, item.StudentName, item.SubjectID, item.SubjectTitle);
                }

                // present table
                Console.WriteLine(table);
            }
        }
    }
}
