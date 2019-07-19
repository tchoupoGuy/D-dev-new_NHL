using NLH_DAL.Models.Entities;
using NLH_DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface IDossier_Admission
    {
        IEnumerable<DossierAdmissionPatient> Search(string searchString);
        IEnumerable<DossierAdmissionPatient> GetAllWithPatientName();
        IEnumerable<DossierAdmissionPatient> GetAllWithFacture();
        IEnumerable<DossierAdmissionPatient> GetDossierAdmissionForPatient(int id);
        IEnumerable<DossierAdmissionPatient> GetDossierAdmissionForFacture(int id);
       
        DossierAdmissionPatient GetOneWithPatientName(int id);
        DossierAdmissionPatient GetOneWithFacture(int id);
       
    }
}
