using NLH_DAL.EF;
using NLH_DAL.Models.Entities;
using NLH_DAL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Repositories
{
    public class Compagnie_AssuranceRepository : IAssurance
    {
        public NLHContext _NLH;

        public Compagnie_AssuranceRepository()
        {
        }

        public Compagnie_AssuranceRepository(NLHContext NLH)
        {
            _NLH = NLH;
        }

        public void Add(Compagnie_Assurance compagnie_Assurance)
        {
            _NLH.assurances.Add(compagnie_Assurance);
        }

        public IEnumerable<Compagnie_Assurance> GetAllAssuranceWithPatient()
        {
            throw new NotImplementedException();
        }

        public bool save()
        {
           return _NLH.SaveChanges() > 0;
        }
    }
}
