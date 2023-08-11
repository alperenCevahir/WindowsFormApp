using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    /// <inheritdoc />
    public partial class PaidInstallmentUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaidInstallment",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaidInstallment",
                table: "students");
        }
    }
}
