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
    
    public partial class seance
    {
        public int NumSc { get; set; }
        public Nullable<int> Créneau { get; set; }
        public Nullable<int> Jours { get; set; }
        public Nullable<int> Groupe { get; set; }
        public Nullable<int> Activite { get; set; }
        public Nullable<int> Entraineur { get; set; }
    
        public virtual Activite Activite1 { get; set; }
        public virtual Créneau Créneau1 { get; set; }
        public virtual Entraineur Entraineur1 { get; set; }
        public virtual Groupe Groupe1 { get; set; }
        public virtual jour jour { get; set; }
    }
}