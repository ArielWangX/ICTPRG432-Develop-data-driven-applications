using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer.SubjectPL
{
    public class CreateSubject : PLBase
    {
        public override void Run()
        {
            var subject = new Subject();
            Console.WriteLine("Creating a new subject");
            Console.WriteLine("Enter ID: ");
            subject.Id = Console.ReadLine();
            Console.WriteLine("Enter Title: ");
            subject.Title = Console.ReadLine();
            Console.WriteLine("Enter Number of Session: ");
            subject.NumberofSession = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hour per Session: ");
            subject.HourPerSession = Convert.ToInt32(Console.ReadLine());

            var subjectBLL = new SubjectBLL();
            var result = subjectBLL.Create(subject);

            if (result == false)
            {
                Console.WriteLine("Create new subject unsuccessful");
            }
            else 
            {
                Console.WriteLine("Create new subject successful");
            }
        }
    }
}
