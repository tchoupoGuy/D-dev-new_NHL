using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;
using NLH_DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLH_DAL.Repositories
{
    public class MedecinRepository : IMedecin
    {
        public readonly NLHContext _NLH;

        public MedecinRepository(NLHContext NLH)
        {
            _NLH = NLH;
        }

        public IEnumerable<Medecin> GetAllWithPatient()
        {
            return _NLH.medecins 
                   .Include(p=>p.Patients);
        }

        public Medecin GetOneWithPatient(string id)
        {
          return  GetAllWithPatient().FirstOrDefault(m=>m.Id_Medecin==id);
        }

        public Medecin GetOneWithPatient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
