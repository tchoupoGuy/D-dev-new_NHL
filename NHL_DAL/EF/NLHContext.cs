using Microsoft.EntityFrameworkCore;
using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLH_DAL.EF
{
   public class NLHContext:DbContext
    {
        public NLHContext()
        {
        }

        public NLHContext(DbContextOptions<NLHContext> options):base(options)
        {
        }
        public DbSet<Compagnie_Assurance> assurances { get; set; }
        public DbSet<Commodite_Admission> commodite_Admissions { get; set; }
        public DbSet<Commodites_Extra> commodites_Extras{ get; set; }
        public DbSet<Departement> departements { get; set; }
        public DbSet<Dossier_Admission> dossier_Admissions { get; set; }
        public DbSet<Facture> factures { get; set; }
        public DbSet<Lit> lits { get; set; }
        public DbSet<Medecin> medecins { get; set; }
        public DbSet<Parent> parents { get; set; }
        public DbSet<Patient> patients  { get; set; }
        public DbSet<Type_Lit> Type_Lits { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compagnie_Assurance>().ToTable("assurances");
            modelBuilder.Entity<Commodite_Admission>().ToTable("commodite_Admissions");
            modelBuilder.Entity<Commodites_Extra>().ToTable("commodites_Extras");
            modelBuilder.Entity<Departement>().ToTable("departements");
            modelBuilder.Entity<Dossier_Admission>().ToTable("dossier_Admissions");
            modelBuilder.Entity<Facture>().ToTable("factures");
            modelBuilder.Entity<Lit>().ToTable("lits");
            modelBuilder.Entity<Medecin>().ToTable("medecins");
            modelBuilder.Entity<Parent>().ToTable("parents");
            modelBuilder.Entity<Patient>().ToTable("patients");
            modelBuilder.Entity<Type_Lit>().ToTable("Type_Lits");

            modelBuilder.Entity<Commodite_Admission>().HasKey(c => new { c.Id_Admission, c.Id_Commodite});
        }

    }
}
