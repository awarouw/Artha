using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Artha.Server.Migrations
{
    public partial class RevisiCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                columns: new[] { "Code", "CreatedTime", "LastModifiedTime" },
                values: new object[] { "ID", new DateTime(2020, 12, 13, 12, 12, 32, 904, DateTimeKind.Utc).AddTicks(2626), new DateTime(2020, 12, 13, 20, 12, 32, 904, DateTimeKind.Local).AddTicks(65) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "CountryID",
                keyValue: 1,
                columns: new[] { "Code", "CreatedTime", "LastModifiedTime" },
                values: new object[] { "", new DateTime(2020, 12, 13, 11, 38, 41, 93, DateTimeKind.Utc).AddTicks(1040), new DateTime(2020, 12, 13, 19, 38, 41, 92, DateTimeKind.Local).AddTicks(8539) });
        }
    }
}
