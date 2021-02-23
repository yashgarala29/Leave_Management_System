using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class noofday : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "noofday",
                table: "leaveType",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "noofday",
                table: "leaveType");
        }
    }
}
