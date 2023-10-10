using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class changedRefsInMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_Medias_Mediaid",
                table: "Audios");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Medias_Mediaid",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Medias_Mediaid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Medias_Mediaid",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "Videos",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_Mediaid",
                table: "Videos",
                newName: "IX_Videos_MediaId");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "Images",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_Mediaid",
                table: "Images",
                newName: "IX_Images_MediaId");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "Documents",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_Mediaid",
                table: "Documents",
                newName: "IX_Documents_MediaId");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "Audios",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_Audios_Mediaid",
                table: "Audios",
                newName: "IX_Audios_MediaId");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Videos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "data",
                table: "Images",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Documents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Audios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_Medias_MediaId",
                table: "Audios",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Medias_MediaId",
                table: "Documents",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Medias_MediaId",
                table: "Images",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Medias_MediaId",
                table: "Videos",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_Medias_MediaId",
                table: "Audios");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Medias_MediaId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Medias_MediaId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Videos_Medias_MediaId",
                table: "Videos");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Videos",
                newName: "Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_Videos_MediaId",
                table: "Videos",
                newName: "IX_Videos_Mediaid");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Images",
                newName: "Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_Images_MediaId",
                table: "Images",
                newName: "IX_Images_Mediaid");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Documents",
                newName: "Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_MediaId",
                table: "Documents",
                newName: "IX_Documents_Mediaid");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "Audios",
                newName: "Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_Audios_MediaId",
                table: "Audios",
                newName: "IX_Audios_Mediaid");

            migrationBuilder.AlterColumn<int>(
                name: "Mediaid",
                table: "Videos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte[]>(
                name: "data",
                table: "Images",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Mediaid",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Mediaid",
                table: "Documents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Mediaid",
                table: "Audios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_Images_Medias_Mediaid",
                table: "Images",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Videos_Medias_Mediaid",
                table: "Videos",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");
        }
    }
}
