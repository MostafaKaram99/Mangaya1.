//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mangaya1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class category_type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public category_type()
        {
            this.category_manga = new HashSet<category_manga>();
        }
    
        public int categoryid { get; set; }
        public string type_eng { get; set; }
        public string type_arb { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<category_manga> category_manga { get; set; }
    }
}
