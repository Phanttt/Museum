using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class TableRenamed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditMuseumInfo");

            migrationBuilder.CreateTable(
                name: "EditInsideInfo",
                columns: table => new
                {
                    editsid = table.Column<int>(type: "int", nullable: false),
                    editsid1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditInsideInfo", x => new { x.editsid, x.editsid1 });
                    table.ForeignKey(
                        name: "FK_EditInsideInfo_Edits_editsid",
                        column: x => x.editsid,
                        principalTable: "Edits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditInsideInfo_MuseumInfos_editsid1",
                        column: x => x.editsid1,
                        principalTable: "MuseumInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditInsideInfo_editsid1",
                table: "EditInsideInfo",
                column: "editsid1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditInsideInfo");

            migrationBuilder.CreateTable(
                name: "EditMuseumInfo",
                columns: table => new
                {
                    editsid = table.Column<int>(type: "int", nullable: false),
                    editsid1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditMuseumInfo", x => new { x.editsid, x.editsid1 });
                    table.ForeignKey(
                        name: "FK_EditMuseumInfo_Edits_editsid",
                        column: x => x.editsid,
                        principalTable: "Edits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditMuseumInfo_MuseumInfos_editsid1",
                        column: x => x.editsid1,
                        principalTable: "MuseumInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditMuseumInfo_editsid1",
                table: "EditMuseumInfo",
                column: "editsid1");
        }
    }
}
