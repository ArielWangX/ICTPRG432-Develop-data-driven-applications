using HolmesglenStudentManagementSystem.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    public class StudentEnrollmentEmailDAL
    {
        private SqliteConnection Connection;

        public StudentEnrollmentEmailDAL(SqliteConnection connection)
        {
            Connection = connection;
        }

        public List<StudentEnrollmentEmail> ReadOne(string studentID)
        { 
            var results = new List<StudentEnrollmentEmail>();

            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT FirstName || ' ' || LastName AS Name, Email, SubjectID, Title 
                FROM Enrollment
                INNER JOIN Student ON Student.StudentID = Enrollment.StudentID_FK
                INNER JOIN Subject ON Subject.SubjectID = Enrollment.SubjectID_FK
                WHERE Student.StudentID = @a
            ";
            command.Parameters.AddWithValue("a", studentID);

            // execute the query
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var studentName = reader.GetString(0);
                var studentEmail = reader.GetString(1);
                var subjectID = reader.GetString(2);
                var subjectTitle = reader.GetString(3);
                results.Add(new StudentEnrollmentEmail(studentName, studentEmail, subjectID, subjectTitle));
            }

            Connection.Close();
            return results;
        }
    }
}
