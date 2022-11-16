using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class ImportStudentFromCSV
    {     
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ImportStudentFromCSV() { }

        public ImportStudentFromCSV(string studentID, string firstName, string lastName, string email)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
