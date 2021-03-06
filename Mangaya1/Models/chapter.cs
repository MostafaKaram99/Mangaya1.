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
    
    public partial class chapter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public chapter()
        {
            this.chapter_content = new HashSet<chapter_content>();
            this.translations = new HashSet<translation>();
        }
    
        public int id { get; set; }
        public int manga_id { get; set; }
        public int chapter_number { get; set; }
        public int no_of_views { get; set; }
        public int no_of_downloads { get; set; }
        public float total_profit { get; set; }
        public System.DateTime date { get; set; }
        public string chaNameARB { get; set; }
        public string chaNameENG { get; set; }
        public float rate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chapter_content> chapter_content { get; set; }
        public virtual manga manga { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<translation> translations { get; set; }
    }
}
