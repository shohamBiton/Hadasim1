//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class coronaVirusDetail
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
    
        public virtual patient patient { get; set; }
    }
}