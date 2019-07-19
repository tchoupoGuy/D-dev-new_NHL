using NLH_DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.Services
{
    public interface ILit
    {
        IEnumerable<LitDossierAdmission> GetAllLitWithDossierAdmission();
        LitDossierAdmission GetOneWithDossierAdmission();
    }
}
