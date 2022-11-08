using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    // subject data class
    public class Subject
    {
        public string Id;
        public string Title;
        public int NumberofSession;
        public int HourPerSession;

        public Subject()
        {
            Id = "";
            Title = "";
            NumberofSession = 0;
            HourPerSession = 0;
        }

        public Subject(string id, string title, int numberofSession, int hourPerSession)
        {
            Id = id;
            Title = title;
            NumberofSession = numberofSession;
            HourPerSession = hourPerSession;
        }
    }
}
