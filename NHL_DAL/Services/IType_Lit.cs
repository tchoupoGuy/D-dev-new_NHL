using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface IType_Lit
    {
        IEnumerable<Type_Lit> GetAllWithLit();
        Type_Lit GetOneWhithLit();
    }
}
