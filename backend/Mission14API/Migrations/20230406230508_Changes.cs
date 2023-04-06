using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission14API.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Movies",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Movies",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Movies",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "Edited",
                table: "Movies",
                newName: "edited");

            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Movies",
                newName: "director");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Movies",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "movieId");

            migrationBuilder.AlterColumn<string>(
                name: "edited",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "category",
                table: "Movies",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<string>(
                name: "lentTo",
                table: "Movies",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notes",
                table: "Movies",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lentTo",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "notes",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "Movies",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Movies",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Movies",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "edited",
                table: "Movies",
                newName: "Edited");

            migrationBuilder.RenameColumn(
                name: "director",
                table: "Movies",
                newName: "Director");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "Movies",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Movies",
                newName: "MovieId");

            migrationBuilder.AlterColumn<bool>(
                name: "Edited",
                table: "Movies",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
