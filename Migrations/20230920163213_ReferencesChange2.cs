using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ReferencesChange2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BtwMatAcc_Acceptances_Acceptanceid",
                table: "BtwMatAcc");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwMatAcc_Materials_MaterialId",
                table: "BtwMatAcc");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwStatAcc_Acceptances_Acceptanceid",
                table: "BtwStatAcc");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwStatAcc_States_StateId",
                table: "BtwStatAcc");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwTecAcc_Acceptances_Acceptanceid",
                table: "BtwTecAcc");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwTecAcc_Techniques_TechniqueId",
                table: "BtwTecAcc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BtwTecAcc",
                table: "BtwTecAcc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BtwStatAcc",
                table: "BtwStatAcc");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BtwMatAcc",
                table: "BtwMatAcc");

            migrationBuilder.RenameTable(
                name: "BtwTecAcc",
                newName: "BtwTecAccs");

            migrationBuilder.RenameTable(
                name: "BtwStatAcc",
                newName: "BtwStatAccs");

            migrationBuilder.RenameTable(
                name: "BtwMatAcc",
                newName: "BtwMatAccs");

            migrationBuilder.RenameIndex(
                name: "IX_BtwTecAcc_TechniqueId",
                table: "BtwTecAccs",
                newName: "IX_BtwTecAccs_TechniqueId");

            migrationBuilder.RenameIndex(
                name: "IX_BtwTecAcc_Acceptanceid",
                table: "BtwTecAccs",
                newName: "IX_BtwTecAccs_Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_BtwStatAcc_StateId",
                table: "BtwStatAccs",
                newName: "IX_BtwStatAccs_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_BtwStatAcc_Acceptanceid",
                table: "BtwStatAccs",
                newName: "IX_BtwStatAccs_Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_BtwMatAcc_MaterialId",
                table: "BtwMatAccs",
                newName: "IX_BtwMatAccs_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_BtwMatAcc_Acceptanceid",
                table: "BtwMatAccs",
                newName: "IX_BtwMatAccs_Acceptanceid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BtwTecAccs",
                table: "BtwTecAccs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BtwStatAccs",
                table: "BtwStatAccs",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BtwMatAccs",
                table: "BtwMatAccs",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_BtwMatAccs_Acceptances_Acceptanceid",
                table: "BtwMatAccs",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwMatAccs_Materials_MaterialId",
                table: "BtwMatAccs",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwStatAccs_Acceptances_Acceptanceid",
                table: "BtwStatAccs",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwStatAccs_States_StateId",
                table: "BtwStatAccs",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                table: "BtwTecAccs",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwTecAccs_Techniques_TechniqueId",
                table: "BtwTecAccs",
                column: "TechniqueId",
                principalTable: "Techniques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BtwMatAccs_Acceptances_Acceptanceid",
                table: "BtwMatAccs");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwMatAccs_Materials_MaterialId",
                table: "BtwMatAccs");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwStatAccs_Acceptances_Acceptanceid",
                table: "BtwStatAccs");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwStatAccs_States_StateId",
                table: "BtwStatAccs");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwTecAccs_Acceptances_Acceptanceid",
                table: "BtwTecAccs");

            migrationBuilder.DropForeignKey(
                name: "FK_BtwTecAccs_Techniques_TechniqueId",
                table: "BtwTecAccs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BtwTecAccs",
                table: "BtwTecAccs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BtwStatAccs",
                table: "BtwStatAccs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BtwMatAccs",
                table: "BtwMatAccs");

            migrationBuilder.RenameTable(
                name: "BtwTecAccs",
                newName: "BtwTecAcc");

            migrationBuilder.RenameTable(
                name: "BtwStatAccs",
                newName: "BtwStatAcc");

            migrationBuilder.RenameTable(
                name: "BtwMatAccs",
                newName: "BtwMatAcc");

            migrationBuilder.RenameIndex(
                name: "IX_BtwTecAccs_TechniqueId",
                table: "BtwTecAcc",
                newName: "IX_BtwTecAcc_TechniqueId");

            migrationBuilder.RenameIndex(
                name: "IX_BtwTecAccs_Acceptanceid",
                table: "BtwTecAcc",
                newName: "IX_BtwTecAcc_Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_BtwStatAccs_StateId",
                table: "BtwStatAcc",
                newName: "IX_BtwStatAcc_StateId");

            migrationBuilder.RenameIndex(
                name: "IX_BtwStatAccs_Acceptanceid",
                table: "BtwStatAcc",
                newName: "IX_BtwStatAcc_Acceptanceid");

            migrationBuilder.RenameIndex(
                name: "IX_BtwMatAccs_MaterialId",
                table: "BtwMatAcc",
                newName: "IX_BtwMatAcc_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_BtwMatAccs_Acceptanceid",
                table: "BtwMatAcc",
                newName: "IX_BtwMatAcc_Acceptanceid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BtwTecAcc",
                table: "BtwTecAcc",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BtwStatAcc",
                table: "BtwStatAcc",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BtwMatAcc",
                table: "BtwMatAcc",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_BtwMatAcc_Acceptances_Acceptanceid",
                table: "BtwMatAcc",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwMatAcc_Materials_MaterialId",
                table: "BtwMatAcc",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwStatAcc_Acceptances_Acceptanceid",
                table: "BtwStatAcc",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwStatAcc_States_StateId",
                table: "BtwStatAcc",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwTecAcc_Acceptances_Acceptanceid",
                table: "BtwTecAcc",
                column: "Acceptanceid",
                principalTable: "Acceptances",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BtwTecAcc_Techniques_TechniqueId",
                table: "BtwTecAcc",
                column: "TechniqueId",
                principalTable: "Techniques",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
