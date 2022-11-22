using ConsoleTables;
using HolmesglenStudentManagementSystem.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer.EntityFramework
{
    public class TestProcedure_EntityFramework_Subject
    {
        private APPDBContext db;

        public TestProcedure_EntityFramework_Subject()
        {
            this.db = new APPDBContext();
        }

        // will create SubjectBLL_EF object in each method.
        // It will be easy to apply screenshot each method code completely
        // for accessment requirement.

        // Test SubjectBLL_EF: create a subject
        public void TestSubjectBLL_EF_Create()
        {
            var subjectBLL_EFInstance = new SubjectBLL_EF(db);
            var newSubject = new Subject_EF() { SubjectID = "Su0004", Title = "Web Development", NumberofSession = 9, HourPerSession = 6 };
            subjectBLL_EFInstance.Create(newSubject);
        }

        // Test SubjectBLL_EF: get one subject
        public void TestSubjectBLL_EF_GetOne()
        {
            var subjectBLL_EFInstance = new SubjectBLL_EF(db);
            var subjectID = "Su0002";
            var subject = subjectBLL_EFInstance.Read(subjectID);

            // create table and table heading
            var table = new ConsoleTable("SubjectID", "Title", "NumberofSession", "HourPerSession");

            // add table content
            table.AddRow(subject.SubjectID, subject.Title, subject.NumberofSession, subject.HourPerSession);

            // present table
            Console.WriteLine(table);
        }

        // Test SubjectBLL_EF: get all subject
        public void TestSubjectBLL_EF_GetAll()
        {
            var subjectBLL_EFInstance = new SubjectBLL_EF(db);
            var subjects = subjectBLL_EFInstance.ReadAll();

            // create table and table heading
            var table = new ConsoleTable("SubjectID", "Title", "NumberofSession", "HourPerSession");


            foreach (var subject in subjects)
            {
                // add table content
                table.AddRow(subject.SubjectID, subject.Title, subject.NumberofSession, subject.HourPerSession);
            }

            // present table
            Console.WriteLine(table);

        }

        // Test SubjectBLL_EF: update a subject
        public void TestSubjectBLL_EF_Update()
        {
            var subjectBLL_EFInstance = new SubjectBLL_EF(db);

            // update subject title
            var updateSubject = new Subject_EF() { SubjectID = "Su0004", Title = "SQL Database", NumberofSession = 9, HourPerSession = 6 };
            subjectBLL_EFInstance.Update(updateSubject);
        }

        // Test SubjectBLL_EF: delete a subject
        public void TestSubjectBLL_EF_Delete()
        {
            var subjectBLL_EFInstance = new SubjectBLL_EF(db);
            var subjectID = "Su0004";
            subjectBLL_EFInstance.Delete(subjectID);
        }
    }
}
