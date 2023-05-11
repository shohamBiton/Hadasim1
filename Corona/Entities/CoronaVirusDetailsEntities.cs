using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CoronaVirusDetailsEntities
    {
        public string patientId { get; set; }
        public Nullable<System.DateTime> vaccine1ReceiveTime { get; set; }
        public Nullable<System.DateTime> vaccine2ReceiveTime { get; set; }
        public Nullable<System.DateTime> vaccine3ReceiveTime { get; set; }
        public Nullable<System.DateTime> vaccine4ReceiveTime { get; set; }
        public Nullable<System.DateTime> positiveResultDate { get; set; }
        public Nullable<System.DateTime> recoveryDate { get; set; }
        public string vaccine1Manufacturer { get; set; }
        public string vaccine2Manufacturer { get; set; }
        public string vaccine3Manufacturer { get; set; }
        public string vaccine4Manufacturer { get; set; }
    }
}
