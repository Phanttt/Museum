using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class ChangesInDetailInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Collections_DetailInfos_DetailInfoId",
                table: "Collections");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailInfos_Classifications_ClassificationId",
                table: "DetailInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailInfos_Decodings_DecodingId",
                table: "DetailInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailInfos_Forms_FormId",
                table: "DetailInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailInfos_Funds_FundId",
                table: "DetailInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetailInfos_Genders_genderId",
                table: "DetailInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Groups_DetailInfos_DetailInfoId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Medias_MediaId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_KeyWords_DetailInfos_DetailInfoId",
                table: "KeyWords");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoId",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_DetailInfos_DetailInfoId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Complexes_ComplexId",
                table: "UnifPassports");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_DetailInfos_DetailInfoId",
                table: "UnifPassports");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Medias_MediaId",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "Complexes");

            migrationBuilder.DropTable(
                name: "Decodings");

            migrationBuilder.DropTable(
                name: "DetLinks");

            migrationBuilder.DropTable(
                name: "Dimentions");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Inscripts");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropTable(
                name: "Stamps");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Markings");

            migrationBuilder.DropIndex(
                name: "IX_UnifPassports_ComplexId",
                table: "UnifPassports");

            migrationBuilder.DropIndex(
                name: "IX_Tags_DetailInfoId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_KeyWords_DetailInfoId",
                table: "KeyWords");

            migrationBuilder.DropIndex(
                name: "IX_Groups_DetailInfoId",
                table: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_DetailInfos_ClassificationId",
                table: "DetailInfos");

            migrationBuilder.DropIndex(
                name: "IX_DetailInfos_DecodingId",
                table: "DetailInfos");

            migrationBuilder.DropIndex(
                name: "IX_DetailInfos_FormId",
                table: "DetailInfos");

            migrationBuilder.DropIndex(
                name: "IX_DetailInfos_genderId",
                table: "DetailInfos");

            migrationBuilder.DropIndex(
                name: "IX_Collections_DetailInfoId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "ComplexId",
                table: "UnifPassports");

            migrationBuilder.DropColumn(
                name: "DetailInfoId",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "DetailInfoId",
                table: "KeyWords");

            migrationBuilder.DropColumn(
                name: "Meaning",
                table: "KeyWords");

            migrationBuilder.DropColumn(
                name: "WIKILink",
                table: "KeyWords");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "DetailInfoId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Funds");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Funds");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Funds");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Funds");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Funds");

            migrationBuilder.DropColumn(
                name: "ClassificationId",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "DSTUSize",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "DecodingId",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "FormId",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "FullDescription",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "IsComplex",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "Restavration",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "SimilarItems",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "Thanks",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "color",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "genderId",
                table: "DetailInfos");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "DetailInfoId",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Collections");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Collections");

            migrationBuilder.RenameColumn(
                name: "MediaId",
                table: "UnifPassports",
                newName: "Mediaid");

            migrationBuilder.RenameColumn(
                name: "DetailInfoId",
                table: "UnifPassports",
                newName: "DetailInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_MediaId",
                table: "UnifPassports",
                newName: "IX_UnifPassports_Mediaid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_DetailInfoId",
                table: "UnifPassports",
                newName: "IX_UnifPassports_DetailInfoid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tags",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tags",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "GeneralInfoId",
                table: "Medias",
                newName: "GeneralInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_GeneralInfoId",
                table: "Medias",
                newName: "IX_Medias_GeneralInfoid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "KeyWords",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KeyWords",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Groups",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Groups",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Funds",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Funds",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FundId",
                table: "DetailInfos",
                newName: "Fundid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DetailInfos",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_DetailInfos_FundId",
                table: "DetailInfos",
                newName: "IX_DetailInfos_Fundid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Collections",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Collections",
                newName: "id");

            migrationBuilder.AlterColumn<byte[]>(
                name: "data",
                table: "Images",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MediaId",
                table: "Images",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "CollectionDetailInfo",
                columns: table => new
                {
                    collectionsid = table.Column<int>(type: "int", nullable: false),
                    detailInfosid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionDetailInfo", x => new { x.collectionsid, x.detailInfosid });
                    table.ForeignKey(
                        name: "FK_CollectionDetailInfo_Collections_collectionsid",
                        column: x => x.collectionsid,
                        principalTable: "Collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollectionDetailInfo_DetailInfos_detailInfosid",
                        column: x => x.detailInfosid,
                        principalTable: "DetailInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailInfoGroup",
                columns: table => new
                {
                    detailInfosid = table.Column<int>(type: "int", nullable: false),
                    groupsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailInfoGroup", x => new { x.detailInfosid, x.groupsid });
                    table.ForeignKey(
                        name: "FK_DetailInfoGroup_DetailInfos_detailInfosid",
                        column: x => x.detailInfosid,
                        principalTable: "DetailInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfoGroup_Groups_groupsid",
                        column: x => x.groupsid,
                        principalTable: "Groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailInfoKeyWord",
                columns: table => new
                {
                    detailInfosid = table.Column<int>(type: "int", nullable: false),
                    keyWordsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailInfoKeyWord", x => new { x.detailInfosid, x.keyWordsid });
                    table.ForeignKey(
                        name: "FK_DetailInfoKeyWord_DetailInfos_detailInfosid",
                        column: x => x.detailInfosid,
                        principalTable: "DetailInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfoKeyWord_KeyWords_keyWordsid",
                        column: x => x.keyWordsid,
                        principalTable: "KeyWords",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailInfoTag",
                columns: table => new
                {
                    detailInfosid = table.Column<int>(type: "int", nullable: false),
                    tagsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailInfoTag", x => new { x.detailInfosid, x.tagsid });
                    table.ForeignKey(
                        name: "FK_DetailInfoTag_DetailInfos_detailInfosid",
                        column: x => x.detailInfosid,
                        principalTable: "DetailInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfoTag_Tags_tagsid",
                        column: x => x.tagsid,
                        principalTable: "Tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollectionDetailInfo_detailInfosid",
                table: "CollectionDetailInfo",
                column: "detailInfosid");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfoGroup_groupsid",
                table: "DetailInfoGroup",
                column: "groupsid");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfoKeyWord_keyWordsid",
                table: "DetailInfoKeyWord",
                column: "keyWordsid");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfoTag_tagsid",
                table: "DetailInfoTag",
                column: "tagsid");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailInfos_Funds_Fundid",
                table: "DetailInfos",
                column: "Fundid",
                principalTable: "Funds",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Medias_MediaId",
                table: "Images",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoid",
                table: "Medias",
                column: "GeneralInfoid",
                principalTable: "GeneralInfo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_DetailInfos_DetailInfoid",
                table: "UnifPassports",
                column: "DetailInfoid",
                principalTable: "DetailInfos",
                principalColumn: "id");

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
                name: "FK_DetailInfos_Funds_Fundid",
                table: "DetailInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Medias_MediaId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoid",
                table: "Medias");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_DetailInfos_DetailInfoid",
                table: "UnifPassports");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Medias_Mediaid",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "CollectionDetailInfo");

            migrationBuilder.DropTable(
                name: "DetailInfoGroup");

            migrationBuilder.DropTable(
                name: "DetailInfoKeyWord");

            migrationBuilder.DropTable(
                name: "DetailInfoTag");

            migrationBuilder.RenameColumn(
                name: "Mediaid",
                table: "UnifPassports",
                newName: "MediaId");

            migrationBuilder.RenameColumn(
                name: "DetailInfoid",
                table: "UnifPassports",
                newName: "DetailInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_Mediaid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_MediaId");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_DetailInfoid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_DetailInfoId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Tags",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tags",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GeneralInfoid",
                table: "Medias",
                newName: "GeneralInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Medias_GeneralInfoid",
                table: "Medias",
                newName: "IX_Medias_GeneralInfoId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "KeyWords",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "KeyWords",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Groups",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Groups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Funds",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Funds",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Fundid",
                table: "DetailInfos",
                newName: "FundId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "DetailInfos",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DetailInfos_Fundid",
                table: "DetailInfos",
                newName: "IX_DetailInfos_FundId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Collections",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Collections",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ComplexId",
                table: "UnifPassports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailInfoId",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DetailInfoId",
                table: "KeyWords",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Meaning",
                table: "KeyWords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WIKILink",
                table: "KeyWords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DetailInfoId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Groups",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Funds",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ClassificationId",
                table: "DetailInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "DetailInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "DSTUSize",
                table: "DetailInfos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "DecodingId",
                table: "DetailInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FormId",
                table: "DetailInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullDescription",
                table: "DetailInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsComplex",
                table: "DetailInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Restavration",
                table: "DetailInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SimilarItems",
                table: "DetailInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Thanks",
                table: "DetailInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "DetailInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "genderId",
                table: "DetailInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DetailInfoId",
                table: "Collections",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Collections",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassifName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemsGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartItem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Complexes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    RefferTo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complexes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decodings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InscriptLanguage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InscriptOriginal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InscriptTranslation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decodings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetLinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetLinks_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diameter = table.Column<float>(type: "real", nullable: false),
                    DiameterUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    HeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LenghtUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thickness = table.Column<float>(type: "real", nullable: false),
                    ThicknessUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WallThickness = table.Column<float>(type: "real", nullable: false),
                    WallThicknessUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    WeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    WidthUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lenght = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimentions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Markings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Markings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Researches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_countryId",
                        column: x => x.countryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cities_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inscripts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InscriptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarkingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inscripts_Markings_MarkingId",
                        column: x => x.MarkingId,
                        principalTable: "Markings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Stamps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarkingId = table.Column<int>(type: "int", nullable: true),
                    StampName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stamps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stamps_Markings_MarkingId",
                        column: x => x.MarkingId,
                        principalTable: "Markings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnifPassports_ComplexId",
                table: "UnifPassports",
                column: "ComplexId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_DetailInfoId",
                table: "Tags",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWords_DetailInfoId",
                table: "KeyWords",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DetailInfoId",
                table: "Groups",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfos_ClassificationId",
                table: "DetailInfos",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfos_DecodingId",
                table: "DetailInfos",
                column: "DecodingId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfos_FormId",
                table: "DetailInfos",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfos_genderId",
                table: "DetailInfos",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_DetailInfoId",
                table: "Collections",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_countryId",
                table: "Cities",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DetailInfoId",
                table: "Cities",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetLinks_DetailInfoId",
                table: "DetLinks",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripts_MarkingId",
                table: "Inscripts",
                column: "MarkingId");

            migrationBuilder.CreateIndex(
                name: "IX_Stamps_MarkingId",
                table: "Stamps",
                column: "MarkingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Collections_DetailInfos_DetailInfoId",
                table: "Collections",
                column: "DetailInfoId",
                principalTable: "DetailInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetailInfos_Classifications_ClassificationId",
                table: "DetailInfos",
                column: "ClassificationId",
                principalTable: "Classifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailInfos_Decodings_DecodingId",
                table: "DetailInfos",
                column: "DecodingId",
                principalTable: "Decodings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailInfos_Forms_FormId",
                table: "DetailInfos",
                column: "FormId",
                principalTable: "Forms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailInfos_Funds_FundId",
                table: "DetailInfos",
                column: "FundId",
                principalTable: "Funds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetailInfos_Genders_genderId",
                table: "DetailInfos",
                column: "genderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_DetailInfos_DetailInfoId",
                table: "Groups",
                column: "DetailInfoId",
                principalTable: "DetailInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Medias_MediaId",
                table: "Images",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KeyWords_DetailInfos_DetailInfoId",
                table: "KeyWords",
                column: "DetailInfoId",
                principalTable: "DetailInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medias_GeneralInfo_GeneralInfoId",
                table: "Medias",
                column: "GeneralInfoId",
                principalTable: "GeneralInfo",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_DetailInfos_DetailInfoId",
                table: "Tags",
                column: "DetailInfoId",
                principalTable: "DetailInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Complexes_ComplexId",
                table: "UnifPassports",
                column: "ComplexId",
                principalTable: "Complexes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_DetailInfos_DetailInfoId",
                table: "UnifPassports",
                column: "DetailInfoId",
                principalTable: "DetailInfos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Medias_MediaId",
                table: "UnifPassports",
                column: "MediaId",
                principalTable: "Medias",
                principalColumn: "id");
        }
    }
}
