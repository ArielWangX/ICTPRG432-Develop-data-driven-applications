using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models.EntityFramework
{
    // apply Entity Framework - code first pattern  
    public class Enrollment_EF
    {
        [Key]
        public int EnrollmentID { get; set; }

        public string StudentID_FK { get; set; }
        public string SubjectID_FK { get; set; }
    }
}
