using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converts
{
    public class PatientConverts
    {
        public static PatientEntities ConvertDBPatientsToEntities(patient patient)
        {
            PatientEntities patientEntities = new PatientEntities()
            {
                fullName = patient.fullName,
                patientId = patient.patientId,
                address = patient.address,
                city = patient.city,
                birthDate = patient.birthDate,
                telephone = patient.telephone,
                mobilePhone = patient.mobilePhone
            };
            return patientEntities;
        }

        public static patient ConvertEntitiesToDBPatients(PatientEntities patientEntities)
        {
            patient patient = new patient()
            {
                fullName = patientEntities.fullName,
                patientId = patientEntities.patientId,
                address = patientEntities.address,
                city = patientEntities.city,
                birthDate = patientEntities.birthDate,
                telephone = patientEntities.telephone,
                mobilePhone = patientEntities.mobilePhone
            };
            return patient;
        }

        public static List<PatientEntities> ConvertDBPatientsListToEntities(List<patient> patientList)
        {
            List<PatientEntities> patientEntitiesList = new List<PatientEntities>();
            patientList.ForEach(patient =>
            {
                patientEntitiesList.Add(ConvertDBPatientsToEntities(patient));  
            }
            );
            return patientEntitiesList;
        }

        public static List<patient> ConvertEntitiesListToDBPatients(List<PatientEntities> patientEntitiesList)
        {
            List<patient> patientList = new List<patient>();
            patientEntitiesList.ForEach(patientEntities=>
            {
                patientList.Add(ConvertEntitiesToDBPatients(patientEntities));
            }
            );
            return patientList;
        }
    }
}
