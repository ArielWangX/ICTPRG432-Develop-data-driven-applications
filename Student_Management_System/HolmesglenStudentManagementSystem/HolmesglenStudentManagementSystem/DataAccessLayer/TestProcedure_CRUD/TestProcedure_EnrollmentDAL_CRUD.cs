using ConsoleTables;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer.TestProcedure_CRUD
{
    public class TestProcedure_EnrollmentDAL_CRUD
    {
        AppDAL appDAL;

        public TestProcedure_EnrollmentDAL_CRUD()
        {
            appDAL = new AppDAL();
        }

        // will create EnrollmentDAL object in each method.
        // It will be easy to apply screenshot each method code completely
        // for accessment requirement.


        // Test EnrollmentDAL: create an enrollment
        public void TestEnrollmentDAL_Create()
        {
            var enrollmentDALInstance = new EnrollmentDAL(appDAL.Connection);
            var newEnrollment = new Enrollment(6, "St0002", "Su0001");
            enrollmentDALInstance.Create(newEnrollment);
        }

        // Test EnrollmentDAL: get one enrollment
        public void TestEnrollmentDAL_GetOne()
        {
            var enrollmentDALInstance = new EnrollmentDAL(appDAL.Connection);
            var studentID = "St0003";
            var subjectID = "Su0001";
            var enrollment = enrollmentDALInstance.Read(studentID, subjectID);

            // create table and table heading
            var table = new ConsoleTable("EnrollmentID", "StudentID_FK", "SubjectID_FK");

            // add table content
            table.AddRow(enrollment.Id, enrollment.StudentIDFK, enrollment.SubjectIDFK);

            // present table
            Console.WriteLine(table);
        }

        // Test EnrollmentDAL: get all enrollment
        public void TestEnrollmentDAL_GetAll()
        {
            var enrollmentDALInstance = new EnrollmentDAL(appDAL.Connection);
            var enrollments = enrollmentDALInstance.ReadALL();

            // create table and table heading
            var table = new ConsoleTable("EnrollmentID", "StudentID_FK", "SubjectID_FK");

            // add table content
            foreach (var item in enrollments)
            {
                table.AddRow(item.Id, item.StudentIDFK, item.SubjectIDFK);
            }

            // present table
            Console.WriteLine(table);
        }

        // Test EnrollmentDAL: update an enrollment
        public void TestEnrollmentDAL_Update()
        {
            var enrollmentDALInstance = new EnrollmentDAL(appDAL.Connection);

            // use current student id and subject id in enrollment table to find the enrollment id
            var existEnrollment = new Enrollment(null, "St0002", "Su0001");

            // update enrollment under found enrollment id
            // keep the student id
            // update this enrollment subject id 
            var keepStudentID = "St0002";
            var updateSubjectID = "Su0003";

            enrollmentDALInstance.Update(existEnrollment, keepStudentID, updateSubjectID);
        }

        // Test EnrollmentDAL: delete an enrollment
        public void TestEnrollmentDAL_Delete()
        {
            var enrollmentDALInstance = new EnrollmentDAL(appDAL.Connection);
            var studentID = "St0002";
            var subjectID = "Su0003";
            enrollmentDALInstance.Delete(studentID, subjectID);
        }
    }
}
