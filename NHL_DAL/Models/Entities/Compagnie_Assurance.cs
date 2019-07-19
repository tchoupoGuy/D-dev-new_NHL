using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Compagnie_Assurance
    {
        [Key]
        public int Id_Compagnie { get; set; }

        [Required]
        [Display(Name ="Nom compagnie d'assurrance")]
        public string Nom_Compagnie { get; set; }

        public virtual IEnumerable<Patient> Patients { get;  set; }
    }
}
