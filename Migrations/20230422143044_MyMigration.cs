using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Custodians",
                columns: table => new
                {
                    TcNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    IsCustodian = table.Column<bool>(type: "bit", nullable: false),
                    IsFather = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<int>(type: "int", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentsLiveTogether = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custodians", x => x.TcNo);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    TcNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmergencyId = table.Column<int>(type: "int", nullable: false),
                    IsFatherAlive = table.Column<bool>(type: "bit", nullable: false),
                    IsMotherAlive = table.Column<bool>(type: "bit", nullable: false),
                    CustodianId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<int>(type: "int", nullable: true),
                    StudentGrade = table.Column<int>(type: "int", nullable: false),
                    StudentClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthPlaceAndYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentGender = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.TcNo);
                    table.ForeignKey(
                        name: "FK_Students_Custodians_CustodianId",
                        column: x => x.CustodianId,
                        principalTable: "Custodians",
                        principalColumn: "TcNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Emergencies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relativity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<int>(type: "int", nullable: false),
                    EmergencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencies", x => x.id);
                    table.ForeignKey(
                        name: "FK_Emergencies_Students_EmergencyId",
                        column: x => x.EmergencyId,
                        principalTable: "Students",
                        principalColumn: "TcNo");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emergencies_EmergencyId",
                table: "Emergencies",
                column: "EmergencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CustodianId",
                table: "Students",
                column: "CustodianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emergencies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Custodians");
        }
    }
}
