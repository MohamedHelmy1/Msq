using Microsoft.EntityFrameworkCore.Migrations;

namespace Batabase.Migrations
{
    public partial class sacand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ids",
                table: "UserStanderFils",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ids",
                table: "UserStanderFils");
        }
    }
}
