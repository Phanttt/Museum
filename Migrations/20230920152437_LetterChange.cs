using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class LetterChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Acceptances_UnifPassports_UnifPassportId",
                table: "Acceptances");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Acceptances_AcceptanceId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Acceptances_AcceptanceId",
                table: "States");

            migrationBuilder.DropForeignKey(
                name: "FK_Techniques_Acceptances_AcceptanceId",
                table: "Techniques");

            migrationBuilder.RenameColumn(
                name: "AcceptanceId",
                table: "Techniques",
                newName: "Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_Techniques_AcceptanceId",
                table: "Techniques",
                newName: "IX_Techniques_Acceptanceid");

            migrationBuilder.RenameColumn(
                name: "AcceptanceId",
                table: "States",
                newName: "Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_States_AcceptanceId",
                table: "States",
                newName: "IX_States_Acceptanceid");

            migrationBuilder.RenameColumn(
                name: "AcceptanceId",
                table: "Materials",
                newName: "Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_AcceptanceId",
                table: "Materials",
                newName: "IX_Materials_Acceptanceid");

            migrationBuilder.RenameColumn(
                name: "UnifPassportId",
                table: "Acceptances",
                newName: "unifPassportId");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Acceptances",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Acceptances",
                newName: "size");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Acceptances",
                newName: "shortDescription");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Acceptances",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsWeapon",
                table: "Acceptances",
                newName: "isWeapon");

            migrationBuilder.RenameColumn(
                name: "IsSpecFond",
                table: "Acceptances",
                newName: "isSpecFond");

            migrationBuilder.RenameColumn(
                name: "IsDragMetal",
                table: "Acceptances",
                newName: "isDragMetal");

            migrationBuilder.RenameColumn(
                name: "InventoryN",
                table: "Acceptances",
                newName: "inventoryN");

            migrationBuilder.RenameColumn(
                name: "InsideN",
                table: "Acceptances",
                newName: "insideN");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Acceptances",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Acceptances_UnifPassportId",
                table: "Acceptances",
                newName: "IX_Acceptances_unifPassportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acceptances_UnifPassports_unifPassportId",
                table: "Acceptances",
                column: "unifPassportId",
                principalTable: "UnifPassports",
                principalColumn: "Id");

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
                name: "FK_Acceptances_UnifPassports_unifPassportId",
                table: "Acceptances");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Acceptances_Acceptanceid",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Acceptances_Acceptanceid",
                table: "States");

            migrationBuilder.DropForeignKey(
                name: "FK_Techniques_Acceptances_Acceptanceid",
                table: "Techniques");

            migrationBuilder.RenameColumn(
                name: "Acceptanceid",
                table: "Techniques",
                newName: "AcceptanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Techniques_Acceptanceid",
                table: "Techniques",
                newName: "IX_Techniques_AcceptanceId");

            migrationBuilder.RenameColumn(
                name: "Acceptanceid",
                table: "States",
                newName: "AcceptanceId");

            migrationBuilder.RenameIndex(
                name: "IX_States_Acceptanceid",
                table: "States",
                newName: "IX_States_AcceptanceId");

            migrationBuilder.RenameColumn(
                name: "Acceptanceid",
                table: "Materials",
                newName: "AcceptanceId");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_Acceptanceid",
                table: "Materials",
                newName: "IX_Materials_AcceptanceId");

            migrationBuilder.RenameColumn(
                name: "unifPassportId",
                table: "Acceptances",
                newName: "UnifPassportId");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Acceptances",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "size",
                table: "Acceptances",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "shortDescription",
                table: "Acceptances",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Acceptances",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isWeapon",
                table: "Acceptances",
                newName: "IsWeapon");

            migrationBuilder.RenameColumn(
                name: "isSpecFond",
                table: "Acceptances",
                newName: "IsSpecFond");

            migrationBuilder.RenameColumn(
                name: "isDragMetal",
                table: "Acceptances",
                newName: "IsDragMetal");

            migrationBuilder.RenameColumn(
                name: "inventoryN",
                table: "Acceptances",
                newName: "InventoryN");

            migrationBuilder.RenameColumn(
                name: "insideN",
                table: "Acceptances",
                newName: "InsideN");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Acceptances",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Acceptances_unifPassportId",
                table: "Acceptances",
                newName: "IX_Acceptances_UnifPassportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Acceptances_UnifPassports_UnifPassportId",
                table: "Acceptances",
                column: "UnifPassportId",
                principalTable: "UnifPassports",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Acceptances_AcceptanceId",
                table: "Materials",
                column: "AcceptanceId",
                principalTable: "Acceptances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Acceptances_AcceptanceId",
                table: "States",
                column: "AcceptanceId",
                principalTable: "Acceptances",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Techniques_Acceptances_AcceptanceId",
                table: "Techniques",
                column: "AcceptanceId",
                principalTable: "Acceptances",
                principalColumn: "Id");
        }
    }
}
