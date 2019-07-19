using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NLH_DAL.Models.Entities
{
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string NSS { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime Date_Naissance_Patient { get; set; }
        [StringLength(50,ErrorMessage ="Le nom ne doit pas dépassé 50 caractères")]
        public string Nom_Patient { get; set; }
        [StringLength(50, ErrorMessage = "Le prenom ne doit pas dépassé 50 caractères")]
        public string Prenom_Patient { get; set; }
        [Required]
        [Display(Name ="Adresse du patient")]
        public string Adresse_Patient { get; set; }
        [Required]
        [Display(Name = "Ville du patient")]
        public string Ville_Patient { get; set; }
        [Required]
        [Display(Name = "Province du patient")]
        public string Province_Patient { get; set; }
        [DataType(DataType.PostalCode)]
        [Required]
        public string Code_Postale_Patient { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Telephone_Patient { get; set; }
        [Display(Name = "Nom et prenom du patient")]
        public string NomPrenom
        {
            get { return Nom_Patient + " , " + Prenom_Patient; }
        }


        public string Id_Medecin { get; set; }
        public int Id_Compagnie { get; set; }
        public int Ref_Parent { get; set; }

        public virtual Medecin Medecin { get; set; }
        public virtual Compagnie_Assurance Compagnie_Assurance { get; set; }
        public virtual Parent  Parent{ get; set; }

        public virtual IEnumerable<Dossier_Admission> Dossier_Admissions { get; set; }
    }
}
