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

namespace HolmesglenStudentManagementSystem.PresentationLayer.ExportStudentToCSVPL
{
    public class ExportStudentToCSVPL : PLBase
    {
        // export data into csv file
        public override void Run()
        {
            // get student data list from database
            var studentBLL = new StudentBLL();
            var studentList = studentBLL.GetAll();

            // apply csv format to student data 
            var exportStudentToCSV = new List<CSVFormat_Student>();
            foreach (var student in studentList)
            {
                exportStudentToCSV.Add(new CSVFormat_Student(student.Id, student.FirstName, student.LastName, student.Email));
            }

            // export formatted student data to csv file
            using (var streamWriter = new StreamWriter(@"E:\Programming\ICTPRG432 Develop data-driven applications\AT2\Student_ExportToCSV.csv"))
            using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
            {           
                // create header in csv file
                csvWriter.WriteHeader<CSVFormat_Student>();
                csvWriter.NextRecord();

                // add row content in csv file
                foreach (var student in exportStudentToCSV)
                {
                    csvWriter.WriteRecord<CSVFormat_Student>(student);
                    csvWriter.NextRecord();
                }
            }

            Console.WriteLine("Export student table into csv file successful.");
        }
    }
}
