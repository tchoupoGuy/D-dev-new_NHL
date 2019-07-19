using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Departement
    {
        [Key]
        public int Id_Departement { get; set; }

        [Required]
        [Display(Name ="Nom du département")]
        public string Nom_Departement { get; set; }


        public virtual IEnumerable<Lit> Lits { get; set; }

    }
}
