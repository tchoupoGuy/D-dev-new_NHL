using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NHL_DAL.Migrations
{
    public partial class NHLFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assurances",
                columns: table => new
                {
                    Id_Compagnie = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom_Compagnie = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assurances", x => x.Id_Compagnie);
                });

            migrationBuilder.CreateTable(
                name: "commodites_Extras",
                columns: table => new
                {
                    Id_Commodites = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description_Commodite = table.Column<string>(nullable: false),
                    Taux_Quotidient = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commodites_Extras", x => x.Id_Commodites);
                });

            migrationBuilder.CreateTable(
                name: "departements",
                columns: table => new
                {
                    Id_Departement = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nom_Departement = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departements", x => x.Id_Departement);
                });

            migrationBuilder.CreateTable(
                name: "medecins",
                columns: table => new
                {
                    Id_Medecin = table.Column<string>(nullable: false),
                    Nom_Medecin = table.Column<string>(nullable: false),
                    Prenom_Medecin = table.Column<string>(nullable: false),
                    Specialite_Medecin = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medecins", x => x.Id_Medecin);
                });

            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    Ref_Parent = table.Column<int>(nullable: false),
                    Nom_Parent = table.Column<string>(nullable: false),
                    Prenom_Parent = table.Column<string>(nullable: false),
                    Adresse_Parent = table.Column<string>(nullable: false),
                    Ville_Parent = table.Column<string>(nullable: false),
                    Province_Parent = table.Column<string>(nullable: false),
                    Code_Postale_Parent = table.Column<string>(nullable: false),
                    Telephone_Parent = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.Ref_Parent);
                });

            migrationBuilder.CreateTable(
                name: "Type_Lits",
                columns: table => new
                {
                    Numero_Type = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: false),
                    Cout = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_Lits", x => x.Numero_Type);
                });

            migrationBuilder.CreateTable(
                name: "patients",
                columns: table => new
                {
                    NSS = table.Column<string>(nullable: false),
                    Date_Naissance_Patient = table.Column<DateTime>(nullable: false),
                    Nom_Patient = table.Column<string>(maxLength: 50, nullable: true),
                    Prenom_Patient = table.Column<string>(maxLength: 50, nullable: true),
                    Adresse_Patient = table.Column<string>(nullable: false),
                    Ville_Patient = table.Column<string>(nullable: false),
                    Province_Patient = table.Column<string>(nullable: false),
                    Code_Postale_Patient = table.Column<string>(nullable: false),
                    Telephone_Patient = table.Column<string>(nullable: false),
                    Id_Medecin = table.Column<string>(nullable: true),
                    Id_Compagnie = table.Column<int>(nullable: false),
                    Ref_Parent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patients", x => x.NSS);
                    table.ForeignKey(
                        name: "FK_patients_assurances_Id_Compagnie",
                        column: x => x.Id_Compagnie,
                        principalTable: "assurances",
                        principalColumn: "Id_Compagnie",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_patients_medecins_Id_Medecin",
                        column: x => x.Id_Medecin,
                        principalTable: "medecins",
                        principalColumn: "Id_Medecin",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_patients_parents_Ref_Parent",
                        column: x => x.Ref_Parent,
                        principalTable: "parents",
                        principalColumn: "Ref_Parent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lits",
                columns: table => new
                {
                    Numero_Lit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Occupe = table.Column<string>(nullable: false),
                    Numero_Type = table.Column<int>(nullable: false),
                    Id_Departement = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lits", x => x.Numero_Lit);
                    table.ForeignKey(
                        name: "FK_lits_departements_Id_Departement",
                        column: x => x.Id_Departement,
                        principalTable: "departements",
                        principalColumn: "Id_Departement",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lits_Type_Lits_Numero_Type",
                        column: x => x.Numero_Type,
                        principalTable: "Type_Lits",
                        principalColumn: "Numero_Type",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dossier_Admissions",
                columns: table => new
                {
                    Id_Admission = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Chirugie_Programme = table.Column<string>(nullable: false),
                    Date_Admission = table.Column<DateTime>(nullable: false),
                    Date_Chirugie = table.Column<DateTime>(nullable: false),
                    Date_Conge = table.Column<DateTime>(nullable: false),
                    NSS = table.Column<string>(nullable: true),
                    Numero_Lit = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dossier_Admissions", x => x.Id_Admission);
                    table.ForeignKey(
                        name: "FK_dossier_Admissions_patients_NSS",
                        column: x => x.NSS,
                        principalTable: "patients",
                        principalColumn: "NSS",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_dossier_Admissions_lits_Numero_Lit",
                        column: x => x.Numero_Lit,
                        principalTable: "lits",
                        principalColumn: "Numero_Lit",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "commodite_Admissions",
                columns: table => new
                {
                    Id_Admission = table.Column<int>(nullable: false),
                    Id_Commodite = table.Column<int>(nullable: false),
                    Commodites_ExtraId_Commodites = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commodite_Admissions", x => new { x.Id_Admission, x.Id_Commodite });
                    table.ForeignKey(
                        name: "FK_commodite_Admissions_commodites_Extras_Commodites_ExtraId_Commodites",
                        column: x => x.Commodites_ExtraId_Commodites,
                        principalTable: "commodites_Extras",
                        principalColumn: "Id_Commodites",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_commodite_Admissions_dossier_Admissions_Id_Admission",
                        column: x => x.Id_Admission,
                        principalTable: "dossier_Admissions",
                        principalColumn: "Id_Admission",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "factures",
                columns: table => new
                {
                    Num_Facture = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date_Facture = table.Column<DateTime>(nullable: false),
                    Montant_Facture = table.Column<double>(nullable: false),
                    Id_Admission = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_factures", x => x.Num_Facture);
                    table.ForeignKey(
                        name: "FK_factures_dossier_Admissions_Id_Admission",
                        column: x => x.Id_Admission,
                        principalTable: "dossier_Admissions",
                        principalColumn: "Id_Admission",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_commodite_Admissions_Commodites_ExtraId_Commodites",
                table: "commodite_Admissions",
                column: "Commodites_ExtraId_Commodites");

            migrationBuilder.CreateIndex(
                name: "IX_dossier_Admissions_NSS",
                table: "dossier_Admissions",
                column: "NSS");

            migrationBuilder.CreateIndex(
                name: "IX_dossier_Admissions_Numero_Lit",
                table: "dossier_Admissions",
                column: "Numero_Lit");

            migrationBuilder.CreateIndex(
                name: "IX_factures_Id_Admission",
                table: "factures",
                column: "Id_Admission");

            migrationBuilder.CreateIndex(
                name: "IX_lits_Id_Departement",
                table: "lits",
                column: "Id_Departement");

            migrationBuilder.CreateIndex(
                name: "IX_lits_Numero_Type",
                table: "lits",
                column: "Numero_Type");

            migrationBuilder.CreateIndex(
                name: "IX_patients_Id_Compagnie",
                table: "patients",
                column: "Id_Compagnie");

            migrationBuilder.CreateIndex(
                name: "IX_patients_Id_Medecin",
                table: "patients",
                column: "Id_Medecin");

            migrationBuilder.CreateIndex(
                name: "IX_patients_Ref_Parent",
                table: "patients",
                column: "Ref_Parent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "commodite_Admissions");

            migrationBuilder.DropTable(
                name: "factures");

            migrationBuilder.DropTable(
                name: "commodites_Extras");

            migrationBuilder.DropTable(
                name: "dossier_Admissions");

            migrationBuilder.DropTable(
                name: "patients");

            migrationBuilder.DropTable(
                name: "lits");

            migrationBuilder.DropTable(
                name: "assurances");

            migrationBuilder.DropTable(
                name: "medecins");

            migrationBuilder.DropTable(
                name: "parents");

            migrationBuilder.DropTable(
                name: "departements");

            migrationBuilder.DropTable(
                name: "Type_Lits");
        }
    }
}
