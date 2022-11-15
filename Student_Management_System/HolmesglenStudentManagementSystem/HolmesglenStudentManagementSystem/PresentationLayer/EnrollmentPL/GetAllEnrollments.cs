using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentPL
{
    public class GetAllEnrollments :PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting all enrollments");

            var enrollmentBLL = new EnrollmentBLL();
            var result = enrollmentBLL.GetAll();
            if (result.Count == 0)
            {
                Console.WriteLine("table is empty");
            }
            else
            {
                // create table and table heading
                var table = new ConsoleTable("EnrollmentID", "StudentID_FK", "SubjectID_FK");

                // add table content
                foreach (var item in result)
                {
                    table.AddRow(item.Id, item.StudentIDFK, item.SubjectIDFK);
                }

                // present table
                Console.WriteLine(table);  
            }
        }
    }
}
