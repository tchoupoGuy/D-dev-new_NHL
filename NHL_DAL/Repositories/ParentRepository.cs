using NLH_DAL.Models.Entities;
using NLH_DAL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Repositories
{
    public class ParentRepository : IParent
    {
        public IEnumerable<Parent> GetAllParentWitPatient()
        {
            throw new NotImplementedException();
        }

        public Parent GetOneWithPatient()
        {
            throw new NotImplementedException();
        }
    }
}
