using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Artha.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "varchar(20)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationCode = table.Column<string>(type: "varchar(20)", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "varchar(50)", nullable: true),
                    Name2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address = table.Column<string>(type: "varchar(100)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(50)", nullable: true),
                    City = table.Column<string>(type: "varchar(30)", nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    PhoneNo2 = table.Column<string>(type: "varchar(30)", nullable: true),
                    FaxNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    Contact = table.Column<string>(type: "varchar(30)", nullable: true),
                    PostCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    EMail = table.Column<string>(type: "varchar(80)", nullable: true),
                    HomePage = table.Column<string>(type: "varchar(80)", nullable: true),
                    CountryRegionCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    UseAsInTransit = table.Column<short>(type: "smallint", nullable: false),
                    RequirePutaway = table.Column<short>(type: "smallint", nullable: false),
                    RequirePick = table.Column<short>(type: "smallint", nullable: false),
                    CrossDockDueDateCalc = table.Column<string>(type: "varchar(30)", nullable: true),
                    UseCrossDocking = table.Column<short>(type: "smallint", nullable: false),
                    RequireReceive = table.Column<short>(type: "smallint", nullable: false),
                    RequireShipment = table.Column<short>(type: "smallint", nullable: false),
                    BinMandatory = table.Column<short>(type: "smallint", nullable: false),
                    DirectedPutawayandPick = table.Column<short>(type: "smallint", nullable: false),
                    DefaultBinSelection = table.Column<int>(type: "int", nullable: false),
                    OutboundWhseHandlingTime = table.Column<string>(type: "varchar(30)", nullable: true),
                    InboundWhseHandlingTime = table.Column<string>(type: "varchar(30)", nullable: true),
                    PutawayTemplateCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    UsePutawayWorksheet = table.Column<short>(type: "smallint", nullable: false),
                    PickAccordingtoFEFO = table.Column<short>(type: "smallint", nullable: false),
                    AllowBreakbulk = table.Column<short>(type: "smallint", nullable: false),
                    BinCapacityPolicy = table.Column<int>(type: "int", nullable: false),
                    OpenShopFloorBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    InboundProductionBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    OutboundProductionBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    AdjustmentBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    AlwaysCreatePutawayLine = table.Column<short>(type: "smallint", nullable: false),
                    AlwaysCreatePickLine = table.Column<short>(type: "smallint", nullable: false),
                    SpecialEquipment = table.Column<int>(type: "int", nullable: false),
                    ReceiptBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    ShipmentBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    CrossDockBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    OutboundBOMBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    InboundBOMBinCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    BaseCalendarCode = table.Column<string>(type: "varchar(30)", nullable: true),
                    UseADCS = table.Column<short>(type: "smallint", nullable: false),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationCode);
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    FirstName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    LastName = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "varchar(30)", nullable: true),
                    Address2 = table.Column<string>(type: "varchar(30)", nullable: true),
                    City = table.Column<string>(type: "varchar(30)", nullable: true),
                    PostCode = table.Column<string>(type: "varchar(20)", nullable: true),
                    HomePhoneNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    WorkPhoneNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    StoreNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(100)", nullable: true),
                    TransVoidingAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    ManagerPrivileges = table.Column<byte>(type: "tinyint", nullable: false),
                    XReportPrintingAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    TenderDeclAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    FloatingDeclAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    PriceOverride = table.Column<int>(type: "int", nullable: false),
                    MaxDiscounttoGivePercent = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    NoVoidOnlyItemCorr = table.Column<byte>(type: "tinyint", nullable: false),
                    TransSuspensAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    MaxTotalDiscountPercent = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    OpenDrawwithoutSale = table.Column<byte>(type: "tinyint", nullable: false),
                    EmploymentType = table.Column<int>(type: "int", nullable: false),
                    FraudSortField = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    NameonReceipt = table.Column<string>(type: "varchar(20)", nullable: true),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    PayrollNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Blocked = table.Column<byte>(type: "tinyint", nullable: false),
                    DatetoBeBlocked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeftHanded = table.Column<byte>(type: "tinyint", nullable: false),
                    SalesPerson = table.Column<string>(type: "varchar(20)", nullable: true),
                    NoSeries = table.Column<string>(type: "varchar(20)", nullable: true),
                    PermissionGroup = table.Column<string>(type: "varchar(20)", nullable: true),
                    ReturninTransaction = table.Column<byte>(type: "tinyint", nullable: false),
                    VoidPrepaymentAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    VoidPrepaymentLineAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    ChangePrepmtAmtAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    AddPrepmtAmtAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoVoidLineAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoPaymentAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoTableTransferAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoSplitBillAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoLayoutSwitchingAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoTableAdjustingAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    NoTableDesigningAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    ContinueonTSerrors = table.Column<byte>(type: "tinyint", nullable: false),
                    LastZReport = table.Column<string>(type: "varchar(20)", nullable: true),
                    POSInterfaceProfile = table.Column<string>(type: "varchar(20)", nullable: true),
                    Language = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateCustomers = table.Column<byte>(type: "tinyint", nullable: false),
                    ViewSaleshistory = table.Column<byte>(type: "tinyint", nullable: false),
                    CustomerComments = table.Column<int>(type: "int", nullable: false),
                    MaxTenderDeclDifference = table.Column<decimal>(type: "decimal(18,5)", nullable: false),
                    MaxWarningCount = table.Column<int>(type: "int", nullable: false),
                    ShowDifferenceinWarning = table.Column<byte>(type: "tinyint", nullable: false),
                    ActionAfterDiffWarning = table.Column<int>(type: "int", nullable: false),
                    CIDReportPrintingAllowed = table.Column<byte>(type: "tinyint", nullable: false),
                    ShowTransAmount = table.Column<byte>(type: "tinyint", nullable: false),
                    UpdateCustomers = table.Column<byte>(type: "tinyint", nullable: false),
                    InventoryActive = table.Column<byte>(type: "tinyint", nullable: false),
                    InventoryMainMenu = table.Column<string>(type: "varchar(20)", nullable: true),
                    RowStatus = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "036bbfd4-1bfd-4975-afb6-fc77c17b3da5", "29b44c09-7dcb-4b46-ae73-95536b95e27f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a7b4700a-afa1-4c8c-b05e-0ddc019c7a21", "a3b67a57-0715-4db9-87dc-5d392afefecb", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
