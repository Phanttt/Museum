using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ReferencesChange : Migration
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
                name: "BtwMatAcc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    matId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    accId = table.Column<int>(type: "int", nullable: false),
                    Acceptanceid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtwMatAcc", x => x.id);
                    table.ForeignKey(
                        name: "FK_BtwMatAcc_Acceptances_Acceptanceid",
                        column: x => x.Acceptanceid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BtwMatAcc_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BtwStatAcc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    accId = table.Column<int>(type: "int", nullable: false),
                    Acceptanceid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtwStatAcc", x => x.id);
                    table.ForeignKey(
                        name: "FK_BtwStatAcc_Acceptances_Acceptanceid",
                        column: x => x.Acceptanceid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BtwStatAcc_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BtwTecAcc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tecId = table.Column<int>(type: "int", nullable: false),
                    TechniqueId = table.Column<int>(type: "int", nullable: false),
                    accId = table.Column<int>(type: "int", nullable: false),
                    Acceptanceid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtwTecAcc", x => x.id);
                    table.ForeignKey(
                        name: "FK_BtwTecAcc_Acceptances_Acceptanceid",
                        column: x => x.Acceptanceid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BtwTecAcc_Techniques_TechniqueId",
                        column: x => x.TechniqueId,
                        principalTable: "Techniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BtwMatAcc_Acceptanceid",
                table: "BtwMatAcc",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwMatAcc_MaterialId",
                table: "BtwMatAcc",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_BtwStatAcc_Acceptanceid",
                table: "BtwStatAcc",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwStatAcc_StateId",
                table: "BtwStatAcc",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_BtwTecAcc_Acceptanceid",
                table: "BtwTecAcc",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwTecAcc_TechniqueId",
                table: "BtwTecAcc",
                column: "TechniqueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BtwMatAcc");

            migrationBuilder.DropTable(
                name: "BtwStatAcc");

            migrationBuilder.DropTable(
                name: "BtwTecAcc");

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
