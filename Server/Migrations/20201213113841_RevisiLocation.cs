using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Artha.Server.Migrations
{
    public partial class RevisiLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "CountryID");

            migrationBuilder.CreateTable(
                name: "FixedAsset",
                columns: table => new
                {
                    FixedAssetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "varchar(20)", nullable: false),
                    Description = table.Column<string>(type: "varchar(30)", nullable: true),
                    SearchDescription = table.Column<string>(type: "varchar(30)", nullable: true),
                    Description2 = table.Column<string>(type: "varchar(30)", nullable: true),
                    FAClassCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    FASubclassCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    GlobalDimension1Code = table.Column<string>(type: "varchar(20)", nullable: true),
                    GlobalDimension2Code = table.Column<string>(type: "varchar(20)", nullable: true),
                    LocationCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    FALocationCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    VendorNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    MainAssetComponent = table.Column<int>(type: "int", nullable: false),
                    ComponentofMainAsset = table.Column<string>(type: "varchar(20)", nullable: true),
                    BudgetedAsset = table.Column<byte>(type: "tinyint", nullable: false),
                    WarrantyDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponsibleEmployee = table.Column<string>(type: "varchar(20)", nullable: true),
                    SerialNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    Blocked = table.Column<byte>(type: "tinyint", nullable: false),
                    FileNamePicture = table.Column<string>(type: "varchar(100)", nullable: true),
                    MaintenanceVendorNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    UnderMaintenance = table.Column<byte>(type: "tinyint", nullable: false),
                    NextServiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NoSeries = table.Column<string>(type: "varchar(20)", nullable: true),
                    FAPostingGroup = table.Column<string>(type: "varchar(20)", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedAsset", x => x.FixedAssetID);
                });

            migrationBuilder.CreateTable(
                name: "TransferRoute",
                columns: table => new
                {
                    TransferRouteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransferfromCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    TransfertoCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    InTransitCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    ShippingAgentCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    ShippingAgentServiceCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    JarakTempuh = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    BiayaToll = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    BiayaBBM = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    Retribusi = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    BiayaLainLain = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferRoute", x => x.TransferRouteID);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "CountryID", "Code", "CreatedBy", "CreatedTime", "LastModifiedBy", "LastModifiedTime", "Name", "RowStatus" },
                values: new object[] { 1, "", "System", new DateTime(2020, 12, 13, 11, 38, 41, 93, DateTimeKind.Utc).AddTicks(1040), "", new DateTime(2020, 12, 13, 19, 38, 41, 92, DateTimeKind.Local).AddTicks(8539), "Indonesia", (short)0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixedAsset");

            migrationBuilder.DropTable(
                name: "TransferRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "LocationCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryID");
        }
    }
}
