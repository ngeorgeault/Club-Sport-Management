//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestion_Club_Sport_Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entraineur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entraineur()
        {
            this.Groupes = new HashSet<Groupe>();
            this.seances = new HashSet<seance>();
        }
    
        public int NumE { get; set; }
        public string NomE { get; set; }
        public string PrenomE { get; set; }
        public string LibelleE { get; set; }
        public Nullable<System.DateTime> DateN { get; set; }
        public string Sexe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Groupe> Groupes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seance> seances { get; set; }
    }
}
