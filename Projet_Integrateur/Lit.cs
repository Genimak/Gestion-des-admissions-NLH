//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_Integrateur
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lit()
        {
            this.DossierAdmissions = new HashSet<DossierAdmission>();
        }
    
        public string numLit { get; set; }
        public Nullable<bool> occupe { get; set; }
        public string numeroType { get; set; }
        public string idDepartement { get; set; }
    
        public virtual Departement Departement { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DossierAdmission> DossierAdmissions { get; set; }
        public virtual TypeLit TypeLit { get; set; }
    }
}
