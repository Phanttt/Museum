using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class changesR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Recipientid",
                table: "Receivings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_Recipientid",
                table: "Receivings",
                column: "Recipientid");

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Users_Recipientid",
                table: "Receivings",
                column: "Recipientid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Users_Recipientid",
                table: "Receivings");

            migrationBuilder.DropIndex(
                name: "IX_Receivings_Recipientid",
                table: "Receivings");

            migrationBuilder.DropColumn(
                name: "Recipientid",
                table: "Receivings");
        }
    }
}
