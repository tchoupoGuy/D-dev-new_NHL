using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Lit
    {
        [Key]
        public int Numero_Lit { get; set; }
        [Required]
        public string Occupe { get; set; }
       
        public int Numero_Type { get; set; }

        public int Id_Departement { get; set; }

        public virtual Departement Departement { get; set; }
        public virtual Type_Lit Type_Lit { get; set; }
    }
}
