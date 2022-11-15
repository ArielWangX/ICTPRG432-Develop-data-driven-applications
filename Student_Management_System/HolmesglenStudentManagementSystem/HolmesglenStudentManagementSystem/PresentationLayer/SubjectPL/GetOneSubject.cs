using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.SubjectPL
{
    public class GetOneSubject : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting a subject");
            Console.WriteLine("Enter ID: ");
            var id = Console.ReadLine();

            var subjectBLL = new SubjectBLL();
            var subject = subjectBLL.GetOne(id);
            if (subject == null)
            {
                Console.WriteLine($"Subject {id} does not exist");
            }
            else
            {
                // create table and table heading
                var table = new ConsoleTable("SubjectID", "Title", "NumberofSession", "HourPerSession");

                // add table content
                table.AddRow(subject.Id, subject.Title, subject.NumberofSession, subject.HourPerSession);

                // present table
                Console.WriteLine(table);
            }
        }
    }
}
