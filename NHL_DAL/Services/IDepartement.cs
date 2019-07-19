using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface IDepartement
    {
        IEnumerable<Departement> GetAll();

        Departement GetOne();
    }
}
