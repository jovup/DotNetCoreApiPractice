using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetCoreApiPractice.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Course",
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Department",
                defaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Person",
                defaultValueSql: "(getdate())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Person");
        }
    }
}
