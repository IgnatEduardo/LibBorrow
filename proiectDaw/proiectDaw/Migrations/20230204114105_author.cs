using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace proiectDaw.Migrations
{
    /// <inheritdoc />
    public partial class author : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfBooks",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Books",
                newName: "Author");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "NumOfBooks",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
