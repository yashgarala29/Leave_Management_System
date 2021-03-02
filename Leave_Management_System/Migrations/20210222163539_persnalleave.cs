using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class persnalleave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "itispersonal",
                table: "leaveType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "leaveTypeID",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistory_leaveTypeID",
                table: "LeaveHistory",
                column: "leaveTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_leaveType_leaveTypeID",
                table: "LeaveHistory",
                column: "leaveTypeID",
                principalTable: "leaveType",
                principalColumn: "leaveTypeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_leaveType_leaveTypeID",
                table: "LeaveHistory");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_leaveTypeID",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "itispersonal",
                table: "leaveType");

            migrationBuilder.DropColumn(
                name: "leaveTypeID",
                table: "LeaveHistory");
        }
    }
}
