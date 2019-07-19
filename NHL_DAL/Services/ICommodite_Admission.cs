using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
   public interface ICommodite_Admission
    {
        IEnumerable<Commodite_Admission> GetAll();
        Commodite_Admission GetOne();
    }
}
