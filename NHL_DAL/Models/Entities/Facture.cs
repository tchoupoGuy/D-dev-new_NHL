using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Facture
    {
        [Key]
        public int Num_Facture { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date_Facture { get; set; }
        [Required]
        [Display(Name ="Montant de la facture")]
        public double Montant_Facture { get; set; }

        public int Id_Admission { get; set; }

        public virtual Dossier_Admission Dossier_Admission { get; set; }
    }
}
