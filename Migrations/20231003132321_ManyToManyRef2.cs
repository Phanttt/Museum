using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRef2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Acceptances_Acceptanceid",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Acceptances_Acceptanceid",
                table: "States");

            migrationBuilder.DropForeignKey(
                name: "FK_Techniques_Acceptances_Acceptanceid",
                table: "Techniques");

            migrationBuilder.DropIndex(
                name: "IX_Techniques_Acceptanceid",
                table: "Techniques");

            migrationBuilder.DropIndex(
                name: "IX_States_Acceptanceid",
                table: "States");

            migrationBuilder.DropIndex(
                name: "IX_Materials_Acceptanceid",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "Acceptanceid",
                table: "Techniques");

            migrationBuilder.DropColumn(
                name: "Acceptanceid",
                table: "States");

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

            migrationBuilder.CreateTable(
                name: "AcceptanceState",
                columns: table => new
                {
                    acceptancesid = table.Column<int>(type: "int", nullable: false),
                    statesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptanceState", x => new { x.acceptancesid, x.statesId });
                    table.ForeignKey(
                        name: "FK_AcceptanceState_Acceptances_acceptancesid",
                        column: x => x.acceptancesid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcceptanceState_States_statesId",
                        column: x => x.statesId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcceptanceTechnique",
                columns: table => new
                {
                    acceptancesid = table.Column<int>(type: "int", nullable: false),
                    techniquesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptanceTechnique", x => new { x.acceptancesid, x.techniquesId });
                    table.ForeignKey(
                        name: "FK_AcceptanceTechnique_Acceptances_acceptancesid",
                        column: x => x.acceptancesid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcceptanceTechnique_Techniques_techniquesId",
                        column: x => x.techniquesId,
                        principalTable: "Techniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptanceMaterial_materialsId",
                table: "AcceptanceMaterial",
                column: "materialsId");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptanceState_statesId",
                table: "AcceptanceState",
                column: "statesId");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptanceTechnique_techniquesId",
                table: "AcceptanceTechnique",
                column: "techniquesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptanceMaterial");

            migrationBuilder.DropTable(
                name: "AcceptanceState");

            migrationBuilder.DropTable(
                name: "AcceptanceTechnique");

            migrationBuilder.AddColumn<int>(
                name: "Acceptanceid",
                table: "Techniques",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Acceptanceid",
                table: "States",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Acceptanceid",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Techniques_Acceptanceid",
                table: "Techniques",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_States_Acceptanceid",
                table: "States",
                column: "Acceptanceid");

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

            migrationBuilder.AddForeignKey(
                name: "FK_States_Acceptances_Acceptanceid",
                table: "States",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Techniques_Acceptances_Acceptanceid",
                table: "Techniques",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id");
        }
    }
}
