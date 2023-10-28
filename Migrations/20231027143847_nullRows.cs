using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class nullRows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_DataFiles_Filesid",
                table: "InsideInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos");

            migrationBuilder.AlterColumn<int>(
                name: "Filesid",
                table: "InsideInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Exhibitionid",
                table: "InsideInfos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_InsideInfos_DataFiles_Filesid",
                table: "InsideInfos",
                column: "Filesid",
                principalTable: "DataFiles",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos",
                column: "Exhibitionid",
                principalTable: "Exhibitions",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_DataFiles_Filesid",
                table: "InsideInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_InsideInfos_Exhibitions_Exhibitionid",
                table: "InsideInfos");

            migrationBuilder.AlterColumn<int>(
                name: "Filesid",
                table: "InsideInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Exhibitionid",
                table: "InsideInfos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
        }
    }
}
