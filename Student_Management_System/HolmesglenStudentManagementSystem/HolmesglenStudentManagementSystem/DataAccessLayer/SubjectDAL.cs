using Microsoft.Data.Sqlite;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    // Data access logic for subject table
    public class SubjectDAL
    {        
        private SqliteConnection Connection;

        public SubjectDAL(SqliteConnection connection)
        {
            // connect to the target database
            Connection = connection;
        }
        // create
        public void Create(Subject subject)
        {
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Subject
                (SubjectID, Title, NumberOfSession, HourPerSession)
                VALUES(@a, @b, @c, @d)
            ";

            command.Parameters.AddWithValue("a", subject.Id);
            command.Parameters.AddWithValue("b", subject.Title);
            command.Parameters.AddWithValue("c", subject.NumberofSession);
            command.Parameters.AddWithValue("d", subject.HourPerSession);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        // read
        public Subject Read(string id)
        {
            Subject subject = null;
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT SubjectID, Title, NumberOfSession, HourPerSession
                FROM Subject
                WHERE SubjectID = @a
            ";
            command.Parameters.AddWithValue("a", id);

            // execute the query
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var subjectId = reader.GetString(0);
                var title = reader.GetString(1);
                var numberofSession = reader.GetInt32(2);
                var hourPerSession = reader.GetInt32(3);
                subject = new Subject(subjectId, title, numberofSession, hourPerSession);
            }// else subject = null

            Connection.Close();

            return subject;
        }

        // read all
        public List<Subject> ReadAll()
        {
            var subjects = new List<Subject>();

            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT SubjectID, Title, NumberOfSession, HourPerSession
                FROM Subject
            ";

            // execute the query
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var subjectId = reader.GetString(0);
                var title = reader.GetString(1);
                var numberofSession = reader.GetInt32(2);
                var hourPerSession = reader.GetInt32(3);
                subjects.Add(new Subject(subjectId, title, numberofSession, hourPerSession));
            }

            Connection.Close();
            return subjects;
        }

        // update
        public void Update(Subject subject)
        {
            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                UPDATE Subject
                SET Title = @a,
                    NumberOfSession = @b,
                    HourPerSession = @c
                WHERE SubjectID = @d
            ";
            command.Parameters.AddWithValue("a", subject.Title);
            command.Parameters.AddWithValue("b", subject.NumberofSession);
            command.Parameters.AddWithValue("c", subject.HourPerSession);
            command.Parameters.AddWithValue("d", subject.Id);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        // delete
        public void Delete(string id)
        {
            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                DELETE FROM Subject
                WHERE SubjectID = @a
            ";
            command.Parameters.AddWithValue("a", id);

            // execute the query 
            command.ExecuteReader();

            Connection.Close();
        }
    }
}
