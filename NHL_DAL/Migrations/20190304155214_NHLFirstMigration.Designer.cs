﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLH_DAL.EF;

namespace NHL_DAL.Migrations
{
    [DbContext(typeof(NLHContext))]
    [Migration("20190304155214_NHLFirstMigration")]
    partial class NHLFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NLH_DAL.Models.Entities.Commodite_Admission", b =>
                {
                    b.Property<int>("Id_Admission");

                    b.Property<int>("Id_Commodite");

                    b.Property<int?>("Commodites_ExtraId_Commodites");

                    b.HasKey("Id_Admission", "Id_Commodite");

                    b.HasIndex("Commodites_ExtraId_Commodites");

                    b.ToTable("commodite_Admissions");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Commodites_Extra", b =>
                {
                    b.Property<int>("Id_Commodites")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description_Commodite")
                        .IsRequired();

                    b.Property<double>("Taux_Quotidient");

                    b.HasKey("Id_Commodites");

                    b.ToTable("commodites_Extras");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Compagnie_Assurance", b =>
                {
                    b.Property<int>("Id_Compagnie")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom_Compagnie")
                        .IsRequired();

                    b.HasKey("Id_Compagnie");

                    b.ToTable("assurances");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Departement", b =>
                {
                    b.Property<int>("Id_Departement")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom_Departement")
                        .IsRequired();

                    b.HasKey("Id_Departement");

                    b.ToTable("departements");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Dossier_Admission", b =>
                {
                    b.Property<int>("Id_Admission")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chirugie_Programme")
                        .IsRequired();

                    b.Property<DateTime>("Date_Admission");

                    b.Property<DateTime>("Date_Chirugie");

                    b.Property<DateTime>("Date_Conge");

                    b.Property<string>("NSS");

                    b.Property<int>("Numero_Lit");

                    b.HasKey("Id_Admission");

                    b.HasIndex("NSS");

                    b.HasIndex("Numero_Lit");

                    b.ToTable("dossier_Admissions");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Facture", b =>
                {
                    b.Property<int>("Num_Facture")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date_Facture");

                    b.Property<int>("Id_Admission");

                    b.Property<double>("Montant_Facture");

                    b.HasKey("Num_Facture");

                    b.HasIndex("Id_Admission");

                    b.ToTable("factures");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Lit", b =>
                {
                    b.Property<int>("Numero_Lit")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Id_Departement");

                    b.Property<int>("Numero_Type");

                    b.Property<string>("Occupe")
                        .IsRequired();

                    b.HasKey("Numero_Lit");

                    b.HasIndex("Id_Departement");

                    b.HasIndex("Numero_Type");

                    b.ToTable("lits");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Medecin", b =>
                {
                    b.Property<string>("Id_Medecin");

                    b.Property<string>("Nom_Medecin")
                        .IsRequired();

                    b.Property<string>("Prenom_Medecin")
                        .IsRequired();

                    b.Property<string>("Specialite_Medecin")
                        .IsRequired();

                    b.HasKey("Id_Medecin");

                    b.ToTable("medecins");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Parent", b =>
                {
                    b.Property<int>("Ref_Parent");

                    b.Property<string>("Adresse_Parent")
                        .IsRequired();

                    b.Property<string>("Code_Postale_Parent")
                        .IsRequired();

                    b.Property<string>("Nom_Parent")
                        .IsRequired();

                    b.Property<string>("Prenom_Parent")
                        .IsRequired();

                    b.Property<string>("Province_Parent")
                        .IsRequired();

                    b.Property<string>("Telephone_Parent")
                        .IsRequired();

                    b.Property<string>("Ville_Parent")
                        .IsRequired();

                    b.HasKey("Ref_Parent");

                    b.ToTable("parents");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Patient", b =>
                {
                    b.Property<string>("NSS");

                    b.Property<string>("Adresse_Patient")
                        .IsRequired();

                    b.Property<string>("Code_Postale_Patient")
                        .IsRequired();

                    b.Property<DateTime>("Date_Naissance_Patient");

                    b.Property<int>("Id_Compagnie");

                    b.Property<string>("Id_Medecin");

                    b.Property<string>("Nom_Patient")
                        .HasMaxLength(50);

                    b.Property<string>("Prenom_Patient")
                        .HasMaxLength(50);

                    b.Property<string>("Province_Patient")
                        .IsRequired();

                    b.Property<int>("Ref_Parent");

                    b.Property<string>("Telephone_Patient")
                        .IsRequired();

                    b.Property<string>("Ville_Patient")
                        .IsRequired();

                    b.HasKey("NSS");

                    b.HasIndex("Id_Compagnie");

                    b.HasIndex("Id_Medecin");

                    b.HasIndex("Ref_Parent");

                    b.ToTable("patients");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Type_Lit", b =>
                {
                    b.Property<int>("Numero_Type")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cout");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("Numero_Type");

                    b.ToTable("Type_Lits");
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Commodite_Admission", b =>
                {
                    b.HasOne("NLH_DAL.Models.Entities.Commodites_Extra", "Commodites_Extra")
                        .WithMany("Commodite_Admissions")
                        .HasForeignKey("Commodites_ExtraId_Commodites");

                    b.HasOne("NLH_DAL.Models.Entities.Dossier_Admission", "Dossier_Admission")
                        .WithMany("Commodite_Admissions")
                        .HasForeignKey("Id_Admission")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Dossier_Admission", b =>
                {
                    b.HasOne("NLH_DAL.Models.Entities.Patient", "Patient")
                        .WithMany("Dossier_Admissions")
                        .HasForeignKey("NSS");

                    b.HasOne("NLH_DAL.Models.Entities.Lit", "Lit")
                        .WithMany()
                        .HasForeignKey("Numero_Lit")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Facture", b =>
                {
                    b.HasOne("NLH_DAL.Models.Entities.Dossier_Admission", "Dossier_Admission")
                        .WithMany("Factures")
                        .HasForeignKey("Id_Admission")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Lit", b =>
                {
                    b.HasOne("NLH_DAL.Models.Entities.Departement", "Departement")
                        .WithMany("Lits")
                        .HasForeignKey("Id_Departement")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NLH_DAL.Models.Entities.Type_Lit", "Type_Lit")
                        .WithMany("Lits")
                        .HasForeignKey("Numero_Type")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NLH_DAL.Models.Entities.Patient", b =>
                {
                    b.HasOne("NLH_DAL.Models.Entities.Compagnie_Assurance", "Compagnie_Assurance")
                        .WithMany("Patients")
                        .HasForeignKey("Id_Compagnie")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NLH_DAL.Models.Entities.Medecin", "Medecin")
                        .WithMany("Patients")
                        .HasForeignKey("Id_Medecin");

                    b.HasOne("NLH_DAL.Models.Entities.Parent", "Parent")
                        .WithMany("Patients")
                        .HasForeignKey("Ref_Parent")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}