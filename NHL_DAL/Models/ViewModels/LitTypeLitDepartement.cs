using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NHL_DAL.Models.ViewModels
{
    class LitTypeLitDepartement
    {
        /*Lit*/
        public int LitID { get; set; }
        [Display(Name="Occupé ou pas occupé")]
        public string Occupe { get; set; }


        /*Type Lit*/
        public int TypeLitID { get; set; }

        [Display(Name ="Description du type de lit")]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public double Cout { get; set; }

        /*Département */
        public int DaepartementID { get; set; }
        [Display(Name = "Nom du département")]
        public string Nom_Departement { get; set; }
    }
}
