using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    /// <inheritdoc />
    public partial class LittleChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Cash",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "CreditCard",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IncludeFood",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Transfer",
                table: "students",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cash",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CreditCard",
                table: "students");

            migrationBuilder.DropColumn(
                name: "IncludeFood",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Transfer",
                table: "students");
        }
    }
}
