using DAL.Converts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Functions
{
    public class CoronaVirusDetailsFunctions
    {
        public static List<CoronaVirusDetailsEntities> selectAll()
        {
            CoronaVirusDbEntities db = new CoronaVirusDbEntities();
            List<coronaVirusDetail> coronaVirusDetailsList = db.coronaVirusDetails.ToList();
            return CoronaVirusDetailsConverts.ConvertDBCoronaVirusDetailsListToEntities(coronaVirusDetailsList);
        }

        public static bool Add(CoronaVirusDetailsEntities coronaVirusDetailsEntities)
        {
            CoronaVirusDbEntities db = new CoronaVirusDbEntities();
            coronaVirusDetail coronaVirusDetails = CoronaVirusDetailsConverts.ConvertEntitiesToDBCoronaVirusDetails(coronaVirusDetailsEntities);
            db.coronaVirusDetails.Add(coronaVirusDetails);
            db.SaveChanges();
            return true;
        }
    }
}
