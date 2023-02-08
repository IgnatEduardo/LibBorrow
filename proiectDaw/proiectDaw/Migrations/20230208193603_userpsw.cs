using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proiectDaw.Migrations
{
    /// <inheritdoc />
    public partial class userpsw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "UserBookRelations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "UserBookRelations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "UserBookRelations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "UserBookRelations");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "UserBookRelations");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserBookRelations");
        }
    }
}
