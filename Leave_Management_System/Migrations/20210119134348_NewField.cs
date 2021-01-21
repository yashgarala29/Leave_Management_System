using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Leave_Management_System.Migrations
{
    public partial class NewField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Deparment",
                table: "Registrar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Registrar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreeLeave",
                table: "Registrar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Registrar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNo",
                table: "Registrar",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DeanApproveStatus",
                table: "LeaveHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTill",
                table: "LeaveHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HODApproveStatus",
                table: "LeaveHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaveReason",
                table: "LeaveHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LeaveStatus",
                table: "LeaveHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoOfDay",
                table: "LeaveHistory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RegistrarApproveStatus",
                table: "LeaveHistory",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartFrome",
                table: "LeaveHistory",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Deparment",
                table: "HOD",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "HOD",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreeLeave",
                table: "HOD",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "HOD",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNo",
                table: "HOD",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Deparment",
                table: "Faculty",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Faculty",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreeLeave",
                table: "Faculty",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Faculty",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNo",
                table: "Faculty",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Deparment",
                table: "Dean",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Dean",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FreeLeave",
                table: "Dean",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Dean",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNo",
                table: "Dean",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deparment",
                table: "Registrar");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Registrar");

            migrationBuilder.DropColumn(
                name: "FreeLeave",
                table: "Registrar");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Registrar");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "Registrar");

            migrationBuilder.DropColumn(
                name: "DeanApproveStatus",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "EndTill",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "HODApproveStatus",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "LeaveReason",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "LeaveStatus",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "NoOfDay",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "RegistrarApproveStatus",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "StartFrome",
                table: "LeaveHistory");

            migrationBuilder.DropColumn(
                name: "Deparment",
                table: "HOD");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "HOD");

            migrationBuilder.DropColumn(
                name: "FreeLeave",
                table: "HOD");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "HOD");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "HOD");

            migrationBuilder.DropColumn(
                name: "Deparment",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "FreeLeave",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "Deparment",
                table: "Dean");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Dean");

            migrationBuilder.DropColumn(
                name: "FreeLeave",
                table: "Dean");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Dean");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "Dean");
        }
    }
}
