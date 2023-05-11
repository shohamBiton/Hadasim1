using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PatientEntities
    {
        public string fullName { get; set; }
        public string patientId { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public Nullable<System.DateTime> birthDate { get; set; }
        public string telephone { get; set; }
        public string mobilePhone { get; set; }
    }
}
