using HolmesglenStudentManagementSystem.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer.EntityFramework
{
    // use build-in data access layer interface
    public class StudentBLL_EF
    {
        private APPDBContext db;

        public StudentBLL_EF(APPDBContext appDBContext)
        {
            this.db = appDBContext;
        }

        // method: create a student
        // method: read one by Id
        // method: read all
        // method: update a student
        // method: delete a student
    }
}
