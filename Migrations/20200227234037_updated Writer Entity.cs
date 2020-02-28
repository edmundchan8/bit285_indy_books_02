using Microsoft.EntityFrameworkCore.Migrations;

namespace IndyBooks.Migrations
{
    public partial class updatedWriterEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Writers");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Writers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Writers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Writers");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Writers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
