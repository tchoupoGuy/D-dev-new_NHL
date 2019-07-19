using NHL_DAL.Models.ViewModels;
using NLH_DAL.Models.Entities;
using NLH_DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface IPatient
    {
        IEnumerable<PatientAssuranceParentMededecin> Search(string searchString);
        IEnumerable<PatientAssuranceParentMededecin> GetAllWithMedecinName();
        IEnumerable<PatientAssuranceParentMededecin> GetAllWithParentName();
        IEnumerable<PatientAssuranceParentMededecin> GetAllWithAssuranceName();
        IEnumerable<PatientAssuranceParentMededecin> GetPatientForMedecin(int id);
        IEnumerable<PatientAssuranceParentMededecin> GetPatientForAssurance(int id);
        IEnumerable<PatientAssuranceParentMededecin> GetPatientForParent(int id);
        PatientAssuranceParentMededecin GetOneWithMedecinName(int id);
        PatientAssuranceParentMededecin GetOneWithParentName(int id);
        PatientAssuranceParentMededecin GetOneWithAssuranceName(int id);
    }
}
