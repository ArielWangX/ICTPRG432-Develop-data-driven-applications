using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.StudentPL
{
    public class GetOneStudent : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting a student");
            Console.Write("Student ID: ");
            var id = Console.ReadLine();

            var studentBLL = new StudentBLL();
            var student = studentBLL.GetOne(id);
            if(student == null)
            {
                Console.WriteLine($"Student({id}) does not exist");
            }
            else
            {
                // create table and table heading
                var table = new ConsoleTable("StudentID", "FirstName", "LastName", "Email");

                // add table content
                table.AddRow(student.Id, student.FirstName, student.LastName, student.Email);

                // present table
                Console.WriteLine(table);
            }
            
        }
    }
}
