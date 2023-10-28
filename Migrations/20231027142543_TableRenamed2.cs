using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class TableRenamed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EditInsideInfo_MuseumInfos_editsid1",
                table: "EditInsideInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_DataFiles_Filesid",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_Exhibitions_Exhibitionid",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_MuseumInfos_MuseumInfoid",
                table: "UnifPassports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MuseumInfos",
                table: "MuseumInfos");

            migrationBuilder.RenameTable(
                name: "MuseumInfos",
                newName: "InsideInfos");

            migrationBuilder.RenameIndex(
                name: "IX_MuseumInfos_Filesid",
                table: "InsideInfos",
                newName: "IX_InsideInfos_Filesid");

            migrationBuilder.RenameIndex(
                name: "IX_MuseumInfos_Exhibitionid",
                table: "InsideInfos",
                newName: "IX_InsideInfos_Exhibitionid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsideInfos",
                table: "InsideInfos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EditInsideInfo_InsideInfos_editsid1",
                table: "EditInsideInfo",
                column: "editsid1",
                principalTable: "InsideInfos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsideInfos_DataFiles_Filesid",
                table: "InsideInfos",
                column: "Filesid",
                principalTable: "DataFiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos",
                column: "Exhibitionid",
                principalTable: "Exhibitions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_InsideInfos_MuseumInfoid",
                table: "UnifPassports",
                column: "MuseumInfoid",
                principalTable: "InsideInfos",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EditInsideInfo_InsideInfos_editsid1",
                table: "EditInsideInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_DataFiles_Filesid",
                table: "InsideInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_InsideInfos_MuseumInfoid",
                table: "UnifPassports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsideInfos",
                table: "InsideInfos");

            migrationBuilder.RenameTable(
                name: "InsideInfos",
                newName: "MuseumInfos");

            migrationBuilder.RenameIndex(
                name: "IX_InsideInfos_Filesid",
                table: "MuseumInfos",
                newName: "IX_MuseumInfos_Filesid");

            migrationBuilder.RenameIndex(
                name: "IX_InsideInfos_Exhibitionid",
                table: "MuseumInfos",
                newName: "IX_MuseumInfos_Exhibitionid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MuseumInfos",
                table: "MuseumInfos",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_EditInsideInfo_MuseumInfos_editsid1",
                table: "EditInsideInfo",
                column: "editsid1",
                principalTable: "MuseumInfos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuseumInfos_DataFiles_Filesid",
                table: "MuseumInfos",
                column: "Filesid",
                principalTable: "DataFiles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuseumInfos_Exhibitions_Exhibitionid",
                table: "MuseumInfos",
                column: "Exhibitionid",
                principalTable: "Exhibitions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_MuseumInfos_MuseumInfoid",
                table: "UnifPassports",
                column: "MuseumInfoid",
                principalTable: "MuseumInfos",
                principalColumn: "id");
        }
    }
}
