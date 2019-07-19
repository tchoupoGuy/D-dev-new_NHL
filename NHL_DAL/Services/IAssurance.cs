using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
  public  interface IAssurance
    {
        void Add(Compagnie_Assurance compagnie_Assurance);
        IEnumerable<Compagnie_Assurance> GetAllAssuranceWithPatient();
        bool save();
    }
}
