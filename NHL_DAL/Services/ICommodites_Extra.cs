using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface ICommodites_Extra
    {
        IEnumerable<Commodites_Extra> GetAll();

        Commodites_Extra GetOne();
    }
}
