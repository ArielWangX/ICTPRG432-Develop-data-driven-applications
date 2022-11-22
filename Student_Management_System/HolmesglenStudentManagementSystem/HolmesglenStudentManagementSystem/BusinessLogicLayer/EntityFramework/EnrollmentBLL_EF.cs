using HolmesglenStudentManagementSystem.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer.EntityFramework
{
    // use build-in data access layer interface
    public class EnrollmentBLL_EF
    {
        private APPDBContext db;

        public EnrollmentBLL_EF(APPDBContext appDBContext)
        {
            this.db = appDBContext;
        }

        // method: create an enrollment
        // method: read one by student id and subject id
        // method: read all
        // method: update an enrollment
        // method: delete an enrollment
    }
}
