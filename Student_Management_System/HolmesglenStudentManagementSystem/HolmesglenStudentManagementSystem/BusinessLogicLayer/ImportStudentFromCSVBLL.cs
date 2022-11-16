using HolmesglenStudentManagementSystem.DataAccessLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class ImportStudentFromCSVBLL
    {
        AppDAL appDAL;
        public ImportStudentFromCSVBLL()
        {
            appDAL = new AppDAL();
        }

        public List<Student> ImportStudentToSQLite(List<Student> studentImport)
        {
            var studentBLL = new StudentBLL();
            var studentExistList = new List<Student>();

            foreach (var student in studentImport)
            {
                // if student id exists, add to studentExistList and skip to next iteration.
                if (studentBLL.GetOne(student.Id) != null)
                {
                    studentExistList.Add(student);
                    continue;                   
                }
                // if student id does not exist, create one row in sqlite student table.
                else
                {
                    appDAL.StudentDALInstance.Create(student);
                }               
            }

            // return studenExistList
            return studentExistList;
        }

    } 
}