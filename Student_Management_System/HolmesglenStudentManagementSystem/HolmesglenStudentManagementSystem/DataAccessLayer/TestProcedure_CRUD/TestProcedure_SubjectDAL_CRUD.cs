using ConsoleTables;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer.TestProcedure_CRUD
{
    public class TestProcedure_SubjectDAL_CRUD
    {
        AppDAL appDAL;

        public TestProcedure_SubjectDAL_CRUD()
        {
            appDAL = new AppDAL();
        }

        // will create SubjectDAL object in each method.
        // It will be easy to apply screenshot each method code completely
        // for accessment requirement.


        // Test SubjectDAL: create a subject
        public void TestSubjectDAL_Create()
        {
            var subjectDALInstance = new SubjectDAL(appDAL.Connection);
            var newSubject = new Subject("Su0004", "Web Development", 9, 6);
            subjectDALInstance.Create(newSubject);
        }

        // Test SubjectDAL: get one subject
        public void TestSubjectDAL_GetOne()
        {
            var subjectDALInstance = new SubjectDAL(appDAL.Connection);
            var subjectID = "Su0003";
            var subject = subjectDALInstance.Read(subjectID);

            // create table and table heading
            var table = new ConsoleTable("SubjectID", "Title", "NumberofSession", "HourPerSession");

            // add table content
            table.AddRow(subject.Id, subject.Title, subject.NumberofSession, subject.HourPerSession);

            // present table
            Console.WriteLine(table);
        }

        // Test SubjectDAL: get all subject
        public void TestSubjectDAL_GetAll()
        {
            var subjectDALInstance = new SubjectDAL(appDAL.Connection);
            var subjects = subjectDALInstance.ReadAll();

            // create table and table heading
            var table = new ConsoleTable("SubjectID", "Title", "NumberofSession", "HourPerSession");

            foreach (var subject in subjects)
            {
                // add table content
                table.AddRow(subject.Id, subject.Title, subject.NumberofSession, subject.HourPerSession);
            }
            
            // present table
            Console.WriteLine(table);
        }

        // Test SubjectDAL: update a subject
        public void TestSubjectDAL_Update()
        {
            var subjectDALInstance = new SubjectDAL(appDAL.Connection);

            // update subject title
            var updateSubject = new Subject("Su0004", "SQL Database", 9, 6); 
            subjectDALInstance.Update(updateSubject);
        }

        // Test SubjectDAL: delete a subject
        public void TestSubjectDAL_Delete()
        {
            var subjectDALInstance = new SubjectDAL(appDAL.Connection);
            var subjectID = "Su0004";
            subjectDALInstance.Delete(subjectID);
        }

    }
}
