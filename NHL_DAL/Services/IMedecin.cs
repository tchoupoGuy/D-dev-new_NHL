using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface IMedecin
    {
        IEnumerable<Medecin> GetAllWithPatient();

        Medecin GetOneWithPatient(int id);
    }
}
