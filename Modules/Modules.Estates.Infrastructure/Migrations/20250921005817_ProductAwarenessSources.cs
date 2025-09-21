using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ProductAwarenessSources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductAwarenessSources",
                schema: "est",
                columns: table => new
                {
                    ProductAwarenessSourcesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductAwarenessSource = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAwarenessSources", x => x.ProductAwarenessSourcesId);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "ProductAwarenessSources",
                columns: new[] { "ProductAwarenessSourcesId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "ProductAwarenessSource" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TELEVISION" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RADIO" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NEWSPAPERS" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INTERNET" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ONLINE ADS" },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WORD OF MOUTH" },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SOCIAL MEDIA" },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TDC OFFICIAL WEBSITE" },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TDC STAFF" },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TDC CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 1,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 2, 17500f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 2,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 2, 8000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 3,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 2, 22000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 4,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 2, 24000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 5,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 1, 8000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 6,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 1, 10000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 7,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 1, 12000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 8,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 2, 2140f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 9,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 2, 865f });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAwarenessSources_ProductAwarenessSource",
                schema: "est",
                table: "ProductAwarenessSources",
                column: "ProductAwarenessSource",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAwarenessSources",
                schema: "est");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 1,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 2,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 3,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 4,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 5,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 6,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 7,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 8,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Types",
                keyColumn: "TypeId",
                keyValue: 9,
                columns: new[] { "CurrencyId", "Price" },
                values: new object[] { 0, 0f });
        }
    }
}
