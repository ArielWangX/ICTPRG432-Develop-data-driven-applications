using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class UIProjectNumberGuide
    {
        public string Project;
        public string EnterNumber;

        public UIProjectNumberGuide()
        {
            Project = "";
            EnterNumber = "";
        }
        public UIProjectNumberGuide(string project, string enterNumber)
        {
            Project = project;
            EnterNumber = enterNumber;
        }
    }
}
