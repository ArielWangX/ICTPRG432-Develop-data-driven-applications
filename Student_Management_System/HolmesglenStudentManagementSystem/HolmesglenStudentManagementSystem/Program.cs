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
using HolmesglenStudentManagementSystem.PresentationLayer.UIPrpjectNumberGuide;
using HolmesglenStudentManagementSystem.PresentationLayer.SubjectPL;
using HolmesglenStudentManagementSystem.DataAccessLayer.TestProcedure_CRUD;
using HolmesglenStudentManagementSystem.DataAccessLayer.DALDisconnected;
using ConsoleTables;
using HolmesglenStudentManagementSystem.BusinessLogicLayer.EntityFramework;

namespace HolmesglenStudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var uIPrpjectNumberGuidePL = new UIProjectNumberGuidePL();
            bool exist = false;

            // if exist is true, exist the system
            while (!exist)
            {
                Console.WriteLine("Welcome to Holmesglen student manangement system:");
                // show project-number table               
                uIPrpjectNumberGuidePL.Run();

                var userInput = Console.ReadLine();

                switch (userInput)
                {
                    // student table manangement system
                    case "st1":
                        var createStudent = new CreateStudent();
                        createStudent.Run();
                        break;
                    case "st2":
                        var getOneStudent = new GetOneStudent();
                        getOneStudent.Run();
                        break;
                    case "st3":
                        var getAllStudents = new GetAllStudents();
                        getAllStudents.Run();
                        break;
                    case "st4":
                        var updateStudent = new UpdateStudent();
                        updateStudent.Run();
                        break;
                    case "st5":
                        var deleteStudent = new DeleteStudent();
                        deleteStudent.Run();
                        break;


                    // subject table manangement system
                    case "su1":
                        var createSubject = new CreateSubject();
                        createSubject.Run();
                        break;
                    case "su2":
                        var getOneSubject = new GetOneSubject();
                        getOneSubject.Run();
                        break;
                    case "su3":
                        var getAllSubjects = new GetAllSubjects();
                        getAllSubjects.Run();
                        break;
                    case "su4":
                        var updateSubject = new UpdateSubject();
                        updateSubject.Run();
                        break;
                    case "su5":
                        var deleteSubject = new DeleteSubject();
                        deleteSubject.Run();
                        break;


                    // enrollment table manangement system
                    case "en1":
                        var createEnrollment = new CreateEnrollment();
                        createEnrollment.Run();
                        break;
                    case "en2":
                        var getOneEnrollment = new GetOneEnrollment();
                        getOneEnrollment.Run();
                        break;
                    case "en3":
                        var getAllEnrollments = new GetAllEnrollments();
                        getAllEnrollments.Run();
                        break;
                    case "en4":
                        var updateEnrollment = new UpdateEnrollment();
                        updateEnrollment.Run();
                        break;
                    case "en5":
                        var deleteEnrollment = new DeleteEnrollment();
                        deleteEnrollment.Run();
                        break;


                    // generate enrollment information report
                    case "re1":
                        var getAllEnrollmentReport = new GetAllEnrollmentReportPL();
                        getAllEnrollmentReport.Run();
                        break;


                    // generate student enrollment notification email
                    case "no1":
                        var studentEnrollmentEmailPL = new StudentEnrollmentEmailPL();
                        studentEnrollmentEmailPL.Run();
                        break;


                    // import student csv into SQLite
                    case "imcsv1":
                        var importStudentFromCSVPL = new ImportStudentFromCSVPL();
                        importStudentFromCSVPL.Run();
                        break;


                    // export student table to csv 
                    case "excsv1":
                        var exportStudentToCSVPL = new ExportStudentToCSVPL();
                        exportStudentToCSVPL.Run();
                        break;


                    // exist the system
                    case "exist":
                        exist = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Input. Try Agian.");
                        break;

                } // switch

                // press enter to continue
                Console.WriteLine();
                Console.WriteLine("Press Enter to Continue..");
                Console.ReadKey();

            } // while
        }
    }
}
