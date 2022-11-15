using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.SubjectPL
{
    public class GetAllSubjects : PLBase
    {
        public override void Run()
        {
            Console.WriteLine("Getting all subjects");

            var subjectBLL = new SubjectBLL();
            var result = subjectBLL.GetAll();
            if (result.Count == 0)
            {
                Console.WriteLine("Table is empty");
            }
            else
            {
                // create table and table heading
                var table = new ConsoleTable("SubjectID", "Title", "NumberofSession", "HourPerSession");

                // add table content
                foreach (var item in result)
                {
                    table.AddRow(item.Id, item.Title, item.NumberofSession, item.HourPerSession);
                }

                // present table
                Console.WriteLine(table);
            }
        }    
    }
}
