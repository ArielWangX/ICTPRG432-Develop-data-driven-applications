using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models.EntityFramework
{
    // apply Entity Framework - code first pattern
    public class Subject_EF
    {
        [Key]
        public string SubjectID { get; set; }

        public string Title { get; set; }
        public int NumberofSession { get; set; }
        public int HourPerSession { get; set; }
    }
}
