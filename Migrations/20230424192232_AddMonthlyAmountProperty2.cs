using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    /// <inheritdoc />
    public partial class AddMonthlyAmountProperty2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emergencies_Students_EmergencyId",
                table: "Emergencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Students_StudentId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Students_PaymentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Payment_StudentId",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "EmergencyId",
                table: "Emergencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Emergencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_PaymentId",
                table: "Students",
                column: "PaymentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Emergencies_Students_EmergencyId",
                table: "Emergencies",
                column: "EmergencyId",
                principalTable: "Students",
                principalColumn: "TcNo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emergencies_Students_EmergencyId",
                table: "Emergencies");

            migrationBuilder.DropIndex(
                name: "IX_Students_PaymentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Emergencies");

            migrationBuilder.AlterColumn<int>(
                name: "EmergencyId",
                table: "Emergencies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Students_PaymentId",
                table: "Students",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_StudentId",
                table: "Payment",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emergencies_Students_EmergencyId",
                table: "Emergencies",
                column: "EmergencyId",
                principalTable: "Students",
                principalColumn: "TcNo");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Students_StudentId",
                table: "Payment",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "TcNo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
