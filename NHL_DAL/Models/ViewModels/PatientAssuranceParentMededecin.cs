using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NHL_DAL.Models.ViewModels
{
   public  class PatientAssuranceParentMededecin
    {
        /*Patient*/
        public int PatientID { get; set; }
        [DataType(DataType.Date)]
        public string DateNaissance { get; set; }
        [Display(Name = "Nom du patient")]
        public string Nom { get; set; }
        [Display(Name = "Prenom du patient")]
        public string Prenom { get; set; }
        [Display(Name = "Adresse  du patient")]
        public string Adresse { get; set; }
        [Display(Name = "ville du patient")]
        public string Ville { get; set; }
        [Display(Name = "Province du patient")]
        public string Province { get; set; }
        [DataType(DataType.PostalCode)]
        public string CodePostale { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
        /*Parent*/
        public int ParentID { get; set; }
        [Display(Name = "Nom du Parent")]
        public string NomParent { get; set; }
        [Display(Name = "Prenom du Parent")]
        public string PrenomParent { get; set; }
        [Display(Name = "Adresse  du Parent")]
        public string AdresseParent { get; set; }
        [Display(Name = "ville du Parent")]
        public string VilleParent { get; set; }
        [Display(Name = "Province du Parent")]
        public string ProvinceParent { get; set; }
        [DataType(DataType.PostalCode)]
        public string CodePostParent { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string TelephoneParent { get; set; }

        /*Compagnie d'assurance*/

        public int CompAssurID { get; set; }
        [Display(Name = "Province du Parent")]
        public string NomCompagnie { get; set; }

        /*Medecin*/
        public int MedecinID { get; set; }

        [Display(Name = "Nom du Médecin")]
        public string NomMedecin { get; set; }
        [Display(Name = "Prénom du Médecin")]
        public string PrenomMedecin { get; set; }
        [Display(Name = "Spécialité du Médecin")]
        public string SpecialiteMedecin { get; set; }
    }
}
