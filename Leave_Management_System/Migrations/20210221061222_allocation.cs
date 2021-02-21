using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class allocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "leaveAllocation",
                columns: table => new
                {
                    AllocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfLeave = table.Column<int>(type: "int", nullable: false),
                    id = table.Column<int>(type: "int", nullable: false),
                    leaveTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaveAllocation", x => x.AllocationID);
                    table.ForeignKey(
                        name: "FK_leaveAllocation_AllUser_id",
                        column: x => x.id,
                        principalTable: "AllUser",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_leaveAllocation_leaveType_leaveTypeID",
                        column: x => x.leaveTypeID,
                        principalTable: "leaveType",
                        principalColumn: "leaveTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_leaveAllocation_id",
                table: "leaveAllocation",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_leaveAllocation_leaveTypeID",
                table: "leaveAllocation",
                column: "leaveTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leaveAllocation");
        }
    }
}
