using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    /// <inheritdoc />
    public partial class initalMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentGrade = table.Column<int>(type: "int", nullable: false),
                    BirthPlaceAndYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diseases = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsFatherAlive = table.Column<bool>(type: "bit", nullable: false),
                    IsMotherAlive = table.Column<bool>(type: "bit", nullable: false),
                    MotherTc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherTc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherIsCustodian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherIsCustodian = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentsLiveTogether = table.Column<bool>(type: "bit", nullable: false),
                    MotherNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherNameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherTelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherTelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Installment = table.Column<int>(type: "int", nullable: false),
                    PaymentWeek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency1NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency1TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency1Relativity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency2NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency2TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency2Relativity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency3NameSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency3TelNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emergency3Relativity = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");
        }
    }
}
