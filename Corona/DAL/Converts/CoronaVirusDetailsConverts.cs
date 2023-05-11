using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Converts
{
    public class CoronaVirusDetailsConverts
    {
        public static CoronaVirusDetailsEntities ConvertDBCoronaVirusDetailsToEntities(coronaVirusDetail coronaVirusDetails)
        {
            CoronaVirusDetailsEntities coronaDetailsEntities = new CoronaVirusDetailsEntities()
            {
                patientId= coronaVirusDetails.patientId,
                vaccine1ReceiveTime= coronaVirusDetails.vaccine1ReceiveTime,
                vaccine2ReceiveTime= coronaVirusDetails.vaccine2ReceiveTime,
                vaccine3ReceiveTime= coronaVirusDetails.vaccine3ReceiveTime,
                vaccine4ReceiveTime= coronaVirusDetails.vaccine4ReceiveTime,
                vaccine1Manufacturer= coronaVirusDetails.vaccine1Manufacturer,
                vaccine2Manufacturer= coronaVirusDetails.vaccine2Manufacturer,
                vaccine3Manufacturer= coronaVirusDetails.vaccine3Manufacturer,
                vaccine4Manufacturer= coronaVirusDetails.vaccine4Manufacturer,
                positiveResultDate= coronaVirusDetails.positiveResultDate,
                recoveryDate= coronaVirusDetails.recoveryDate
             };
            return coronaDetailsEntities;
        }

        public static coronaVirusDetail ConvertEntitiesToDBCoronaVirusDetails(CoronaVirusDetailsEntities coronaVirusDetailsEntities)
        {
            coronaVirusDetail coronaVirusDetails = new coronaVirusDetail()
            {
                patientId = coronaVirusDetailsEntities.patientId,
                vaccine1ReceiveTime = coronaVirusDetailsEntities.vaccine1ReceiveTime,
                vaccine2ReceiveTime = coronaVirusDetailsEntities.vaccine2ReceiveTime,
                vaccine3ReceiveTime = coronaVirusDetailsEntities.vaccine3ReceiveTime,
                vaccine4ReceiveTime = coronaVirusDetailsEntities.vaccine4ReceiveTime,
                vaccine1Manufacturer = coronaVirusDetailsEntities.vaccine1Manufacturer,
                vaccine2Manufacturer = coronaVirusDetailsEntities.vaccine2Manufacturer,
                vaccine3Manufacturer = coronaVirusDetailsEntities.vaccine3Manufacturer,
                vaccine4Manufacturer = coronaVirusDetailsEntities.vaccine4Manufacturer,
                positiveResultDate = coronaVirusDetailsEntities.positiveResultDate,
                recoveryDate = coronaVirusDetailsEntities.recoveryDate
            };
            return coronaVirusDetails;
        }

        public static List<CoronaVirusDetailsEntities> ConvertDBCoronaVirusDetailsListToEntities(List<coronaVirusDetail> coronaVirusDetailsList)
        {
            List<CoronaVirusDetailsEntities> coronaVirusDetailsEntitiesList = new List<CoronaVirusDetailsEntities>();
            coronaVirusDetailsList.ForEach(coronaVirusDetails =>
            {
                coronaVirusDetailsEntitiesList.Add(ConvertDBCoronaVirusDetailsToEntities(coronaVirusDetails));
            });
            return coronaVirusDetailsEntitiesList;
        }

        public static List<coronaVirusDetail> ConvertEntitiesListToDBCoronaVirusDetails(List<CoronaVirusDetailsEntities> coronaVirusDetailsEntitiesList)
        {
            List<coronaVirusDetail> coronaVirusDetails = new List<coronaVirusDetail>();
            coronaVirusDetailsEntitiesList.ForEach(patientEntities =>
            {
                coronaVirusDetails.Add(ConvertEntitiesToDBCoronaVirusDetails(patientEntities));
            }
            );
            return coronaVirusDetails;
        }
    }
}
