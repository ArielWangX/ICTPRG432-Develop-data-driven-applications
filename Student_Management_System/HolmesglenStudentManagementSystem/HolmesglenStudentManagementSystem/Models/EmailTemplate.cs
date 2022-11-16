using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class EmailTemplate
    {
        public string GetEmailTemplate(string studentEmail, string studentName, string subjectTitle_Id)
        {
            var emailTemplate = $@"
Email Address: {studentEmail}

Dear {studentName},
You have been enrollment in the following subject:
{subjectTitle_Id}
Please login to your account and confirm the above enrolments.

Regards,
CAIT Department
                 "; 

            return emailTemplate;
        }
    }
}
