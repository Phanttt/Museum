using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class fkeyscreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoid",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Medias_Mediaid",
                table: "UnifPassports");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "UnifPassports",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_Mediaid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_MediaId");

            migrationBuilder.RenameColumn(
                name: "GeneralInfoid",
                table: "Medias",
                newName: "GeneralInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_GeneralInfoid",
                table: "Medias",
                newName: "IX_Medias_GeneralInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoId",
                table: "Medias",
                column: "GeneralInfoId",
                principalTable: "GeneralInfo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Medias_MediaId",
                table: "UnifPassports",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoId",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Medias_MediaId",
                table: "UnifPassports");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "UnifPassports",
                newName: "Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_MediaId",
                table: "UnifPassports",
                newName: "IX_UnifPassports_Mediaid");

            migrationBuilder.RenameColumn(
                name: "GeneralInfoId",
                table: "Medias",
                newName: "GeneralInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_GeneralInfoId",
                table: "Medias",
                newName: "IX_Medias_GeneralInfoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoid",
                table: "Medias",
                column: "GeneralInfoid",
                principalTable: "GeneralInfo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Medias_Mediaid",
                table: "UnifPassports",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");
        }
    }
}
