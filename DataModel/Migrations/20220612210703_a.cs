using Microsoft.EntityFrameworkCore.Migrations;

namespace Batabase.Migrations
{
    public partial class a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Standard",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StanderQueqsion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Queqsion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_Standard = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StanderQueqsion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StanderQueqsion_Standard_Fk_Standard",
                        column: x => x.Fk_Standard,
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StanderQueqsion_Fk_Standard",
                table: "StanderQueqsion",
                column: "Fk_Standard");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StanderQueqsion");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Standard");
        }
    }
}
