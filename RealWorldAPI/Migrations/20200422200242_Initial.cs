using Microsoft.EntityFrameworkCore.Migrations;

namespace RealWorldAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fishing",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Place = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    IsLiked = table.Column<bool>(nullable: false),
                    IsCatch = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fishing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tackle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LureId = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tackle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tackle_Lure_LureId",
                        column: x => x.LureId,
                        principalTable: "Lure",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catch",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fish = table.Column<string>(nullable: true),
                    TackleId = table.Column<int>(nullable: false),
                    FishingId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catch_Fishing_FishingId",
                        column: x => x.FishingId,
                        principalTable: "Fishing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catch_Tackle_TackleId",
                        column: x => x.TackleId,
                        principalTable: "Tackle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catch_FishingId",
                table: "Catch",
                column: "FishingId");

            migrationBuilder.CreateIndex(
                name: "IX_Catch_TackleId",
                table: "Catch",
                column: "TackleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tackle_LureId",
                table: "Tackle",
                column: "LureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catch");

            migrationBuilder.DropTable(
                name: "Fishing");

            migrationBuilder.DropTable(
                name: "Tackle");

            migrationBuilder.DropTable(
                name: "Lure");
        }
    }
}
