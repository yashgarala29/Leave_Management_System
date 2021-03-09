using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class ApprovedId_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "approved_id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "listofleaveallocation",
                columns: table => new
                {
                    AllocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoOfLeave = table.Column<int>(type: "int", nullable: false),
                    leavetype = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_listofleaveallocation", x => x.AllocationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "listofleaveallocation");

            migrationBuilder.DropColumn(
                name: "approved_id",
                table: "LeaveHistory");
        }
    }
}
