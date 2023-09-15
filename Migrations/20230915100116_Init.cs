using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

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
                name: "Classifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemsGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassifName = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    RefferTo = table.Column<int>(type: "int", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                name: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    lenght = table.Column<float>(type: "real", nullable: false),
                    LenghtUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    WidthUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    HeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diameter = table.Column<float>(type: "real", nullable: false),
                    DiameterUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thickness = table.Column<float>(type: "real", nullable: false),
                    ThicknessUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    WeightUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WallThickness = table.Column<float>(type: "real", nullable: false),
                    WallThicknessUnit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimentions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DragMetals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DragMetalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Probe = table.Column<int>(type: "int", nullable: false),
                    WeightGramm = table.Column<float>(type: "real", nullable: false),
                    WeightKarat = table.Column<float>(type: "real", nullable: false),
                    ProbeActScan = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DragMetals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Edits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exhibitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibitions", x => x.Id);
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
                name: "Funds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funds", x => x.Id);
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
                name: "ImageRights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageRights", x => x.Id);
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
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NegativeNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToxicityRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExhibitionRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportationRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreatmentRec = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceiveWays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceiveWays", x => x.Id);
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
                name: "Researches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Researches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    Temperature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InSafe = table.Column<bool>(type: "bit", nullable: false),
                    Safe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Humidity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Light = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageConditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimeLimits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CopyrightPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CloseTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublishFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShelfLifeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLimits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsMuseumWeapon = table.Column<bool>(type: "bit", nullable: false),
                    IsPartOfWeapon = table.Column<bool>(type: "bit", nullable: false),
                    PartOfWeaponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAmmo = table.Column<bool>(type: "bit", nullable: false),
                    AmmoName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MMG = table.Column<bool>(type: "bit", nullable: false),
                    PassportScan = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ExpertizionScan = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Providers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Identif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Сaption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransferAgreement = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TransferAct = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Providers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Providers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FundId = table.Column<int>(type: "int", nullable: false),
                    IsComplex = table.Column<bool>(type: "bit", nullable: false),
                    FullDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecodingId = table.Column<int>(type: "int", nullable: false),
                    DSTUSize = table.Column<float>(type: "real", nullable: false),
                    Restavration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SimilarItems = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    genderId = table.Column<int>(type: "int", nullable: false),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thanks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailInfos_Classifications_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfos_Decodings_DecodingId",
                        column: x => x.DecodingId,
                        principalTable: "Decodings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfos_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfos_Funds_FundId",
                        column: x => x.FundId,
                        principalTable: "Funds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailInfos_Genders_genderId",
                        column: x => x.genderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    Photographer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CopyrightHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageRightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_ImageRights_ImageRightId",
                        column: x => x.ImageRightId,
                        principalTable: "ImageRights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscripts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InscriptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
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
                    StampName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MarkingId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsOnExhibition = table.Column<bool>(type: "bit", nullable: false),
                    IsOnExposition = table.Column<bool>(type: "bit", nullable: false),
                    IsOnStorage = table.Column<bool>(type: "bit", nullable: false),
                    StorageId = table.Column<int>(type: "int", nullable: false),
                    Closet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shelf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Box = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    DragMetalId = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Receivings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiveWayId = table.Column<int>(type: "int", nullable: false),
                    PurposeId = table.Column<int>(type: "int", nullable: false),
                    ReceiptAct = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReceiptAgreement = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceAct = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProducersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receivings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receivings_Producers_ProducersId",
                        column: x => x.ProducersId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receivings_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receivings_Purposes_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "Purposes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receivings_ReceiveWays_ReceiveWayId",
                        column: x => x.ReceiveWayId,
                        principalTable: "ReceiveWays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receivings_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    countryId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true)
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
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Collections_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DetLinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true)
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
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Groups_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "KeyWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Meaning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WIKILink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyWords_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Deletings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOnly = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeletingAct = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deletings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deletings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitute = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_EventTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "EventTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owners_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Peoples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Connection = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peoples", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peoples_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Structures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Structures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Structures_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MuseumInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StorageConditionId = table.Column<int>(type: "int", nullable: false),
                    DeletingId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    EditId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuseumInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MuseumInfos_Deletings_DeletingId",
                        column: x => x.DeletingId,
                        principalTable: "Deletings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuseumInfos_Edits_EditId",
                        column: x => x.EditId,
                        principalTable: "Edits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuseumInfos_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MuseumInfos_StorageConditions_StorageConditionId",
                        column: x => x.StorageConditionId,
                        principalTable: "StorageConditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeopleId = table.Column<int>(type: "int", nullable: true),
                    ProviderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Peoples_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Peoples",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Links_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Checks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckTypeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChekerId = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_Checks_Users_ChekerId",
                        column: x => x.ChekerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ItemDamages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscovererId = table.Column<int>(type: "int", nullable: false),
                    RecommendationId = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true)
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
                        name: "FK_ItemDamages_Users_DiscovererId",
                        column: x => x.DiscovererId,
                        principalTable: "Users",
                        principalColumn: "Id",
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
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsideWork = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true)
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
                name: "UnifPassports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailInfoId = table.Column<int>(type: "int", nullable: true),
                    MuseumInfoId = table.Column<int>(type: "int", nullable: true),
                    MediaId = table.Column<int>(type: "int", nullable: true),
                    ReceivingId = table.Column<int>(type: "int", nullable: true),
                    ComplexId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnifPassports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnifPassports_Complexes_ComplexId",
                        column: x => x.ComplexId,
                        principalTable: "Complexes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UnifPassports_DetailInfos_DetailInfoId",
                        column: x => x.DetailInfoId,
                        principalTable: "DetailInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UnifPassports_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UnifPassports_MuseumInfos_MuseumInfoId",
                        column: x => x.MuseumInfoId,
                        principalTable: "MuseumInfos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UnifPassports_Receivings_ReceivingId",
                        column: x => x.ReceivingId,
                        principalTable: "Receivings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Acceptances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryN = table.Column<int>(type: "int", nullable: false),
                    InsideN = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSpecFond = table.Column<bool>(type: "bit", nullable: false),
                    IsWeapon = table.Column<bool>(type: "bit", nullable: false),
                    IsDragMetal = table.Column<bool>(type: "bit", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnifPassportId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acceptances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acceptances_UnifPassports_UnifPassportId",
                        column: x => x.UnifPassportId,
                        principalTable: "UnifPassports",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Acceptances_AcceptanceId",
                        column: x => x.AcceptanceId,
                        principalTable: "Acceptances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Acceptances_AcceptanceId",
                        column: x => x.AcceptanceId,
                        principalTable: "Acceptances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Techniques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techniques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Techniques_Acceptances_AcceptanceId",
                        column: x => x.AcceptanceId,
                        principalTable: "Acceptances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acceptances_UnifPassportId",
                table: "Acceptances",
                column: "UnifPassportId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_CheckTypeId",
                table: "Checks",
                column: "CheckTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_ChekerId",
                table: "Checks",
                column: "ChekerId");

            migrationBuilder.CreateIndex(
                name: "IX_Checks_MuseumInfoId",
                table: "Checks",
                column: "MuseumInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_countryId",
                table: "Cities",
                column: "countryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DetailInfoId",
                table: "Cities",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Collections_DetailInfoId",
                table: "Collections",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Deletings_UserId",
                table: "Deletings",
                column: "UserId");

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
                name: "IX_DetailInfos_FundId",
                table: "DetailInfos",
                column: "FundId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailInfos_genderId",
                table: "DetailInfos",
                column: "genderId");

            migrationBuilder.CreateIndex(
                name: "IX_DetLinks_DetailInfoId",
                table: "DetLinks",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ReceivingId",
                table: "Events",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_TypeId",
                table: "Events",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_DetailInfoId",
                table: "Groups",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ImageRightId",
                table: "Images",
                column: "ImageRightId");

            migrationBuilder.CreateIndex(
                name: "IX_Inscripts_MarkingId",
                table: "Inscripts",
                column: "MarkingId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDamages_DiscovererId",
                table: "ItemDamages",
                column: "DiscovererId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDamages_MuseumInfoId",
                table: "ItemDamages",
                column: "MuseumInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemDamages_RecommendationId",
                table: "ItemDamages",
                column: "RecommendationId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyWords_DetailInfoId",
                table: "KeyWords",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PeopleId",
                table: "Links",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ProviderId",
                table: "Links",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_StorageId",
                table: "Locations",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_AcceptanceId",
                table: "Materials",
                column: "AcceptanceId");

            migrationBuilder.CreateIndex(
                name: "IX_MuseumInfos_DeletingId",
                table: "MuseumInfos",
                column: "DeletingId");

            migrationBuilder.CreateIndex(
                name: "IX_MuseumInfos_EditId",
                table: "MuseumInfos",
                column: "EditId");

            migrationBuilder.CreateIndex(
                name: "IX_MuseumInfos_LocationId",
                table: "MuseumInfos",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_MuseumInfos_StorageConditionId",
                table: "MuseumInfos",
                column: "StorageConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ReceivingId",
                table: "Owners",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ReceivingId",
                table: "Peoples",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_CategoryId",
                table: "Providers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_ProducersId",
                table: "Receivings",
                column: "ProducersId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_ProviderId",
                table: "Receivings",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_PurposeId",
                table: "Receivings",
                column: "PurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_ReceiveWayId",
                table: "Receivings",
                column: "ReceiveWayId");

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_StatusId",
                table: "Receivings",
                column: "StatusId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Stamps_MarkingId",
                table: "Stamps",
                column: "MarkingId");

            migrationBuilder.CreateIndex(
                name: "IX_States_AcceptanceId",
                table: "States",
                column: "AcceptanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Structures_ReceivingId",
                table: "Structures",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_DetailInfoId",
                table: "Tags",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Techniques_AcceptanceId",
                table: "Techniques",
                column: "AcceptanceId");

            migrationBuilder.CreateIndex(
                name: "IX_UnifPassports_ComplexId",
                table: "UnifPassports",
                column: "ComplexId");

            migrationBuilder.CreateIndex(
                name: "IX_UnifPassports_DetailInfoId",
                table: "UnifPassports",
                column: "DetailInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UnifPassports_MediaId",
                table: "UnifPassports",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_UnifPassports_MuseumInfoId",
                table: "UnifPassports",
                column: "MuseumInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_UnifPassports_ReceivingId",
                table: "UnifPassports",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Audios");

            migrationBuilder.DropTable(
                name: "Checks");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "DetLinks");

            migrationBuilder.DropTable(
                name: "Dimentions");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Inscripts");

            migrationBuilder.DropTable(
                name: "ItemDamages");

            migrationBuilder.DropTable(
                name: "KeyWords");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Researches");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "SpecFunds");

            migrationBuilder.DropTable(
                name: "Stamps");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Structures");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Techniques");

            migrationBuilder.DropTable(
                name: "TimeLimits");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "CheckTypes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "EventTypes");

            migrationBuilder.DropTable(
                name: "ImageRights");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Peoples");

            migrationBuilder.DropTable(
                name: "Exhibitions");

            migrationBuilder.DropTable(
                name: "Exposition");

            migrationBuilder.DropTable(
                name: "DragMetals");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Markings");

            migrationBuilder.DropTable(
                name: "Acceptances");

            migrationBuilder.DropTable(
                name: "UnifPassports");

            migrationBuilder.DropTable(
                name: "Complexes");

            migrationBuilder.DropTable(
                name: "DetailInfos");

            migrationBuilder.DropTable(
                name: "Medias");

            migrationBuilder.DropTable(
                name: "MuseumInfos");

            migrationBuilder.DropTable(
                name: "Receivings");

            migrationBuilder.DropTable(
                name: "Classifications");

            migrationBuilder.DropTable(
                name: "Decodings");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Funds");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Deletings");

            migrationBuilder.DropTable(
                name: "Edits");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "StorageConditions");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "Providers");

            migrationBuilder.DropTable(
                name: "Purposes");

            migrationBuilder.DropTable(
                name: "ReceiveWays");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
