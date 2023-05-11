using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace BLL
{
    public class PatientBLL
    {
        public static List<PatientEntities> GetAll()
        {
            return DAL.Functions.PatientFunctions.selectAll();
        }
 
        public static bool Add(PatientEntities patientEntities)
        {
            return DAL.Functions.PatientFunctions.Add(patientEntities);
        }
 
    }
}
