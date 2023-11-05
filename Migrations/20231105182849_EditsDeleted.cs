using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class EditsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditInsideInfo");

            migrationBuilder.DropTable(
                name: "Edits");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Edits",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edits", x => x.id);
                });

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
                        name: "FK_EditInsideInfo_InsideInfos_editsid1",
                        column: x => x.editsid1,
                        principalTable: "InsideInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditInsideInfo_editsid1",
                table: "EditInsideInfo",
                column: "editsid1");
        }
    }
}
