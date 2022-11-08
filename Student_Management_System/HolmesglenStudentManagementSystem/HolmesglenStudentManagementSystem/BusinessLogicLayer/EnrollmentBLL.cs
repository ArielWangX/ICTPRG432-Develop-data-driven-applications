using HolmesglenStudentManagementSystem.DataAccessLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class EnrollmentBLL
    {
        AppDAL appDAL;

        public EnrollmentBLL()
        {
            appDAL = new AppDAL();
        }

        public List<Enrollment> GetAll()
        { 
            return appDAL.EnrollmentDALInstance.ReadALL();
        }

        public Enrollment GetOne(string studentIDFK, string subjectIDFK)
        {
            return appDAL.EnrollmentDALInstance.Read(studentIDFK, subjectIDFK);
        }

        public bool Create(Enrollment enrollment)
        {
            if (GetOne(enrollment.StudentIDFK, enrollment.SubjectIDFK) != null)
            {
                // if enrollment studentID_FK and subjectID_Fk exists, return false
                return false;
            }
            else 
            {
                // if enrollment studentID_FK or subjectID_Fk not exist, create it
                appDAL.EnrollmentDALInstance.Create(enrollment);
            }

            return true;
        }

        public bool Update(Enrollment enrollment)
        {
            if (GetOne(enrollment.StudentIDFK, enrollment.SubjectIDFK) == null)
            {
                // if enrollment studentID_FK or subjectID_Fk not exist, return false
                return false;
            }
            else
            {
                // if enrollment studentID_FK and subjectID_Fk exists, update it
                appDAL.EnrollmentDALInstance.Update(enrollment);
            }

            return true;
        }

        public bool Delete(string studentIDFK, string subjectIDFK)
        {
            if (GetOne(studentIDFK, subjectIDFK) == null)
            {
                //  if enrollment studentIDFK or subjectIDFK not exist, return false
                return false;
            }
            else
            {
                //  if enrollment studentIDFK and subjectIDFK exists, delete it
                appDAL.EnrollmentDALInstance.Delete(studentIDFK, subjectIDFK); 
            }

            return true;
        }


    }
}
