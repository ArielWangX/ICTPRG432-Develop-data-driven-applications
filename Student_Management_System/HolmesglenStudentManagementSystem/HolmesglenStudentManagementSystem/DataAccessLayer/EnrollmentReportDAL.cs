using HolmesglenStudentManagementSystem.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    public class EnrollmentReportDAL
    {
        private SqliteConnection Connection;

        public EnrollmentReportDAL(SqliteConnection connection)
        {
            // connect to the target database
            Connection = connection;
        }

        public List<StudentSubject> ReadAll()
        { 
            var results = new List<StudentSubject>();

            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT StudentID, FirstName || ' ' || LastName AS Name, SubjectID, Title               
                FROM Enrollment
                INNER JOIN Student ON Student.StudentID = Enrollment.StudentID_FK
                INNER JOIN Subject ON Subject.SubjectID = Enrollment.SubjectID_FK
            ";

            // execute the query
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var studentID = reader.GetString(0);
                var studentName = reader.GetString(1);
                var subjectID = reader.GetString(2);
                var subjectTitle = reader.GetString(3);
                results.Add(new StudentSubject(studentID, studentName, subjectID, subjectTitle));
            }

            Connection.Close();
            return results;
        }


    }
}
