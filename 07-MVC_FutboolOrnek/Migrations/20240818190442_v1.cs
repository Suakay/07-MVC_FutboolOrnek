using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _07_MVC_FutboolOrnek.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mevki",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mevki", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Takim",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeknikDirektörAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Takim", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Futbolcu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    TakimID = table.Column<int>(type: "int", nullable: false),
                    MevkiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futbolcu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Futbolcu_Mevki_MevkiID",
                        column: x => x.MevkiID,
                        principalTable: "Mevki",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Futbolcu_Takim_TakimID",
                        column: x => x.TakimID,
                        principalTable: "Takim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Futbolcu_MevkiID",
                table: "Futbolcu",
                column: "MevkiID");

            migrationBuilder.CreateIndex(
                name: "IX_Futbolcu_TakimID",
                table: "Futbolcu",
                column: "TakimID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Futbolcu");

            migrationBuilder.DropTable(
                name: "Mevki");

            migrationBuilder.DropTable(
                name: "Takim");
        }
    }
}
