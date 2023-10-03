using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRef4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptanceMaterial");

            migrationBuilder.AddColumn<int>(
                name: "Acceptanceid",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_Acceptanceid",
                table: "Materials",
                column: "Acceptanceid");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Acceptances_Acceptanceid",
                table: "Materials",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Acceptances_Acceptanceid",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_Acceptanceid",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "Acceptanceid",
                table: "Materials");

            migrationBuilder.CreateTable(
                name: "AcceptanceMaterial",
                columns: table => new
                {
                    acceptancesid = table.Column<int>(type: "int", nullable: false),
                    materialsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptanceMaterial", x => new { x.acceptancesid, x.materialsId });
                    table.ForeignKey(
                        name: "FK_AcceptanceMaterial_Acceptances_acceptancesid",
                        column: x => x.acceptancesid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcceptanceMaterial_Materials_materialsId",
                        column: x => x.materialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptanceMaterial_materialsId",
                table: "AcceptanceMaterial",
                column: "materialsId");
        }
    }
}
