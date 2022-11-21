using HolmesglenStudentManagementSystem.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer.DALDisconnected
{
    // apply disconnected database connectivity
    public class DALDisconnected
    {
        // apply connection with database
        private SQLiteConnection Connection;

        // apply DataAdapter
        private SQLiteDataAdapter DataAdapter;

        // apply DataSet
        private DataSet DBDataSet;

        // query string is used to define a subset of the whole database.
        // in this project, the whole database with three tables are selected.
        private string DBQueryString = @"
            SELECT StudentID, FirstName, LastName, Email
            FROM Student;

            SELECT SubjectID, Title
            FROM Subject;

            SELECT EnrollmentID, StudentID_FK, SubjectID_FK
            FROM Enrollment
        ";

        public DALDisconnected(string connectionString)
        {
            // create a new connection
            Connection = new SQLiteConnection(connectionString);

            // create the data adapter
            DataAdapter = new SQLiteDataAdapter(DBQueryString, Connection);

            // populate the Dataset
            DBDataSet = new DataSet();
            DataAdapter.Fill(DBDataSet);

            // give each table a name to access them
            DBDataSet.Tables[0].TableName = "Student";
            DBDataSet.Tables[1].TableName = "Subject";
            DBDataSet.Tables[2].TableName = "Enrollment";
        }

        // read all - with disconnected database connectivity
        public List<Student> StudentReadAll()
        {
            var students = new List<Student>();

            foreach (DataRow row in DBDataSet.Tables["Student"].Rows)
            {
                var id = row["StudentID"].ToString();
                var firstName = row["FirstName"].ToString();
                var lastName = row["LastName"].ToString();
                var email = row["Email"].ToString();
                students.Add(new Student(id, firstName, lastName, email));
            }
            return students;
        }
    }
}
