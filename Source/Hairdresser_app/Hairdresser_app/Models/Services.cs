//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hairdresser_app.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Services()
        {
            this.Appointments = new HashSet<Appointments>();
        }
    
        public byte Service_Id { get; set; }
        public string Service_Name { get; set; }
        public string Service_Description { get; set; }
        public string Gender { get; set; }
        public byte Service_Length_Id { get; set; }
        public decimal Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual Service_Length Service_Length { get; set; }
    }
}
