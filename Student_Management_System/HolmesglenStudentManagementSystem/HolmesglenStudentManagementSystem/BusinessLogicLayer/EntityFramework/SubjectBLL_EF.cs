using HolmesglenStudentManagementSystem.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer.EntityFramework
{
    // use build-in data access layer interface
    public class SubjectBLL_EF
    {
        private APPDBContext db;

        public SubjectBLL_EF(APPDBContext appDBContext)
        {
            this.db = appDBContext;
        }

        // create a subject
        public bool Create(Subject_EF subject)
        {
            try
            {
                db.Subject.Find(subject.SubjectID);
            }
            catch (SQLiteException ex)
            { 
                Console.WriteLine(ex.Message);
            }

            if (db.Subject.Find(subject.SubjectID) == null)
            {
                db.Subject.Add(subject);
                db.SaveChanges();
                return true;
            }
            return false;

        }

        // read one by subject id
        public Subject_EF Read(string id)
        { 
            Subject_EF subject = db.Subject.Find(id);

            return subject;
        }

        // read all
        public List<Subject_EF> ReadAll()
        {
            var subjects = db.Subject.ToList();

            return subjects;
        }

        // update a subject
        public bool Update(Subject_EF subject)
        {
            var updateSubject = db.Subject.Find(subject.SubjectID);
            if (updateSubject == null)
            {
                return false;
            }
            updateSubject.Title = subject.Title;
            updateSubject.NumberofSession = subject.NumberofSession;
            updateSubject.HourPerSession = subject.HourPerSession;

            db.SaveChanges();
            return true;
        }

        // delete a subject
        public bool Delete(string id)
        { 
            var deleteSubject = db.Subject.Find(id);
            if(deleteSubject == null)
            {
                return false;
            }
            db.Subject.Remove(deleteSubject);

            db.SaveChanges();
            return true;
        }
    }
}
