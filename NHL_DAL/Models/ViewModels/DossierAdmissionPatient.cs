using NHL_DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NLH_DAL.Models.ViewModels
{
    public class DossierAdmissionPatient: PatientAssuranceParentMededecin
    {
       

        public int DossierAdmissionID { get; set; }
        [Display(Name = "Chirugie programmée")]
        public string ChirugieP { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateConge { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateAdm { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateChir { get; set; }


        public int FactureID { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_Facture { get; set; }
        
        [Display(Name = "Montant de la facture")]
        public double Montant_Facture { get; set; }

        IEnumerable<CommoditeExtraDossierAdm> extraDossierAdms { get; set; }
    }
}
