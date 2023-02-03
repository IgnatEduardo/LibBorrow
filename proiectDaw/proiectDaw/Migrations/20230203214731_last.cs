using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proiectDaw.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bppls_Authors_AuthorId",
                table: "Bppls");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBookRelation_Bppls_BookId",
                table: "UserBookRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bppls",
                table: "Bppls");

            migrationBuilder.RenameTable(
                name: "Bppls",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Bppls_AuthorId",
                table: "Books",
                newName: "IX_Books_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookRelation_Books_BookId",
                table: "UserBookRelation",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBookRelation_Books_BookId",
                table: "UserBookRelation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Bppls");

            migrationBuilder.RenameIndex(
                name: "IX_Books_AuthorId",
                table: "Bppls",
                newName: "IX_Bppls_AuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bppls",
                table: "Bppls",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bppls_Authors_AuthorId",
                table: "Bppls",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBookRelation_Bppls_BookId",
                table: "UserBookRelation",
                column: "BookId",
                principalTable: "Bppls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
