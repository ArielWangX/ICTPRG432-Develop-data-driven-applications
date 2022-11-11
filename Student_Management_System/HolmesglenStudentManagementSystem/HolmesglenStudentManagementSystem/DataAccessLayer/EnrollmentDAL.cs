using Microsoft.Data.Sqlite;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    // Data access logic for Enrollment table
    public class EnrollmentDAL
    {
        private SqliteConnection Connection;

        public EnrollmentDAL(SqliteConnection connection)
        {
            // connect to the target database
            Connection = connection;
        }

        // Create
        public void Create(Enrollment enrollment)
        { 
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Enrollment
                (EnrollmentID, StudentID_FK, SubjectID_FK)
                VALUES(@a, @b, @c)
            ";
            command.Parameters.AddWithValue("a", enrollment.Id);
            command.Parameters.AddWithValue("b", enrollment.StudentIDFK);
            command.Parameters.AddWithValue("c", enrollment.SubjectIDFK);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        // Read
        public Enrollment Read(string studentIDFK, string subjectIDFK)
        {
            Enrollment enrollment = null;
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT EnrollmentID, StudentID_FK, SubjectID_FK
                FROM Enrollment
                WHERE StudentID_FK = @a AND SubjectID_FK = @b
            ";
            command.Parameters.AddWithValue("a", studentIDFK);
            command.Parameters.AddWithValue("b", subjectIDFK);

            // execute the query
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var enrollmentID = reader.GetInt32(0);
                var studentID_FK = reader.GetString(1);
                var subjectID_FK = reader.GetString(2);
                enrollment = new Enrollment(enrollmentID, studentID_FK, subjectID_FK);
            } // else student = null

            Connection.Close();

            return enrollment;
        }

        // read all
        public List<Enrollment> ReadALL()
        {
            var enrollments = new List<Enrollment>();

            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT EnrollmentID, StudentID_FK, SubjectID_FK
                FROM Enrollment        
            ";

            // execute the query
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var enrollmentID = reader.GetInt32(0);
                var studentID_FK = reader.GetString(1);
                var subjectID_FK = reader.GetString(2);
                enrollments.Add(new Enrollment(enrollmentID, studentID_FK, subjectID_FK));
            }

            Connection.Close();
            return enrollments;
        }

        // update
        public void Update(Enrollment enrollment)  // ask 
        {
            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                UPDATE Enrollment
                SET StudentID_FK = @a,
                    SubjectID_FK = @b                  
                WHERE EnrollmentID = @c
            ";
            command.Parameters.AddWithValue("a", enrollment.StudentIDFK);
            command.Parameters.AddWithValue("b", enrollment.SubjectIDFK);
            command.Parameters.AddWithValue("c", enrollment.Id);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        // delete
        public void Delete(string studentIDFK, string subjectIDFK) 
        {
            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                DELETE FROM Enrollment
                WHERE StudentID_FK = @a AND SubjectID_FK = @b
            ";
            command.Parameters.AddWithValue("a", studentIDFK);
            command.Parameters.AddWithValue("b", subjectIDFK);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

    }
}
