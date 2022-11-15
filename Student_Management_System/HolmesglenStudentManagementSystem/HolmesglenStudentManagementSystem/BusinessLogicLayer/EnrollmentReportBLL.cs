using HolmesglenStudentManagementSystem.DataAccessLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class EnrollmentReportBLL
    {
        AppDAL appDAL;
        public EnrollmentReportBLL()
        {
            appDAL = new AppDAL();
        }

        public List<StudentSubject> GetAllEnrollmentReport()
        {
            return appDAL.EnrollmentReportDALInstance.ReadAll();
        }
    }
}
