using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class MuseumInfoChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_Deletings_DeletingId",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_Edits_EditId",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_Locations_LocationId",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_StorageConditions_StorageConditionId",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_MuseumInfos_MuseumInfoId",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DropTable(
                name: "Deletings");

            migrationBuilder.DropTable(
                name: "ItemDamages");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "SpecFunds");

            migrationBuilder.DropTable(
                name: "StorageConditions");

            migrationBuilder.DropTable(
                name: "CheckTypes");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Exposition");

            migrationBuilder.DropTable(
                name: "DragMetals");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_MuseumInfos_DeletingId",
                table: "MuseumInfos");

            migrationBuilder.DropIndex(
                name: "IX_MuseumInfos_EditId",
                table: "MuseumInfos");

            migrationBuilder.DropColumn(
                name: "DeletingId",
                table: "MuseumInfos");

            migrationBuilder.DropColumn(
                name: "EditId",
                table: "MuseumInfos");

            migrationBuilder.RenameColumn(
                name: "MuseumInfoId",
                table: "UnifPassports",
                newName: "MuseumInfoid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_MuseumInfoId",
                table: "UnifPassports",
                newName: "IX_UnifPassports_MuseumInfoid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MuseumInfos",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StorageConditionId",
                table: "MuseumInfos",
                newName: "Filesid");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "MuseumInfos",
                newName: "Exhibitionid");

            migrationBuilder.RenameIndex(
                name: "IX_MuseumInfos_StorageConditionId",
                table: "MuseumInfos",
                newName: "IX_MuseumInfos_Filesid");

            migrationBuilder.RenameIndex(
                name: "IX_MuseumInfos_LocationId",
                table: "MuseumInfos",
                newName: "IX_MuseumInfos_Exhibitionid");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Exhibitions",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Exhibitions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Edits",
                newName: "itemId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Edits",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Edits",
                newName: "id");

            migrationBuilder.AddColumn<bool>(
                name: "isOnExhibition",
                table: "MuseumInfos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "descriprion",
                table: "Exhibitions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "image",
                table: "Exhibitions",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateTable(
                name: "DataFiles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actToGiftingDeed = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    giftingDeed = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    intoFondAct = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataFiles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EditMuseumInfo",
                columns: table => new
                {
                    editsid = table.Column<int>(type: "int", nullable: false),
                    editsid1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditMuseumInfo", x => new { x.editsid, x.editsid1 });
                    table.ForeignKey(
                        name: "FK_EditMuseumInfo_Edits_editsid",
                        column: x => x.editsid,
                        principalTable: "Edits",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditMuseumInfo_MuseumInfos_editsid1",
                        column: x => x.editsid1,
                        principalTable: "MuseumInfos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditMuseumInfo_editsid1",
                table: "EditMuseumInfo",
                column: "editsid1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_DataFiles_Filesid",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MuseumInfos_Exhibitions_Exhibitionid",
                table: "MuseumInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_MuseumInfos_MuseumInfoid",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "DataFiles");

            migrationBuilder.DropTable(
                name: "EditMuseumInfo");

            migrationBuilder.DropColumn(
                name: "isOnExhibition",
                table: "MuseumInfos");

            migrationBuilder.DropColumn(
                name: "descriprion",
                table: "Exhibitions");

            migrationBuilder.DropColumn(
                name: "image",
                table: "Exhibitions");

            migrationBuilder.RenameColumn(
                name: "MuseumInfoid",
                table: "UnifPassports",
                newName: "MuseumInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_MuseumInfoid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_MuseumInfoId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MuseumInfos",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Filesid",
                table: "MuseumInfos",
                newName: "StorageConditionId");

            migrationBuilder.RenameColumn(
                name: "Exhibitionid",
                table: "MuseumInfos",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_MuseumInfos_Filesid",
                table: "MuseumInfos",
                newName: "IX_MuseumInfos_StorageConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_MuseumInfos_Exhibitionid",
                table: "MuseumInfos",
                newName: "IX_MuseumInfos_LocationId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Exhibitions",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Exhibitions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "Edits",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Edits",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Edits",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "DeletingId",
                table: "MuseumInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EditId",
                table: "MuseumInfos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CheckTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deletings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Userid = table.Column<int>(type: "int", nullable: false),
                    DateOnly = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletingAct = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deletings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deletings_Users_Userid",
                        column: x => x.Userid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DragMetals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DragMetalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Probe = table.Column<int>(type: "int", nullable: false),
                    ProbeActScan = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    WeightGramm = table.Column<float>(type: "real", nullable: false),
                    WeightKarat = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DragMetals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exposition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exposition", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NegativeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToxicityRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportationRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatmentRec = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StorageConditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Humidity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InSafe = table.Column<bool>(type: "bit", nullable: false),
                    Light = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Safe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AmmoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpertizionScan = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    IsAmmo = table.Column<bool>(type: "bit", nullable: false),
                    IsMuseumWeapon = table.Column<bool>(type: "bit", nullable: false),
                    IsPartOfWeapon = table.Column<bool>(type: "bit", nullable: false),
                    MMG = table.Column<bool>(type: "bit", nullable: false),
                    PartOfWeaponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportScan = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckTypeId = table.Column<int>(type: "int", nullable: false),
                    Chekerid = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checks_CheckTypes_CheckTypeId",
                        column: x => x.CheckTypeId,
                        principalTable: "CheckTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Checks_MuseumInfos_MuseumInfoId",
                        column: x => x.MuseumInfoId,
                        principalTable: "MuseumInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Checks_Users_Chekerid",
                        column: x => x.Chekerid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExhibitionId = table.Column<int>(type: "int", nullable: false),
                    ExpositionId = table.Column<int>(type: "int", nullable: false),
                    InsideWork = table.Column<bool>(type: "bit", nullable: false),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reservations_Exhibitions_ExhibitionId",
                        column: x => x.ExhibitionId,
                        principalTable: "Exhibitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Exposition_ExpositionId",
                        column: x => x.ExpositionId,
                        principalTable: "Exposition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_MuseumInfos_MuseumInfoId",
                        column: x => x.MuseumInfoId,
                        principalTable: "MuseumInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemDamages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discovererid = table.Column<int>(type: "int", nullable: false),
                    RecommendationId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemDamages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemDamages_MuseumInfos_MuseumInfoId",
                        column: x => x.MuseumInfoId,
                        principalTable: "MuseumInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemDamages_Recommendations_RecommendationId",
                        column: x => x.RecommendationId,
                        principalTable: "Recommendations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemDamages_Users_Discovererid",
                        column: x => x.Discovererid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorageId = table.Column<int>(type: "int", nullable: false),
                    Box = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Closet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOnExhibition = table.Column<bool>(type: "bit", nullable: false),
                    IsOnExposition = table.Column<bool>(type: "bit", nullable: false),
                    IsOnStorage = table.Column<bool>(type: "bit", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shelf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecFunds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DragMetalId = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecFunds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecFunds_DragMetals_DragMetalId",
                        column: x => x.DragMetalId,
                        principalTable: "DragMetals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecFunds_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MuseumInfos_DeletingId",
                table: "MuseumInfos",
                column: "DeletingId");

            migrationBuilder.CreateIndex(
                name: "IX_MuseumInfos_EditId",
                table: "MuseumInfos",
                column: "EditId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_CheckTypeId",
                table: "Checks",
                column: "CheckTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_Chekerid",
                table: "Checks",
                column: "Chekerid");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_MuseumInfoId",
                table: "Checks",
                column: "MuseumInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Deletings_Userid",
                table: "Deletings",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDamages_Discovererid",
                table: "ItemDamages",
                column: "Discovererid");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDamages_MuseumInfoId",
                table: "ItemDamages",
                column: "MuseumInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDamages_RecommendationId",
                table: "ItemDamages",
                column: "RecommendationId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StorageId",
                table: "Locations",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ExhibitionId",
                table: "Reservations",
                column: "ExhibitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_ExpositionId",
                table: "Reservations",
                column: "ExpositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_MuseumInfoId",
                table: "Reservations",
                column: "MuseumInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecFunds_DragMetalId",
                table: "SpecFunds",
                column: "DragMetalId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecFunds_WeaponId",
                table: "SpecFunds",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_MuseumInfos_Deletings_DeletingId",
                table: "MuseumInfos",
                column: "DeletingId",
                principalTable: "Deletings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuseumInfos_Edits_EditId",
                table: "MuseumInfos",
                column: "EditId",
                principalTable: "Edits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuseumInfos_Locations_LocationId",
                table: "MuseumInfos",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MuseumInfos_StorageConditions_StorageConditionId",
                table: "MuseumInfos",
                column: "StorageConditionId",
                principalTable: "StorageConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_MuseumInfos_MuseumInfoId",
                table: "UnifPassports",
                column: "MuseumInfoId",
                principalTable: "MuseumInfos",
                principalColumn: "Id");
        }
    }
}
