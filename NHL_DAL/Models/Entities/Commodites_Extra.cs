using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Commodites_Extra
    {
        [Key]
        public int Id_Commodites { get; set; }

        [Required]
        [Display(Name ="Description de la commodité extra")]
        public string Description_Commodite { get; set; }
        [Required]
        [Display(Name ="Taux quotidient")]
        public double Taux_Quotidient { get; set; }

        public virtual IEnumerable<Commodite_Admission> Commodite_Admissions { get; set; }
    }
}
