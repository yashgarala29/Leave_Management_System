using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class forainkey2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_AllUser_AllUserid",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_AllUserid",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "AllUserid",
                table: "LeaveHistory");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_id",
                table: "LeaveHistory",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_AllUser_id",
                table: "LeaveHistory",
                column: "id",
                principalTable: "AllUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_AllUser_id",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "id",
                table: "LeaveHistory");

            migrationBuilder.AddColumn<int>(
                name: "AllUserid",
                table: "LeaveHistory",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_AllUserid",
                table: "LeaveHistory",
                column: "AllUserid");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_AllUser_AllUserid",
                table: "LeaveHistory",
                column: "AllUserid",
                principalTable: "AllUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
