using Microsoft.EntityFrameworkCore.Migrations;

namespace Batabase.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catogery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catogery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "subCatogery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_Catogery = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subCatogery", x => x.id);
                    table.ForeignKey(
                        name: "FK_subCatogery_Catogery_Fk_Catogery",
                        column: x => x.Fk_Catogery,
                        principalTable: "Catogery",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Standard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_SubCatogery = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Standard_subCatogery_Fk_SubCatogery",
                        column: x => x.Fk_SubCatogery,
                        principalTable: "subCatogery",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Standerd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_Standard = table.Column<int>(type: "int", nullable: true),
                    Fk_User = table.Column<int>(type: "int", nullable: true),
                    Fk_Teacher = table.Column<int>(type: "int", nullable: true),
                    DalilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pointOfStrong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChosetoImprove = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Standerd", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Standerd_Standard_Fk_Standard",
                        column: x => x.Fk_Standard,
                        principalTable: "Standard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Standerd_user_Fk_Teacher",
                        column: x => x.Fk_Teacher,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Standerd_user_Fk_User",
                        column: x => x.Fk_User,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserStanderFils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fk_UserStander = table.Column<int>(type: "int", nullable: true)
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
                name: "IX_Standard_Fk_SubCatogery",
                table: "Standard",
                column: "Fk_SubCatogery");

            migrationBuilder.CreateIndex(
                name: "IX_subCatogery_Fk_Catogery",
                table: "subCatogery",
                column: "Fk_Catogery");

            migrationBuilder.CreateIndex(
                name: "IX_User_Standerd_Fk_Standard",
                table: "User_Standerd",
                column: "Fk_Standard");

            migrationBuilder.CreateIndex(
                name: "IX_User_Standerd_Fk_Teacher",
                table: "User_Standerd",
                column: "Fk_Teacher");

            migrationBuilder.CreateIndex(
                name: "IX_User_Standerd_Fk_User",
                table: "User_Standerd",
                column: "Fk_User");

            migrationBuilder.CreateIndex(
                name: "IX_UserStanderFils_Fk_UserStander",
                table: "UserStanderFils",
                column: "Fk_UserStander");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserStanderFils");

            migrationBuilder.DropTable(
                name: "User_Standerd");

            migrationBuilder.DropTable(
                name: "Standard");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "subCatogery");

            migrationBuilder.DropTable(
                name: "Catogery");
        }
    }
}
