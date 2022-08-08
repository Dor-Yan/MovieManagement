using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManagement.Persistance.Migrations
{
    public partial class configuartion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DirectorName_LastName",
                table: "Directors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "DirectorName_FirstName",
                table: "Directors",
                newName: "FirstName");

            migrationBuilder.AlterColumn<int>(
                name: "PremiereYear",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 2000,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 7, 11, 11, 12, 211, DateTimeKind.Local).AddTicks(9474));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Directors",
                newName: "DirectorName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Directors",
                newName: "DirectorName_FirstName");

            migrationBuilder.AlterColumn<int>(
                name: "PremiereYear",
                table: "Movies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.UpdateData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 8, 6, 20, 19, 47, 102, DateTimeKind.Local).AddTicks(5829));
        }
    }
}
