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
    
    public partial class Maskine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Maskine()
        {
            this.BookingLinjes = new HashSet<BookingLinje>();
        }
    
        public string DemoNummer { get; set; }
        public string ModelName { get; set; }
        public string Type { get; set; }
        public string Fabrikant { get; set; }
        public string Chassisnummer { get; set; }
        public string MastType { get; set; }
        public Nullable<int> MastByggeHøjde { get; set; }
        public Nullable<int> MastLøfteHøjde { get; set; }
        public Nullable<int> MastFriLøft { get; set; }
        public string Betjening { get; set; }
        public string Aggregat { get; set; }
        public string AggregarNummer { get; set; }
        public string BatteriType { get; set; }
        public string BatteriNummer { get; set; }
        public string LaderType { get; set; }
        public string LaderNummer { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> Width { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingLinje> BookingLinjes { get; set; }
        public virtual ModelNavn ModelNavn { get; set; }
    }
}
