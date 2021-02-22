using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class bigchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Dean");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "HOD");

            migrationBuilder.DropTable(
                name: "Registrar");

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
                name: "Faculty_id",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "HOD_id",
                table: "LeaveHistory");

            migrationBuilder.RenameColumn(
                name: "Registrar_id",
                table: "LeaveHistory",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Dean_id",
                table: "LeaveHistory",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "AllUser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    MobileNo2 = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addreaddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaidLeave = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllUser", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LeaveHistory_AllUser_Dean_id",
                table: "LeaveHistory",
                column: "Dean_id",
                principalTable: "AllUser",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LeaveHistory_AllUser_Dean_id",
                table: "LeaveHistory");

            migrationBuilder.DropTable(
                name: "AllUser");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "LeaveHistory",
                newName: "Registrar_id");

            migrationBuilder.AlterColumn<int>(
                name: "Dean_id",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.CreateTable(
                name: "Dean",
                columns: table => new
                {
                    Dean_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeLeave = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dean", x => x.Dean_id);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Faculty_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeLeave = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Faculty_id);
                });

            migrationBuilder.CreateTable(
                name: "HOD",
                columns: table => new
                {
                    HOD_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeLeave = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOD", x => x.HOD_id);
                });

            migrationBuilder.CreateTable(
                name: "Registrar",
                columns: table => new
                {
                    Registrar_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Deparment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreeLeave = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrar", x => x.Registrar_id);
                });

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
    }
}
