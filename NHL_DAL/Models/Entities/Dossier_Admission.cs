using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Dossier_Admission
    {
        [Key]
        public int Id_Admission { get; set; }
        [Required]
        [Display(Name ="Chirugie Programmée")]
        public string Chirugie_Programme { get; set; }
        [DataType(DataType.Date)]
       // [DisplayFormat(DataFormatString ="0:yyyy-MM-dd",ApplyFormatInEditMode =true)]
        public DateTime Date_Admission { get; set; }
        [DataType(DataType.Date)]
       // [DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime Date_Chirugie { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date_Conge { get; set; }

        public string NSS { get; set; }
        public int Numero_Lit { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Lit Lit { get; set; }

        public virtual IEnumerable<Commodite_Admission> Commodite_Admissions { get; set; }
        public virtual IEnumerable<Facture> Factures { get; set; }
    }
}
