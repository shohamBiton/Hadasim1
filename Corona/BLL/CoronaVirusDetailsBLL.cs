using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace BLL
{
    public class CoronaVirusDetailsBLL
    {
        public static List<CoronaVirusDetailsEntities> GetAll()
        {
            return DAL.Functions.CoronaVirusDetailsFunctions.selectAll();
        }

        public static bool Add(CoronaVirusDetailsEntities coronaVirusDetailsEntities)
        {
            return DAL.Functions.CoronaVirusDetailsFunctions.Add(coronaVirusDetailsEntities);
        }
        public static int GetNotVaccinatedNum()
        {
            return GetAll().Count(p => p.vaccine1ReceiveTime = = null);
        }
    }
}
