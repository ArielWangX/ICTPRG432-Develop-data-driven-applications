using ConsoleTables;
using CsvHelper;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.ImportStudentFromCSVPL
{
    public class ImportStudentFromCSVPL : PLBase
    {
        // import data from csv into sqlite
        public override void Run()
        {
            var studentImport = new List<Student>();

            // find and get access to the csv
            using (var reader = new StreamReader(@"E:\Programming\ICTPRG432 Develop data-driven applications\AT2\Student.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var studentImportFromCSV = csv.GetRecords<ImportStudentFromCSV>();
                foreach (var student in studentImportFromCSV)
                {
                    studentImport.Add(new Student(student.StudentID, student.FirstName, student.LastName, student.Email));
                }
            }

            // import date to sqlite
            var importStudentFromCSVBLL = new ImportStudentFromCSVBLL();
            var result = importStudentFromCSVBLL.ImportStudentToSQLite(studentImport);  
                           
            if (result.Count == 0)
            {
                // all student id does not exist, import all data into sqlite successful
                Console.WriteLine($"Import all data from new student csv file successful");
            }
            else
            {
                // some student id exist, output them as table. 
                // create table and table heading
                var table = new ConsoleTable("Student ID", "FirstName", "LastName", "Email");

                // add table content
                foreach (var item in result)
                {
                    table.AddRow(item.Id, item.FirstName, item.LastName, item.Email);
                }

                // present table
                Console.WriteLine("Some student id exist. Cannot import them into SQLite:");
                Console.WriteLine(table);
                Console.WriteLine("Other student data import successfully.");
            }

        }
    }
}
