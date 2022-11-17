using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.UIPrpjectNumberGuide
{
    public class UIProjectNumberGuidePL : PLBase
    {
        // create project number guide table 
        public override void Run()
        {
            Console.WriteLine("Choose your project:");
            Console.WriteLine("Enter the number by following the project number in the table below");

            var uiProjectNumberGuide = new UIProjectNumberGuideBLL();
            var result = uiProjectNumberGuide.GetAllUIProjectNumberGuide();

            // create table and table heading
            var table = new ConsoleTable("Project","Enter Number");

            // add table content
            foreach (var item in result)
            {
                table.AddRow(item.Project, item.EnterNumber);
            }

            // present table
            Console.WriteLine(table);
        }
    }
}
