using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieManagement.Persistance.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Created", "CreatedBy", "Inactivated", "InactivatedBy", "Modified", "ModifiedBy", "StatusId", "DirectorName_FirstName", "DirectorName_LastName" },
                values: new object[] { 1, new DateTime(2022, 8, 6, 20, 19, 47, 102, DateTimeKind.Local).AddTicks(5829), "Dorian", null, null, null, null, 1, "Andrzej", "Wajda" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorId", "Name", "PremiereYear" },
                values: new object[] { 1, 1, "Pan Tadeusz", 0 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DirectorId", "Name", "PremiereYear" },
                values: new object[] { 2, 1, "Popiół i Diament", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InactivatedBy",
                table: "Directors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
