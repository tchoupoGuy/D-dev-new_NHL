using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NLH_DAL.Models.Entities
{
   public class Commodite_Admission
    {
        //[Key]
        //public int Id_Com_Adm { get; set; }

        public int Id_Admission { get; set; }

        public int Id_Commodite { get; set; }

        public virtual Commodites_Extra Commodites_Extra { get; set; }

        public virtual Dossier_Admission Dossier_Admission { get; set; }
    }
}
