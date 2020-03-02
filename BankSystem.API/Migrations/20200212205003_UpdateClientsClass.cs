using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankSystem.API.Migrations
{
    public partial class UpdateClientsClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Disability",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disability", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivingPlaceCities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivingPlaceCities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResidencePermitCity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidencePermitCity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Patronymic = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Sex = table.Column<bool>(nullable: false),
                    PassportSerie = table.Column<string>(nullable: true),
                    PassportNumber = table.Column<string>(nullable: true),
                    IssuancePlace = table.Column<string>(nullable: true),
                    IssuanceDate = table.Column<DateTime>(nullable: false),
                    IdPassportNumber = table.Column<string>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    LivingPlaceCityId = table.Column<int>(nullable: true),
                    LivingPlaceAddress = table.Column<string>(nullable: true),
                    HomePhoneNumber = table.Column<string>(nullable: true),
                    MobilePhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ResidencePermitCityId = table.Column<int>(nullable: true),
                    MaritalStatusId = table.Column<int>(nullable: true),
                    NationalityId = table.Column<int>(nullable: true),
                    DisabilityId = table.Column<int>(nullable: true),
                    Retired = table.Column<bool>(nullable: false),
                    MoneyIncome = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Disability_DisabilityId",
                        column: x => x.DisabilityId,
                        principalTable: "Disability",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_LivingPlaceCities_LivingPlaceCityId",
                        column: x => x.LivingPlaceCityId,
                        principalTable: "LivingPlaceCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_MaritalStatus_MaritalStatusId",
                        column: x => x.MaritalStatusId,
                        principalTable: "MaritalStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_Nationality_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clients_ResidencePermitCity_ResidencePermitCityId",
                        column: x => x.ResidencePermitCityId,
                        principalTable: "ResidencePermitCity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_DisabilityId",
                table: "Clients",
                column: "DisabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_LivingPlaceCityId",
                table: "Clients",
                column: "LivingPlaceCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_MaritalStatusId",
                table: "Clients",
                column: "MaritalStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_NationalityId",
                table: "Clients",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ResidencePermitCityId",
                table: "Clients",
                column: "ResidencePermitCityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Disability");

            migrationBuilder.DropTable(
                name: "LivingPlaceCities");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropTable(
                name: "Nationality");

            migrationBuilder.DropTable(
                name: "ResidencePermitCity");
        }
    }
}
