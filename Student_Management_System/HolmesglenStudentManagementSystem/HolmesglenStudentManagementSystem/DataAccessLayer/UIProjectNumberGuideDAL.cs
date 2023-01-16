using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    public class UIProjectNumberGuideDAL
    {
        public List<UIProjectNumberGuide> UIProjectNumberGuide;

        public UIProjectNumberGuideDAL()
        {
            UIProjectNumberGuide = new List<UIProjectNumberGuide>();            
        }

        // exist UI project number guide
        public List<UIProjectNumberGuide> SystemNumberGuides()
        {
            var existSystemNumberGuide = new List<UIProjectNumberGuide>() {
                new UIProjectNumberGuide() { Project = "Student Create", EnterNumber = "st1"},
                new UIProjectNumberGuide() { Project = "Student Get One", EnterNumber = "st2"},
                new UIProjectNumberGuide() { Project = "Student Get All", EnterNumber = "st3"},
                new UIProjectNumberGuide() { Project = "Student Update", EnterNumber = "st4"},
                new UIProjectNumberGuide() { Project = "Student Delete", EnterNumber = "st5"},

                new UIProjectNumberGuide() { Project = "Subject Create", EnterNumber = "su1"},
                new UIProjectNumberGuide() { Project = "Subject Get One", EnterNumber = "su2"},
                new UIProjectNumberGuide() { Project = "Subject Get All", EnterNumber = "su3"},
                new UIProjectNumberGuide() { Project = "Subject Update", EnterNumber = "su4"},
                new UIProjectNumberGuide() { Project = "Subject Delete", EnterNumber = "su5"},

                new UIProjectNumberGuide() { Project = "Enrollment Create", EnterNumber = "en1"},
                new UIProjectNumberGuide() { Project = "Enrollment Get One", EnterNumber = "en2"},
                new UIProjectNumberGuide() { Project = "Enrollment Get All", EnterNumber = "en3"},
                new UIProjectNumberGuide() { Project = "Enrollment Update", EnterNumber = "en4"},
                new UIProjectNumberGuide() { Project = "Enrollment Delete", EnterNumber = "en5"},

                new UIProjectNumberGuide() { Project = "Enrollment Information Report", EnterNumber = "re1"},

                new UIProjectNumberGuide() { Project = "Student Enrollment Notification Email", EnterNumber = "no1"},

                new UIProjectNumberGuide() { Project = "Import Student CSV to Database ", EnterNumber = "imcsv1"},
                new UIProjectNumberGuide() { Project = "Export Student Data to CSV File", EnterNumber = "excsv1"},
                new UIProjectNumberGuide() { Project = "Exit System", EnterNumber = "exit"},
            };

            UIProjectNumberGuide.AddRange(existSystemNumberGuide);

            return UIProjectNumberGuide;
        }      
    }
}
