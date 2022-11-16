using HolmesglenStudentManagementSystem.PresentationLayer;
using HolmesglenStudentManagementSystem.DataAccessLayer;
using System;
using HolmesglenStudentManagementSystem.PresentationLayer.StudentPL;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentPL;
using HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentReportPL;
using HolmesglenStudentManagementSystem.PresentationLayer.StudentEnrollmentEmailPL;
using System.IO;
using CsvHelper;
using System.Globalization;
using HolmesglenStudentManagementSystem.PresentationLayer.ImportStudentFromCSVPL;
using HolmesglenStudentManagementSystem.PresentationLayer.ExportStudentToCSVPL;

namespace HolmesglenStudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exportStudentToCSVPL = new ExportStudentToCSVPL();
            exportStudentToCSVPL.Run();


         //   var importStudentFromCSVPL = new ImportStudentFromCSVPL();
         //  importStudentFromCSVPL.Run();

            //   var studentEnrollmentEmailPL = new StudentEnrollmentEmailPL();
            //   studentEnrollmentEmailPL.Run();

            /*           
                       var getAllEnrollmentReport = new GetAllEnrollmentReport();
                       getAllEnrollmentReport.Run();

                       var getAllEnrollment = new GetAllEnrollments();
                       getAllEnrollment.Run();

                       var getAllStudents = new GetAllStudents();
                       getAllStudents.Run();

                       var getOneEnrollment = new GetOneEnrollment();
                       getOneEnrollment.Run();
           */

            //    (new GetAllStudents()).Run();
            // uncomment the code below for testing
            //(new GetOneStudent()).Run();
            //(new CreateStudent()).Run();
            //(new UpdateStudent()).Run();
            //(new DeleteStudent()).Run();

            /*
               AppDAL appDAL = new AppDAL();
               Student createStudent1 = new Student("St00020", "Tim","Tom","dsfds@dsgfd");
                
               StudentBLL studentBLL = new StudentBLL();
            var result = studentBLL.Create(createStudent1);
            Console.WriteLine(result);
            */

            //     appDAL.StudentDALInstance.Create(createStudent1);
            /*
              var studentList = appDAL.StudentDALInstance.ReadAll();

                 foreach (var item in studentList)
                 {
                     Console.WriteLine(item.FirstName + item.LastName);
                 }
             */

            /*
            AppDAL appDAL = new AppDAL();
            appDAL.StudentDALInstance.Delete("St0007");
            */
        }

    }
}
