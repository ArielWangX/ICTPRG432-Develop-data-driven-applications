using HolmesglenStudentManagementSystem.DataAccessLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class UIProjectNumberGuideBLL
    {
        UIProjectNumberGuideDAL uIProjectNumberGuideDALInstance = new UIProjectNumberGuideDAL();

        public List<UIProjectNumberGuide> GetAllUIProjectNumberGuide()
        {
            return uIProjectNumberGuideDALInstance.SystemNumberGuides();                     
        }       
    }
}
