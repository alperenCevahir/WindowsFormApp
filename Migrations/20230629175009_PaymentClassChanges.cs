using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    /// <inheritdoc />
    public partial class PaymentClassChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_payments_StudentId",
                table: "payments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_payments_students_StudentId",
                table: "payments",
                column: "StudentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_payments_students_StudentId",
                table: "payments");

            migrationBuilder.DropIndex(
                name: "IX_payments_StudentId",
                table: "payments");
        }
    }
}
