using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Parent
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Ref_Parent { get; set; }
        [Required]
        [Display(Name = "Nom du parent")]
        public string Nom_Parent { get; set; }
        [Required]
        [Display(Name = "Prenom du parent")]
        public string Prenom_Parent { get; set; }
        [Required]
        [Display(Name = "Adresse du parent")]
        public string Adresse_Parent { get; set; }
        [Required]
        [Display(Name = "Ville du parent")]
        public string Ville_Parent { get; set; }
        [Required]
        [Display(Name = "Province du parent")]
        public string Province_Parent { get; set; }
        [DataType(DataType.PostalCode)]
        [Required]
        public string Code_Postale_Parent { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Telephone_Parent { get; set; }


        public virtual IEnumerable<Patient> Patients { get; set; }
    }
}
