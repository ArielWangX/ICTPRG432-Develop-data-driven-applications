﻿using HolmesglenStudentManagementSystem.PresentationLayer;
using HolmesglenStudentManagementSystem.DataAccessLayer;
using System;
using HolmesglenStudentManagementSystem.PresentationLayer.StudentPL;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using HolmesglenStudentManagementSystem.PresentationLayer.EnrollmentPL;

namespace HolmesglenStudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var updateEnrollment = new UpdateEnrollment();
            updateEnrollment.Run();


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