using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Models.ViewModels
{
    public class LitDossierAdmission: DossierAdmissionPatient
    {
        public int Id_Lit { get; set; }
        public string Occupe { get; set; }
        public int Id_TypeLit { get; set; }
        public int Id_Departement { get; set; }
    }
}
