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
    
    public partial class Adherent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adherent()
        {
            this.Abonners = new HashSet<Abonner>();
            this.paiments = new HashSet<paiment>();
        }
    
        public int NumA { get; set; }
        public string NomA { get; set; }
        public string PrenomA { get; set; }
        public Nullable<System.DateTime> DateN { get; set; }
        public Nullable<System.DateTime> DateI { get; set; }
        public string Sexe { get; set; }
        public string Adresse { get; set; }
        public string VilleA { get; set; }
        public string Tel { get; set; }
        public Nullable<int> Groupe { get; set; }
        public Nullable<int> CodeAct { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonner> Abonners { get; set; }
        public virtual Activite Activite { get; set; }
        public virtual Groupe Groupe1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paiment> paiments { get; set; }
    }
}
