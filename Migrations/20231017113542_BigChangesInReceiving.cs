using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Museum.Migrations
{
    /// <inheritdoc />
    public partial class BigChangesInReceiving : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_TypeId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Receivings_ReceivingId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Receivings_ReceivingId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Receivings_ReceivingId",
                table: "Peoples");

            migrationBuilder.DropForeignKey(
                name: "FK_Providers_Categories_CategoryId",
                table: "Providers");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Currency_CurrencyId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Producers_ProducerId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Providers_ProviderId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Purposes_PurposeId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_ReceiveWays_ReceiveWayId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Statuses_StatusId",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Structures_Receivings_ReceivingId",
                table: "Structures");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Receivings_ReceivingId",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "TimeLimits");

            migrationBuilder.DropIndex(
                name: "IX_Structures_ReceivingId",
                table: "Structures");

            migrationBuilder.DropIndex(
                name: "IX_Providers_CategoryId",
                table: "Providers");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_ReceivingId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Owners_ReceivingId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Events_ReceivingId",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currency",
                table: "Currency");

            migrationBuilder.DropColumn(
                name: "ReceivingId",
                table: "Structures");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Identif",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "PassportDetail",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "TransferAct",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "TransferAgreement",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Сaption",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Connection",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "FullInfo",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ReceivingId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "ReceivingId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "ReceivingId",
                table: "Events");

            migrationBuilder.RenameTable(
                name: "Currency",
                newName: "Currencies");

            migrationBuilder.RenameColumn(
                name: "ReceivingId",
                table: "UnifPassports",
                newName: "Receivingid");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_ReceivingId",
                table: "UnifPassports",
                newName: "IX_UnifPassports_Receivingid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Structures",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Structures",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Statuses",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Statuses",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Receivings",
                newName: "Statusid");

            migrationBuilder.RenameColumn(
                name: "ReceiveWayId",
                table: "Receivings",
                newName: "ReceiveWayid");

            migrationBuilder.RenameColumn(
                name: "PurposeId",
                table: "Receivings",
                newName: "Purposeid");

            migrationBuilder.RenameColumn(
                name: "ProviderId",
                table: "Receivings",
                newName: "Providerid");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Receivings",
                newName: "Producerid");

            migrationBuilder.RenameColumn(
                name: "DescriptionFP",
                table: "Receivings",
                newName: "descriptionFP");

            migrationBuilder.RenameColumn(
                name: "CurrencyId",
                table: "Receivings",
                newName: "Currencyid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Receivings",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_StatusId",
                table: "Receivings",
                newName: "IX_Receivings_Statusid");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_ReceiveWayId",
                table: "Receivings",
                newName: "IX_Receivings_ReceiveWayid");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_PurposeId",
                table: "Receivings",
                newName: "IX_Receivings_Purposeid");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_ProviderId",
                table: "Receivings",
                newName: "IX_Receivings_Providerid");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_ProducerId",
                table: "Receivings",
                newName: "IX_Receivings_Producerid");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_CurrencyId",
                table: "Receivings",
                newName: "IX_Receivings_Currencyid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ReceiveWays",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ReceiveWays",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Purposes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Purposes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Providers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Providers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Producers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Peoples",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Peoples",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ShortInfo",
                table: "Peoples",
                newName: "info");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Owners",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Owners",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EventTypes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EventTypes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Events",
                newName: "Typeid");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Events",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitute",
                table: "Events",
                newName: "latitute");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Events",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Events",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Events",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Events_TypeId",
                table: "Events",
                newName: "IX_Events_Typeid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Currencies",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Currencies",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "Ownerid",
                table: "Receivings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "id");

            migrationBuilder.CreateTable(
                name: "EventReceiving",
                columns: table => new
                {
                    eventsid = table.Column<int>(type: "int", nullable: false),
                    receivingsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventReceiving", x => new { x.eventsid, x.receivingsid });
                    table.ForeignKey(
                        name: "FK_EventReceiving_Events_eventsid",
                        column: x => x.eventsid,
                        principalTable: "Events",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventReceiving_Receivings_receivingsid",
                        column: x => x.receivingsid,
                        principalTable: "Receivings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PeopleReceiving",
                columns: table => new
                {
                    peoplesid = table.Column<int>(type: "int", nullable: false),
                    receivingsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleReceiving", x => new { x.peoplesid, x.receivingsid });
                    table.ForeignKey(
                        name: "FK_PeopleReceiving_Peoples_peoplesid",
                        column: x => x.peoplesid,
                        principalTable: "Peoples",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleReceiving_Receivings_receivingsid",
                        column: x => x.receivingsid,
                        principalTable: "Receivings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceivingStructure",
                columns: table => new
                {
                    receivingsid = table.Column<int>(type: "int", nullable: false),
                    structuresid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivingStructure", x => new { x.receivingsid, x.structuresid });
                    table.ForeignKey(
                        name: "FK_ReceivingStructure_Receivings_receivingsid",
                        column: x => x.receivingsid,
                        principalTable: "Receivings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceivingStructure_Structures_structuresid",
                        column: x => x.structuresid,
                        principalTable: "Structures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Receivings_Ownerid",
                table: "Receivings",
                column: "Ownerid");

            migrationBuilder.CreateIndex(
                name: "IX_EventReceiving_receivingsid",
                table: "EventReceiving",
                column: "receivingsid");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleReceiving_receivingsid",
                table: "PeopleReceiving",
                column: "receivingsid");

            migrationBuilder.CreateIndex(
                name: "IX_ReceivingStructure_structuresid",
                table: "ReceivingStructure",
                column: "structuresid");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_Typeid",
                table: "Events",
                column: "Typeid",
                principalTable: "EventTypes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Currencies_Currencyid",
                table: "Receivings",
                column: "Currencyid",
                principalTable: "Currencies",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Owners_Ownerid",
                table: "Receivings",
                column: "Ownerid",
                principalTable: "Owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Producers_Producerid",
                table: "Receivings",
                column: "Producerid",
                principalTable: "Producers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Providers_Providerid",
                table: "Receivings",
                column: "Providerid",
                principalTable: "Providers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Purposes_Purposeid",
                table: "Receivings",
                column: "Purposeid",
                principalTable: "Purposes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_ReceiveWays_ReceiveWayid",
                table: "Receivings",
                column: "ReceiveWayid",
                principalTable: "ReceiveWays",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Statuses_Statusid",
                table: "Receivings",
                column: "Statusid",
                principalTable: "Statuses",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Receivings_Receivingid",
                table: "UnifPassports",
                column: "Receivingid",
                principalTable: "Receivings",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_EventTypes_Typeid",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Currencies_Currencyid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Owners_Ownerid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Producers_Producerid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Providers_Providerid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Purposes_Purposeid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_ReceiveWays_ReceiveWayid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_Receivings_Statuses_Statusid",
                table: "Receivings");

            migrationBuilder.DropForeignKey(
                name: "FK_UnifPassports_Receivings_Receivingid",
                table: "UnifPassports");

            migrationBuilder.DropTable(
                name: "EventReceiving");

            migrationBuilder.DropTable(
                name: "PeopleReceiving");

            migrationBuilder.DropTable(
                name: "ReceivingStructure");

            migrationBuilder.DropIndex(
                name: "IX_Receivings_Ownerid",
                table: "Receivings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Ownerid",
                table: "Receivings");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "Receivingid",
                table: "UnifPassports",
                newName: "ReceivingId");

            migrationBuilder.RenameIndex(
                name: "IX_UnifPassports_Receivingid",
                table: "UnifPassports",
                newName: "IX_UnifPassports_ReceivingId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Structures",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Structures",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Statuses",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Statuses",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "descriptionFP",
                table: "Receivings",
                newName: "DescriptionFP");

            migrationBuilder.RenameColumn(
                name: "Statusid",
                table: "Receivings",
                newName: "StatusId");

            migrationBuilder.RenameColumn(
                name: "ReceiveWayid",
                table: "Receivings",
                newName: "ReceiveWayId");

            migrationBuilder.RenameColumn(
                name: "Purposeid",
                table: "Receivings",
                newName: "PurposeId");

            migrationBuilder.RenameColumn(
                name: "Providerid",
                table: "Receivings",
                newName: "ProviderId");

            migrationBuilder.RenameColumn(
                name: "Producerid",
                table: "Receivings",
                newName: "ProducerId");

            migrationBuilder.RenameColumn(
                name: "Currencyid",
                table: "Receivings",
                newName: "CurrencyId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Receivings",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_Statusid",
                table: "Receivings",
                newName: "IX_Receivings_StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_ReceiveWayid",
                table: "Receivings",
                newName: "IX_Receivings_ReceiveWayId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_Purposeid",
                table: "Receivings",
                newName: "IX_Receivings_PurposeId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_Providerid",
                table: "Receivings",
                newName: "IX_Receivings_ProviderId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_Producerid",
                table: "Receivings",
                newName: "IX_Receivings_ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Receivings_Currencyid",
                table: "Receivings",
                newName: "IX_Receivings_CurrencyId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ReceiveWays",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ReceiveWays",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Purposes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Purposes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Providers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Providers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Producers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Peoples",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Peoples",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "info",
                table: "Peoples",
                newName: "ShortInfo");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Owners",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Owners",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "EventTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "EventTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Events",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitute",
                table: "Events",
                newName: "Latitute");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Events",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Events",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Typeid",
                table: "Events",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Events",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Events_Typeid",
                table: "Events",
                newName: "IX_Events_TypeId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Currency",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Currency",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "ReceivingId",
                table: "Structures",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Providers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Identif",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Providers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "PassportDetail",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "TransferAct",
                table: "Providers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "TransferAgreement",
                table: "Providers",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "Сaption",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Connection",
                table: "Peoples",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Peoples",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "FullInfo",
                table: "Peoples",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReceivingId",
                table: "Peoples",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceivingId",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReceivingId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currency",
                table: "Currency",
                column: "Id");

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
                name: "TimeLimits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CloseTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CopyrightPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShelfLifeEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeLimits", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Structures_ReceivingId",
                table: "Structures",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Providers_CategoryId",
                table: "Providers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_ReceivingId",
                table: "Peoples",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ReceivingId",
                table: "Owners",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_ReceivingId",
                table: "Events",
                column: "ReceivingId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_PeopleId",
                table: "Links",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ProviderId",
                table: "Links",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_EventTypes_TypeId",
                table: "Events",
                column: "TypeId",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Receivings_ReceivingId",
                table: "Events",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Receivings_ReceivingId",
                table: "Owners",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Receivings_ReceivingId",
                table: "Peoples",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Providers_Categories_CategoryId",
                table: "Providers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_Receivings_Providers_ProviderId",
                table: "Receivings",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Purposes_PurposeId",
                table: "Receivings",
                column: "PurposeId",
                principalTable: "Purposes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_ReceiveWays_ReceiveWayId",
                table: "Receivings",
                column: "ReceiveWayId",
                principalTable: "ReceiveWays",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Receivings_Statuses_StatusId",
                table: "Receivings",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Structures_Receivings_ReceivingId",
                table: "Structures",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UnifPassports_Receivings_ReceivingId",
                table: "UnifPassports",
                column: "ReceivingId",
                principalTable: "Receivings",
                principalColumn: "Id");
        }
    }
}
