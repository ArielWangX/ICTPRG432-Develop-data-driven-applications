using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.SubjectPL
{
    public class UpdateSubject : PLBase
    {
        public override void Run()
        {
            var subject = new Subject();

            Console.WriteLine("Update a subject");
            Console.WriteLine("Enter ID: ");
            subject.Id = Console.ReadLine();
            Console.WriteLine("Enter title: ");
            subject.Title = Console.ReadLine();
            Console.WriteLine("Enter number of session: ");
            subject.NumberofSession = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hour per session: ");
            subject.HourPerSession = Convert.ToInt32(Console.ReadLine());

            var subjectBLL = new SubjectBLL();
            var result = subjectBLL.Update(subject);

            if (result == false)
            {
                Console.WriteLine("Update subject unsuccessful");
            }
            else 
            {
                Console.WriteLine("Update subject successful");
            }
        }
    }
}
