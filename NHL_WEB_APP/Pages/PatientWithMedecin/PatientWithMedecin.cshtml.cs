using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NLH_DAL.EF;
using NLH_DAL.Models.Entities;

namespace NHL_WEB_APP.Pages.PatientWithMedecin
{
    public class PatientWithMedecinModel : PageModel
    {
        public readonly NLHContext nHL;
        public IEnumerable<Medecin> Medecins { get; set; }

        public PatientWithMedecinModel(NLHContext nHL)
        {
            this.nHL = nHL;
        }

        public async Task OnGetAsync()
        {
            Medecins = await nHL.medecins
                                   .Include(p => p.Patients)
                                   .AsNoTracking()
                                   .ToListAsync();
           
           
        }
        public void OnGet()
        {

        }
    }
}