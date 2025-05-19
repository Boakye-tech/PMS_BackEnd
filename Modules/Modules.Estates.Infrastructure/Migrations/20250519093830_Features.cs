using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Features : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                schema: "est",
                columns: table => new
                {
                    FeaturesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Feature = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FloorArea = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.FeaturesId);
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 1,
                column: "CurrencyId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                column: "CurrencyId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                column: "CurrencyId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                column: "CurrencyId",
                value: 2);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 2, 197500f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 2, 286400f });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features",
                schema: "est");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 1,
                column: "CurrencyId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                column: "CurrencyId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                column: "CurrencyId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                column: "CurrencyId",
                value: 1);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 1, 8000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 1, 17000f });
        }
    }
}
