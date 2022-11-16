using HolmesglenStudentManagementSystem.DataAccessLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class StudentEnrollmentEmailBLL
    {
        AppDAL appDAL;
        public StudentEnrollmentEmailBLL()
        {
            appDAL = new AppDAL();
        }

        public List<StudentEnrollmentEmail> GetStudentEnrollmentEmail(string studentID)
        {
            var studentEnrollmentEmail = new List<StudentEnrollmentEmail>();
            var studentBLL = new StudentBLL();

            if (studentBLL.GetOne(studentID) == null)
            {
                // if student id does not exist, return empty list
                return studentEnrollmentEmail;
            }
            else
            {
                // if student id exist, return student enrollment information
                return appDAL.StudentEnrollmentEmailDALInstance.ReadOne(studentID);
            }                 
        }
    }
}
