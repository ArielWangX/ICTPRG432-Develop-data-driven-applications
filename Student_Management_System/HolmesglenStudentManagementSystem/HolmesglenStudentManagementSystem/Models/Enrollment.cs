using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    // enrollment data class
    public class Enrollment
    {
        public int? Id;
        public string StudentIDFK;
        public string SubjectIDFK;

        public Enrollment()
        {
            Id = null;
            StudentIDFK = "";
            SubjectIDFK = "";
        }

        public Enrollment(int? id, string studentIDFK, string subjectIDFK)
        {
            Id = id;
            StudentIDFK = studentIDFK;
            SubjectIDFK = subjectIDFK;
        }
    }
}
