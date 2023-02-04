using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proiectDaw.Migrations
{
    /// <inheritdoc />
    public partial class finished : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBookRelation_Books_BookId",
                table: "UserBookRelation");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBookRelation_Users_UserId",
                table: "UserBookRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBookRelation",
                table: "UserBookRelation");

            migrationBuilder.DropColumn(
                name: "SubscriptionId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "UserBookRelation",
                newName: "UserBookRelations");

            migrationBuilder.RenameIndex(
                name: "IX_UserBookRelation_BookId",
                table: "UserBookRelations",
                newName: "IX_UserBookRelations_BookId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Subscriptions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Books",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Authors",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBookRelations",
                table: "UserBookRelations",
                columns: new[] { "UserId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookRelations_Books_BookId",
                table: "UserBookRelations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookRelations_Users_UserId",
                table: "UserBookRelations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBookRelations_Books_BookId",
                table: "UserBookRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBookRelations_Users_UserId",
                table: "UserBookRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBookRelations",
                table: "UserBookRelations");

            migrationBuilder.RenameTable(
                name: "UserBookRelations",
                newName: "UserBookRelation");

            migrationBuilder.RenameIndex(
                name: "IX_UserBookRelations_BookId",
                table: "UserBookRelation",
                newName: "IX_UserBookRelation_BookId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SubscriptionId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Subscriptions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreated",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBookRelation",
                table: "UserBookRelation",
                columns: new[] { "UserId", "BookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookRelation_Books_BookId",
                table: "UserBookRelation",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookRelation_Users_UserId",
                table: "UserBookRelation",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
