using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class forainkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_AllUser_Dean_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "id",
                table: "LeaveHistory");

            migrationBuilder.RenameColumn(
                name: "Dean_id",
                table: "LeaveHistory",
                newName: "AllUserid");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistory_Dean_id",
                table: "LeaveHistory",
                newName: "IX_LeaveHistory_AllUserid");

            migrationBuilder.CreateTable(
                name: "LeaveRequest",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveStartFrome = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveEndTill = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequest", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_AllUser_AllUserid",
                table: "LeaveHistory",
                column: "AllUserid",
                principalTable: "AllUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_AllUser_AllUserid",
                table: "LeaveHistory");

            migrationBuilder.DropTable(
                name: "LeaveRequest");

            migrationBuilder.RenameColumn(
                name: "AllUserid",
                table: "LeaveHistory",
                newName: "Dean_id");

            migrationBuilder.RenameIndex(
                name: "IX_LeaveHistory_AllUserid",
                table: "LeaveHistory",
                newName: "IX_LeaveHistory_Dean_id");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_AllUser_Dean_id",
                table: "LeaveHistory",
                column: "Dean_id",
                principalTable: "AllUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
