
using Microsoft.Extensions.DependencyInjection;
using NLH_DAL.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NLH_DAL.EF
{
    public static class NLHDBInitializer
    {

        public static void Initializer(NLHContext nLHContext)
        {
            // IApplicationBuilder applicationBuilder)
            // NLHContext nLHContext = applicationBuilder.ApplicationServices.GetRequiredService<NLHContext>();
            //nLHContext.Database.EnsureCreated();

            if (nLHContext.medecins.Any())
            {
                return;
            }

            var Medecins = new Medecin[]
            {
                new Medecin{Id_Medecin="MaMa",  Nom_Medecin="Manon",Prenom_Medecin="Marie",Specialite_Medecin="Chirugien"},
                new Medecin{Id_Medecin="PaLa",Nom_Medecin="Patrick",Prenom_Medecin="Lambert",Specialite_Medecin="Dentiste"},
                new Medecin{Id_Medecin="LoHe",  Nom_Medecin="Lonbon",Prenom_Medecin="Henrie",Specialite_Medecin="Pédiatre"},
                new Medecin{Id_Medecin="MaAn",  Nom_Medecin="Marilou",Prenom_Medecin="Annette",Specialite_Medecin="Géneraliste"},
                new Medecin{ Id_Medecin="HoIn", Nom_Medecin="Hoiutiu",Prenom_Medecin="Ines",Specialite_Medecin="Ophtamologue"},
                new Medecin{Id_Medecin="LoMa",Nom_Medecin="Londurt",Prenom_Medecin="Max",Specialite_Medecin="Chirugien"},

            };
            foreach (Medecin m in Medecins)
            {
                nLHContext.medecins.Add(m);
            }
            nLHContext.SaveChanges();

            var Parents = new Parent[]
            {
                new Parent{Nom_Parent="Marilyn",
                           Prenom_Parent ="Monar",
                           Adresse_Parent ="Jarry",
                           Ville_Parent ="Montréal",
                           Province_Parent ="Québec",
                           Code_Postale_Parent ="H2G3R8",
                           Telephone_Parent ="4385825748"},
                 new Parent{Nom_Parent="Pat",
                           Prenom_Parent ="Le chat",
                           Adresse_Parent ="Papineau",
                           Ville_Parent ="Montréal",
                           Province_Parent ="Québec",
                           Code_Postale_Parent ="H1G3R7",
                           Telephone_Parent ="4385805748"},
                  new Parent{Nom_Parent="Marcelle",
                           Prenom_Parent ="Desailly",
                           Adresse_Parent ="Bourassa",
                           Ville_Parent ="Montréal",
                           Province_Parent ="Québec",
                           Code_Postale_Parent ="H2G3G9",
                           Telephone_Parent ="5145825748"},
                   new Parent{Nom_Parent="Lambertin",
                           Prenom_Parent ="Moiu",
                           Adresse_Parent ="Beaubien",
                           Ville_Parent ="Montréal",
                           Province_Parent ="Québec",
                           Code_Postale_Parent ="J5G3R8",
                           Telephone_Parent ="4385825760"},
            };

            foreach (Parent p in Parents)
            {
                nLHContext.parents.Add(p);
            }
            nLHContext.SaveChanges();

            var CompagnieAssurances = new Compagnie_Assurance[]
            {
                new Compagnie_Assurance{Nom_Compagnie="Industriel Alliance"},
                new Compagnie_Assurance{Nom_Compagnie="La crois bleue"},
                new Compagnie_Assurance{Nom_Compagnie="RAMQ"},
                new Compagnie_Assurance{Nom_Compagnie="AXA"},
            };

            foreach (Compagnie_Assurance c in CompagnieAssurances)
            {
                nLHContext.assurances.Add(c);
            }
            nLHContext.SaveChanges();


            var Patients = new Patient[]
            {
                new Patient{
                    NSS="RIAN0212",
                    Date_Naissance_Patient=DateTime.Parse("1998-02-12"),
                    Nom_Patient="Rita",
                    Prenom_Patient="Anuska",
                    Adresse_Patient="Jarry",
                    Ville_Patient="Montréal",
                    Province_Patient="Québec",
                    Code_Postale_Patient="K5O6T8",
                    Telephone_Patient="5142876589",
                    Id_Medecin=Medecins.Single(m=>m.Nom_Medecin=="Manon").Id_Medecin,
                    Id_Compagnie=CompagnieAssurances.Single(c=>c.Nom_Compagnie=="Industriel Alliance").Id_Compagnie,
                    Ref_Parent=Parents.Single(p=>p.Nom_Parent=="Marilyn").Ref_Parent

                },
                new Patient{
                    NSS="MALI0212",
                    Date_Naissance_Patient=DateTime.Parse("2009-02-12"),
                    Nom_Patient="Marina",
                    Prenom_Patient="lise",
                    Adresse_Patient="Papineau",
                    Ville_Patient="Montréal",
                    Province_Patient="Québec",
                    Code_Postale_Patient="K5A6S8",
                    Telephone_Patient="5146986589",
                    Id_Medecin=Medecins.Single(m=>m.Nom_Medecin=="Patrick").Id_Medecin,
                    Id_Compagnie=CompagnieAssurances.Single(c=>c.Nom_Compagnie=="RAMQ").Id_Compagnie,
                    Ref_Parent=Parents.Single(p=>p.Nom_Parent=="Pat").Ref_Parent

                },
                new Patient{
                    NSS="LOMA1012",
                    Date_Naissance_Patient=DateTime.Parse("2016-10-12"),
                    Nom_Patient="Louise",
                    Prenom_Patient="Mali",
                    Adresse_Patient="Pie IX",
                    Ville_Patient="Montréal",
                    Province_Patient="Québec",
                    Code_Postale_Patient="B4P6T8",
                    Telephone_Patient="4382876589",
                    Id_Medecin=Medecins.Single(m=>m.Nom_Medecin=="Lonbon").Id_Medecin,
                    Id_Compagnie=CompagnieAssurances.Single(c=>c.Nom_Compagnie=="La crois bleue").Id_Compagnie,
                    Ref_Parent=Parents.Single(p=>p.Nom_Parent=="Marcelle").Ref_Parent
                },
                 new Patient{
                    NSS="MALO1130",
                    Date_Naissance_Patient=DateTime.Parse("2016-11-30"),
                    Nom_Patient="Marina",
                    Prenom_Patient="Loula",
                    Adresse_Patient="Pie IX",
                    Ville_Patient="Montréal",
                    Province_Patient="Québec",
                    Code_Postale_Patient="B4P6T8",
                    Telephone_Patient="4382876589",
                    Id_Medecin=Medecins.Single(m=>m.Nom_Medecin=="Lonbon").Id_Medecin,
                    Id_Compagnie=CompagnieAssurances.Single(c=>c.Nom_Compagnie=="La crois bleue").Id_Compagnie,
                    Ref_Parent=Parents.Single(p=>p.Nom_Parent=="Marcelle").Ref_Parent
                },
            };

            foreach (Patient p in Patients)
            {
                var patientInDB = nLHContext.patients.Where(
                    m => m.Medecin.Id_Medecin == p.Id_Medecin &&
                       m.Compagnie_Assurance.Id_Compagnie == p.Id_Compagnie &&
                       m.Parent.Ref_Parent == p.Ref_Parent
                    ).SingleOrDefault();
                if (patientInDB==null)
                {
                    nLHContext.patients.Add(p);
                } 
            }
            nLHContext.SaveChanges();

            var Departements = new Departement[]
            {
                new Departement{Nom_Departement="Pédiatrie"},
                new Departement{Nom_Departement="Chirugie"},
                new Departement{Nom_Departement="Ophtamologie"},
                new Departement{Nom_Departement="Génicologie"},
                new Departement{Nom_Departement="Pédiatrie"},
            };
            foreach (Departement d in Departements)
            {
                nLHContext.departements.Add(d);
            }
            nLHContext.SaveChanges();

            var TypeLits = new Type_Lit[]
            {
                new Type_Lit{Description="Individuel",Cout=250},
                new Type_Lit{Description="Double",Cout=150},
                new Type_Lit{Description="standart",Cout=50},
            };
            foreach (Type_Lit t in TypeLits)
            {
                nLHContext.Type_Lits.Add(t);
            }
            nLHContext.SaveChanges();

            var Lits = new Lit[]
            {
              new Lit{Occupe="non",
                      Id_Departement=Departements.Single(l=>l.Nom_Departement=="Pédiatrie").Id_Departement,
                      Numero_Type=TypeLits.Single(t=>t.Description=="Individuel").Numero_Type
                       },
              new Lit{Occupe="non",
                      Id_Departement=Departements.Single(l=>l.Nom_Departement=="Pédiatrie").Id_Departement,
                      Numero_Type=TypeLits.Single(t=>t.Description=="standart").Numero_Type
                       },
              new Lit{Occupe="oui",
                      Id_Departement=Departements.Single(l=>l.Nom_Departement=="Pédiatrie").Id_Departement,
                      Numero_Type=TypeLits.Single(t=>t.Description=="Double").Numero_Type
                       }
            };
            foreach (Lit l in Lits)
            {
                var litInDB = nLHContext.lits.Where(
                    s => s.Departement.Id_Departement == l.Id_Departement &&
                       s.Type_Lit.Numero_Type == l.Numero_Type
                    ).SingleOrDefault();
                if (litInDB==null)
                {
                    nLHContext.lits.Add(l);
                }
                
            }
            nLHContext.SaveChanges();

            var DossierAdmissions = new Dossier_Admission[]
            {
                new Dossier_Admission
                {
                    Chirugie_Programme="Jambe",
                    Date_Admission=DateTime.Parse("2018/06/03"),
                    Date_Chirugie=DateTime.Parse("2018/06/04"),
                    Date_Conge=DateTime.Parse("2018/08/10"),
                    NSS=Patients.Single(p=>p.NSS=="MALI0212").NSS,
                    Numero_Lit=Lits.Single(l=>l.Occupe=="non").Numero_Lit

                },
                 new Dossier_Admission
                {
                    Chirugie_Programme="Colon",
                    Date_Admission=DateTime.Parse("2018/10/03"),
                    Date_Chirugie=DateTime.Parse("2018/10/04"),
                    Date_Conge=DateTime.Parse("2018/11/10"),
                    NSS=Patients.Single(p=>p.NSS=="RIAN0212").NSS,
                    Numero_Lit=Lits.Single(l=>l.Occupe=="non").Numero_Lit

                },
                  new Dossier_Admission
                {
                    Chirugie_Programme="Jambe",
                    Date_Admission=DateTime.Parse("2019/06/03"),
                    Date_Chirugie=DateTime.Parse("2019/06/04"),
                    Date_Conge=DateTime.Parse("2019/08/10"),
                    NSS=Patients.Single(p=>p.NSS=="LOMA1012").NSS,
                    Numero_Lit=Lits.Single(l=>l.Occupe=="oui").Numero_Lit
                },
                   new Dossier_Admission
                {
                    Chirugie_Programme="Genou",
                    Date_Admission=DateTime.Parse("2018/06/03"),
                    Date_Chirugie=DateTime.Parse("2018/06/04"),
                    Date_Conge=DateTime.Parse("2018/08/10"),
                    NSS=Patients.Single(p=>p.NSS=="MALO1130").NSS,
                    Numero_Lit=Lits.Single(l=>l.Occupe=="oui").Numero_Lit
                }
            };

            foreach (Dossier_Admission d in DossierAdmissions)
            {
                var dossAdmInDB = nLHContext.dossier_Admissions.Where(
                    s => s.Patient.NSS == d.NSS &&
                         s.Lit.Numero_Lit == d.Numero_Lit).SingleOrDefault();

                if (dossAdmInDB==null)
                {
                    nLHContext.dossier_Admissions.Add(d);
                } 
            }
            nLHContext.SaveChanges();

            var Factures = new Facture[]
            {
                new Facture{
                    Date_Facture=DateTime.Parse("2019/08/20"),
                    Montant_Facture=568,
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Prostate").Id_Admission
                     },
                new Facture{
                    Date_Facture=DateTime.Parse("2018/08/20"),
                    Montant_Facture=668,
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Colon").Id_Admission
                     },
                new Facture{
                    Date_Facture=DateTime.Parse("2017/08/20"),
                    Montant_Facture=1000,
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Jambe").Id_Admission
                     },
                 new Facture{
                    Date_Facture=DateTime.Parse("2019/01/20"),
                    Montant_Facture=1000,
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Genou").Id_Admission
                     }
            };
                foreach (Facture f in Factures)
                {
                nLHContext.factures.Add(f);
                }
                 nLHContext.SaveChanges();

            var CommoditeExtras = new Commodites_Extra[]
            {
                new Commodites_Extra{
                    Description_Commodite="Televiseur",
                    Taux_Quotidient=205,
                },
                new Commodites_Extra{
                    Description_Commodite="Televiseur+téléphone",
                    Taux_Quotidient=355,
                },

                new Commodites_Extra{
                    Description_Commodite="Téléphone",
                    Taux_Quotidient=205,
                }

            };
            foreach (Commodites_Extra c in CommoditeExtras)
            {
                nLHContext.commodites_Extras.Add(c);
            }
            nLHContext.SaveChanges();

            var CommoditeAdmissions = new Commodite_Admission[]
            {
                new Commodite_Admission
                {
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Prostate").Id_Admission,
                    Id_Commodite=CommoditeExtras.Single(c=>c.Description_Commodite=="Televiseur").Id_Commodites

                },
                new Commodite_Admission
                {
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Colon").Id_Admission,
                    Id_Commodite=CommoditeExtras.Single(c=>c.Description_Commodite=="Téléphone").Id_Commodites

                },
                new Commodite_Admission
                {
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Jambe").Id_Admission,
                    Id_Commodite=CommoditeExtras.Single(c=>c.Description_Commodite=="Televiseur+téléphone").Id_Commodites
                },
                  new Commodite_Admission
                {
                    Id_Admission=DossierAdmissions.Single(d=>d.Chirugie_Programme=="Genou").Id_Admission,
                    Id_Commodite=CommoditeExtras.Single(c=>c.Description_Commodite=="Televiseur+téléphone").Id_Commodites
                },
            };
            foreach(Commodite_Admission c in CommoditeAdmissions)
            {
                nLHContext.commodite_Admissions.Add(c);
            }
            nLHContext.SaveChanges();
        }
    }
}
