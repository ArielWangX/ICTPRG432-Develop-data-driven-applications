using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.StudentPL
{
    public class GetAllStudents : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting all students");

            var studentBLL = new StudentBLL();
            var result = studentBLL.GetAll();
            if (result.Count == 0)
            {
                Console.WriteLine("table is empty");
            }
            else
            {
                // create table and table heading
                var table = new ConsoleTable("StudentID", "FirstName", "LastName", "Email");

                // add table content
                foreach (var item in result)
                {
                    table.AddRow(item.Id, item.FirstName, item.LastName, item.Email);
                }

                // present table
                Console.WriteLine(table);               
            }
        }
    }
}
