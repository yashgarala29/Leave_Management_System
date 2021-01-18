using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class ForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dean_id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Faculty_id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HOD_id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Registrar_id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_Dean_id",
                table: "LeaveHistory",
                column: "Dean_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_Faculty_id",
                table: "LeaveHistory",
                column: "Faculty_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_HOD_id",
                table: "LeaveHistory",
                column: "HOD_id");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_Registrar_id",
                table: "LeaveHistory",
                column: "Registrar_id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_Dean_Dean_id",
                table: "LeaveHistory",
                column: "Dean_id",
                principalTable: "Dean",
                principalColumn: "Dean_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_Faculty_Faculty_id",
                table: "LeaveHistory",
                column: "Faculty_id",
                principalTable: "Faculty",
                principalColumn: "Faculty_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_HOD_HOD_id",
                table: "LeaveHistory",
                column: "HOD_id",
                principalTable: "HOD",
                principalColumn: "HOD_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_Registrar_Registrar_id",
                table: "LeaveHistory",
                column: "Registrar_id",
                principalTable: "Registrar",
                principalColumn: "Registrar_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_Dean_Dean_id",
                table: "LeaveHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_Faculty_Faculty_id",
                table: "LeaveHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_HOD_HOD_id",
                table: "LeaveHistory");

            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_Registrar_Registrar_id",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_Dean_id",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_Faculty_id",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_HOD_id",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_Registrar_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "Dean_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "Faculty_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "HOD_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "Registrar_id",
                table: "LeaveHistory");
        }
    }
}
