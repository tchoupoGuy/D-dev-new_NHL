using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NLH_DAL.Models.ViewModels
{
    public class CommoditeExtraDossierAdm
    {
        public int CommoditeExtraID { get; set; }

        
        [Display(Name = "Description de la commodité extra")]
        public string Description_Commodite { get; set; }
       
        [DataType(DataType.Currency)]
        public double Taux_Quotidient { get; set; }
    }
}
