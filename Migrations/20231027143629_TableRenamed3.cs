using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class TableRenamed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_InsideInfos_MuseumInfoid",
                table: "UnifPassports");

            migrationBuilder.RenameColumn(
                name: "MuseumInfoid",
                table: "UnifPassports",
                newName: "InsideInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_MuseumInfoid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_InsideInfoid");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_InsideInfos_InsideInfoid",
                table: "UnifPassports",
                column: "InsideInfoid",
                principalTable: "InsideInfos",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_InsideInfos_InsideInfoid",
                table: "UnifPassports");

            migrationBuilder.RenameColumn(
                name: "InsideInfoid",
                table: "UnifPassports",
                newName: "MuseumInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_InsideInfoid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_MuseumInfoid");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_InsideInfos_MuseumInfoid",
                table: "UnifPassports",
                column: "MuseumInfoid",
                principalTable: "InsideInfos",
                principalColumn: "id");
        }
    }
}
