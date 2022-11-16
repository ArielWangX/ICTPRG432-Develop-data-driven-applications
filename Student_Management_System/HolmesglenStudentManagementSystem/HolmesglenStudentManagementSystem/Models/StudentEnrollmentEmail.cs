using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class StudentEnrollmentEmail
    {
        public string StudentName;
        public string StudentEmail;
        public string SubjectID;
        public string SubjectTitle;

        public StudentEnrollmentEmail()
        {
            StudentName = "";
            StudentEmail = "";
            SubjectID = "";
            SubjectTitle = "";
        }

        public StudentEnrollmentEmail(string studentName, string studentEmail, string subjectID, string subjectTitle)
        {
            StudentName = studentName;
            StudentEmail = studentEmail;
            SubjectID = subjectID;
            SubjectTitle = subjectTitle;
        }
    }
}
