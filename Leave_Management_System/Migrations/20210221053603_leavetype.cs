using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class leavetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acknowledgement",
                table: "LeaveHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "leaveTypeID",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "leaveType",
                columns: table => new
                {
                    leaveTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    allcatoToAll = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveType", x => x.leaveTypeID);
                });

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

            migrationBuilder.DropTable(
                name: "leaveType");

            migrationBuilder.DropIndex(
                name: "IX_LeaveHistory_leaveTypeID",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "Acknowledgement",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "leaveTypeID",
                table: "LeaveHistory");
        }
    }
}
