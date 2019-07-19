using NLH_DAL.Models.Entities;
using NLH_DAL.Models.ViewModels;
using NLH_DAL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Repositories
{
    public class Dossier_AdmissionRepository : IDossier_Admission
    {
        public IEnumerable<DossierAdmissionPatient> GetAllWithFacture()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DossierAdmissionPatient> GetAllWithPatientName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DossierAdmissionPatient> GetDossierAdmissionForFacture(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DossierAdmissionPatient> GetDossierAdmissionForPatient(int id)
        {
            throw new NotImplementedException();
        }

        public DossierAdmissionPatient GetOneWithFacture(int id)
        {
            throw new NotImplementedException();
        }

        public DossierAdmissionPatient GetOneWithPatientName(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DossierAdmissionPatient> Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
