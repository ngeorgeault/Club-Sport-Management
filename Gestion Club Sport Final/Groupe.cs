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
    
    public partial class Groupe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Groupe()
        {
            this.Adherents = new HashSet<Adherent>();
            this.seances = new HashSet<seance>();
        }
    
        public int CodeG { get; set; }
        public Nullable<int> Activite { get; set; }
        public string DescriptionG { get; set; }
        public Nullable<int> Entraineur { get; set; }
        public Nullable<int> Salle { get; set; }
    
        public virtual Activite Activite1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adherent> Adherents { get; set; }
        public virtual Entraineur Entraineur1 { get; set; }
        public virtual Salle Salle1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<seance> seances { get; set; }
    }
}
