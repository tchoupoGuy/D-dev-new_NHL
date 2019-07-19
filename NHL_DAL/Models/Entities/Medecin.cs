using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Medecin
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string Id_Medecin { get; set; }
        [Required]
        [Display(Name = "Nom du médécin")]
        public string Nom_Medecin { get; set; }
        [Required]
        [Display(Name = "Prenom du médécin")]
        public string Prenom_Medecin { get; set; }
        [Required]
        [Display(Name = "Spécialité du médécin")]
        public string Specialite_Medecin { get; set; }


        public virtual IEnumerable<Patient> Patients { get; set; }
    }
}
