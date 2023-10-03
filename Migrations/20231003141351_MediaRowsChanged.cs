using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class MediaRowsChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mediaId",
                table: "GeneralInfo");

            migrationBuilder.AddColumn<int>(
                name: "Mediaid",
                table: "Videos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GeneralInfoid",
                table: "Medias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mediaid",
                table: "Documents",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Mediaid",
                table: "Audios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Videos_Mediaid",
                table: "Videos",
                column: "Mediaid");

            migrationBuilder.CreateIndex(
                name: "IX_Medias_GeneralInfoid",
                table: "Medias",
                column: "GeneralInfoid");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_Mediaid",
                table: "Documents",
                column: "Mediaid");

            migrationBuilder.CreateIndex(
                name: "IX_Audios_Mediaid",
                table: "Audios",
                column: "Mediaid");

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_Medias_Mediaid",
                table: "Audios",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Medias_Mediaid",
                table: "Documents",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoid",
                table: "Medias",
                column: "GeneralInfoid",
                principalTable: "GeneralInfo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Medias_Mediaid",
                table: "Videos",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_Medias_Mediaid",
                table: "Audios");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Medias_Mediaid",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoid",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Medias_Mediaid",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Videos_Mediaid",
                table: "Videos");

            migrationBuilder.DropIndex(
                name: "IX_Medias_GeneralInfoid",
                table: "Medias");

            migrationBuilder.DropIndex(
                name: "IX_Documents_Mediaid",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Audios_Mediaid",
                table: "Audios");

            migrationBuilder.DropColumn(
                name: "Mediaid",
                table: "Videos");

            migrationBuilder.DropColumn(
                name: "GeneralInfoid",
                table: "Medias");

            migrationBuilder.DropColumn(
                name: "Mediaid",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Mediaid",
                table: "Audios");

            migrationBuilder.AddColumn<int>(
                name: "mediaId",
                table: "GeneralInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
