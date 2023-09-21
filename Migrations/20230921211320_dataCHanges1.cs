using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class dataCHanges1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                table: "BtwTecAccs");

            migrationBuilder.DropColumn(
                name: "accId",
                table: "BtwTecAccs");

            migrationBuilder.DropColumn(
                name: "tecId",
                table: "BtwTecAccs");

            migrationBuilder.DropColumn(
                name: "accId",
                table: "BtwStatAccs");

            migrationBuilder.DropColumn(
                name: "statId",
                table: "BtwStatAccs");

            migrationBuilder.DropColumn(
                name: "accId",
                table: "BtwMatAccs");

            migrationBuilder.DropColumn(
                name: "matId",
                table: "BtwMatAccs");

            migrationBuilder.AlterColumn<int>(
                name: "Acceptanceid",
                table: "BtwTecAccs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                table: "BtwTecAccs",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                table: "BtwTecAccs");

            migrationBuilder.AlterColumn<int>(
                name: "Acceptanceid",
                table: "BtwTecAccs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "accId",
                table: "BtwTecAccs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tecId",
                table: "BtwTecAccs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "accId",
                table: "BtwStatAccs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "statId",
                table: "BtwStatAccs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "accId",
                table: "BtwMatAccs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "matId",
                table: "BtwMatAccs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                table: "BtwTecAccs",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
