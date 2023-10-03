using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_GeneralInfo_GeneralInfoid",
                table: "Images");

            migrationBuilder.DropTable(
                name: "BtwMatAccs");

            migrationBuilder.DropTable(
                name: "BtwStatAccs");

            migrationBuilder.DropTable(
                name: "BtwTecAccs");

            migrationBuilder.DropIndex(
                name: "IX_Images_GeneralInfoid",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "GeneralInfoid",
                table: "Images");

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

            migrationBuilder.AddColumn<string>(
                name: "title",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "title",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "GeneralInfoid",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BtwMatAccs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acceptanceid = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtwMatAccs", x => x.id);
                    table.ForeignKey(
                        name: "FK_BtwMatAccs_Acceptances_Acceptanceid",
                        column: x => x.Acceptanceid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BtwMatAccs_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BtwStatAccs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acceptanceid = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtwStatAccs", x => x.id);
                    table.ForeignKey(
                        name: "FK_BtwStatAccs_Acceptances_Acceptanceid",
                        column: x => x.Acceptanceid,
                        principalTable: "Acceptances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BtwStatAccs_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BtwTecAccs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acceptanceid = table.Column<int>(type: "int", nullable: true),
                    TechniqueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BtwTecAccs", x => x.id);
                    table.ForeignKey(
                        name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                        column: x => x.Acceptanceid,
                        principalTable: "Acceptances",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_BtwTecAccs_Techniques_TechniqueId",
                        column: x => x.TechniqueId,
                        principalTable: "Techniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_GeneralInfoid",
                table: "Images",
                column: "GeneralInfoid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwMatAccs_Acceptanceid",
                table: "BtwMatAccs",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwMatAccs_MaterialId",
                table: "BtwMatAccs",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_BtwStatAccs_Acceptanceid",
                table: "BtwStatAccs",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwStatAccs_StateId",
                table: "BtwStatAccs",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_BtwTecAccs_Acceptanceid",
                table: "BtwTecAccs",
                column: "Acceptanceid");

            migrationBuilder.CreateIndex(
                name: "IX_BtwTecAccs_TechniqueId",
                table: "BtwTecAccs",
                column: "TechniqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_GeneralInfo_GeneralInfoid",
                table: "Images",
                column: "GeneralInfoid",
                principalTable: "GeneralInfo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
