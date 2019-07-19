using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Type_Lit
    {
        [Key]
        public int Numero_Type { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Cout { get; set; }

        public virtual IEnumerable<Lit> Lits { get; set; }
    }
}
