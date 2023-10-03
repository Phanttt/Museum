using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ChangeInImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ImageRights_ImageRightId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Producers_ProducersId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Medias_MediaId",
                table: "UnifPassports");

            migrationBuilder.DropColumn(
                name: "CopyrightHolder",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "Photographer",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Videos",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Videos",
                newName: "link");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Videos",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Videos",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Videos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "UnifPassports",
                newName: "Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_MediaId",
                table: "UnifPassports",
                newName: "IX_UnifPassports_Mediaid");

            migrationBuilder.RenameColumn(
                name: "ReceiptAgreement",
                table: "Receivings",
                newName: "receiptAgreement");

            migrationBuilder.RenameColumn(
                name: "ReceiptAct",
                table: "Receivings",
                newName: "receiptAct");

            migrationBuilder.RenameColumn(
                name: "PriceAct",
                table: "Receivings",
                newName: "priceAct");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Receivings",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "PeriodTo",
                table: "Receivings",
                newName: "periodTo");

            migrationBuilder.RenameColumn(
                name: "PeriodFrom",
                table: "Receivings",
                newName: "periodFrom");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Receivings",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "ProducersId",
                table: "Receivings",
                newName: "ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_ProducersId",
                table: "Receivings",
                newName: "IX_Receivings_ProducerId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Medias",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Images",
                newName: "link");

            migrationBuilder.RenameColumn(
                name: "IsMain",
                table: "Images",
                newName: "isMain");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Images",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Images",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Images",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ImageRightId",
                table: "Images",
                newName: "GeneralInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ImageRightId",
                table: "Images",
                newName: "IX_Images_GeneralInfoid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ImageRights",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ImageRights",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Documents",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Documents",
                newName: "link");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Documents",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Documents",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Documents",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Audios",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Audios",
                newName: "link");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Audios",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Data",
                table: "Audios",
                newName: "data");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Audios",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Receivings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionFP",
                table: "Receivings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Mediaid",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Currency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralInfo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photographer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    copyrightHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageRightid = table.Column<int>(type: "int", nullable: false),
                    mediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralInfo", x => x.id);
                    table.ForeignKey(
                        name: "FK_GeneralInfo_ImageRights_ImageRightid",
                        column: x => x.ImageRightid,
                        principalTable: "ImageRights",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_CurrencyId",
                table: "Receivings",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Mediaid",
                table: "Images",
                column: "Mediaid");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralInfo_ImageRightid",
                table: "GeneralInfo",
                column: "ImageRightid");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_GeneralInfo_GeneralInfoid",
                table: "Images",
                column: "GeneralInfoid",
                principalTable: "GeneralInfo",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Medias_Mediaid",
                table: "Images",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Currency_CurrencyId",
                table: "Receivings",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Producers_ProducerId",
                table: "Receivings",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Medias_Mediaid",
                table: "UnifPassports",
                column: "Mediaid",
                principalTable: "Medias",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_GeneralInfo_GeneralInfoid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Medias_Mediaid",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Currency_CurrencyId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Producers_ProducerId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Medias_Mediaid",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "Currency");

            migrationBuilder.DropTable(
                name: "GeneralInfo");

            migrationBuilder.DropIndex(
                name: "IX_Receivings_CurrencyId",
                table: "Receivings");

            migrationBuilder.DropIndex(
                name: "IX_Images_Mediaid",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Receivings");

            migrationBuilder.DropColumn(
                name: "DescriptionFP",
                table: "Receivings");

            migrationBuilder.DropColumn(
                name: "Mediaid",
                table: "Images");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "Videos",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "link",
                table: "Videos",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Videos",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Videos",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Videos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "UnifPassports",
                newName: "MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_Mediaid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_MediaId");

            migrationBuilder.RenameColumn(
                name: "receiptAgreement",
                table: "Receivings",
                newName: "ReceiptAgreement");

            migrationBuilder.RenameColumn(
                name: "receiptAct",
                table: "Receivings",
                newName: "ReceiptAct");

            migrationBuilder.RenameColumn(
                name: "priceAct",
                table: "Receivings",
                newName: "PriceAct");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Receivings",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "periodTo",
                table: "Receivings",
                newName: "PeriodTo");

            migrationBuilder.RenameColumn(
                name: "periodFrom",
                table: "Receivings",
                newName: "PeriodFrom");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Receivings",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Receivings",
                newName: "ProducersId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_ProducerId",
                table: "Receivings",
                newName: "IX_Receivings_ProducersId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Medias",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "link",
                table: "Images",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "isMain",
                table: "Images",
                newName: "IsMain");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Images",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Images",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Images",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GeneralInfoid",
                table: "Images",
                newName: "ImageRightId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_GeneralInfoid",
                table: "Images",
                newName: "IX_Images_ImageRightId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ImageRights",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ImageRights",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "Documents",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "link",
                table: "Documents",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Documents",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Documents",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Documents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "Audios",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "link",
                table: "Audios",
                newName: "Link");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Audios",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "data",
                table: "Audios",
                newName: "Data");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Audios",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "CopyrightHolder",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Photographer",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ImageRights_ImageRightId",
                table: "Images",
                column: "ImageRightId",
                principalTable: "ImageRights",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Producers_ProducersId",
                table: "Receivings",
                column: "ProducersId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Medias_MediaId",
                table: "UnifPassports",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "Id");
        }
    }
}
