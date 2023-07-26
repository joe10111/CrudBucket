using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudBucketMVC.Migrations
{
    /// <inheritdoc />
    public partial class videoModelSimplfy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "videos");

            migrationBuilder.DropColumn(
                name: "length",
                table: "videos");

            migrationBuilder.DropColumn(
                name: "upload_date",
                table: "videos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "videos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "length",
                table: "videos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "upload_date",
                table: "videos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
