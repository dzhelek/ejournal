using Microsoft.EntityFrameworkCore.Migrations;

namespace EJournal.Data.Migrations
{
    public partial class Teacher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TEACHER",
                table: "Journal",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TEACHER",
                table: "Journal");
        }
    }
}
