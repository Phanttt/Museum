using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class NullablesRows2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos");

            migrationBuilder.RenameColumn(
                name: "Exhibitionid",
                table: "InsideInfos",
                newName: "exhibitionid");

            migrationBuilder.RenameIndex(
                name: "IX_InsideInfos_Exhibitionid",
                table: "InsideInfos",
                newName: "IX_InsideInfos_exhibitionid");

            migrationBuilder.AlterColumn<byte[]>(
                name: "image",
                table: "Exhibitions",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<string>(
                name: "descriprion",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_InsideInfos_Exhibitions_exhibitionid",
                table: "InsideInfos",
                column: "exhibitionid",
                principalTable: "Exhibitions",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_Exhibitions_exhibitionid",
                table: "InsideInfos");

            migrationBuilder.RenameColumn(
                name: "exhibitionid",
                table: "InsideInfos",
                newName: "Exhibitionid");

            migrationBuilder.RenameIndex(
                name: "IX_InsideInfos_exhibitionid",
                table: "InsideInfos",
                newName: "IX_InsideInfos_Exhibitionid");

            migrationBuilder.AlterColumn<byte[]>(
                name: "image",
                table: "Exhibitions",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descriprion",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos",
                column: "Exhibitionid",
                principalTable: "Exhibitions",
                principalColumn: "id");
        }
    }
}
