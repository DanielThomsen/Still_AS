//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingLinje
    {
        public int ID { get; set; }
        public string DemoNummer { get; set; }
        public int BookingID { get; set; }
        public string KonfigurationTekst { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Maskine Maskine { get; set; }
    }
}
