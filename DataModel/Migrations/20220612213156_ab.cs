using Microsoft.EntityFrameworkCore.Migrations;

namespace Batabase.Migrations
{
    public partial class ab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserStanderFils");

            migrationBuilder.AddColumn<string>(
                name: "file",
                table: "User_Standerd",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "file",
                table: "User_Standerd");

            migrationBuilder.CreateTable(
                name: "UserStanderFils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fk_UserStander = table.Column<int>(type: "int", nullable: true),
                    Ids = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStanderFils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserStanderFils_User_Standerd_Fk_UserStander",
                        column: x => x.Fk_UserStander,
                        principalTable: "User_Standerd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserStanderFils_Fk_UserStander",
                table: "UserStanderFils",
                column: "Fk_UserStander");
        }
    }
}
