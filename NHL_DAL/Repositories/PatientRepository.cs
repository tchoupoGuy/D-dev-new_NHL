using NHL_DAL.Models.ViewModels;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;
using NLH_DAL.Models.ViewModels;
using NLH_DAL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Repositories
{
    public class PatientRepository : IPatient
    {

        public readonly NLHContext _nHL;

        public PatientRepository(NLHContext nHL)
        {
            _nHL = nHL;
        }

        public IEnumerable<PatientAssuranceParentMededecin> GetAllWithAssuranceName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientAssuranceParentMededecin> GetAllWithMedecinName()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientAssuranceParentMededecin> GetAllWithParentName()
        {
            throw new NotImplementedException();
        }

        public PatientAssuranceParentMededecin GetOneWithAssuranceName(int id)
        {
            throw new NotImplementedException();
        }

        public PatientAssuranceParentMededecin GetOneWithMedecinName(int id)
        {
            throw new NotImplementedException();
        }

        public PatientAssuranceParentMededecin GetOneWithParentName(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientAssuranceParentMededecin> GetPatientForAssurance(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientAssuranceParentMededecin> GetPatientForMedecin(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientAssuranceParentMededecin> GetPatientForParent(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PatientAssuranceParentMededecin> Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
