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
    
    public partial class DossierAdmission
    {
        public string idAdmission { get; set; }
        public Nullable<bool> chirurgieProgramme { get; set; }
        public Nullable<System.DateTime> dateAdmission { get; set; }
        public Nullable<System.DateTime> dateChirurgie { get; set; }
        public Nullable<System.DateTime> dateConge { get; set; }
        public Nullable<double> prixTv { get; set; }
        public Nullable<double> prixTel { get; set; }
        public Nullable<double> prixCh { get; set; }
        public string numLit { get; set; }
        public string nss { get; set; }
        public string idMedecin { get; set; }
    
        public virtual Lit Lit { get; set; }
        public virtual Medecin Medecin { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
