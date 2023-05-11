using DAL.Converts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
    public class PatientFunctions
    {
        public static List<PatientEntities> selectAll()//שלוף הכל
        {
            CoronaVirusDbEntities db = new CoronaVirusDbEntities();
            List<patient> patientList = db.patients.ToList();
            return PatientConverts.ConvertDBPatientsListToEntities(patientList);
        }

        public static bool Add(PatientEntities patientEntities)
        {
            CoronaVirusDbEntities db = new CoronaVirusDbEntities();
            patient patient = PatientConverts.ConvertEntitiesToDBPatients(patientEntities);
            db.patients.Add(patient);
            db.SaveChanges();
            return true;
        }
    }
}
