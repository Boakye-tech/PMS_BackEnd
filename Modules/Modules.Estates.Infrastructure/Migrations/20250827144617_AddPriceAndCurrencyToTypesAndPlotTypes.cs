using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceAndCurrencyToTypesAndPlotTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "est",
                table: "Types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Price",
                schema: "est",
                table: "Types",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "est",
                table: "PlotType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SellingPrice",
                schema: "est",
                table: "PlotType",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PlotType",
                keyColumn: "PlotTypeId",
                keyValue: 1,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 2, 24000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PlotType",
                keyColumn: "PlotTypeId",
                keyValue: 2,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 2, 12000f });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PlotType",
                keyColumn: "PlotTypeId",
                keyValue: 3,
                columns: new[] { "CurrencyId", "SellingPrice" },
                values: new object[] { 1, 15000f });

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

            migrationBuilder.CreateIndex(
                name: "IX_Types_CurrencyId",
                schema: "est",
                table: "Types",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PlotType_CurrencyId",
                schema: "est",
                table: "PlotType",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlotType_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PlotType",
                column: "CurrencyId",
                principalSchema: "est",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Types_CurrencyExchangeRate_CurrencyId",
            //    schema: "est",
            //    table: "Types",
            //    column: "CurrencyId",
            //    principalSchema: "est",
            //    principalTable: "CurrencyExchangeRate",
            //    principalColumn: "CurrencyId",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlotType_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PlotType");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Types_CurrencyExchangeRate_CurrencyId",
            //    schema: "est",
            //    table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Types_CurrencyId",
                schema: "est",
                table: "Types");

            migrationBuilder.DropIndex(
                name: "IX_PlotType_CurrencyId",
                schema: "est",
                table: "PlotType");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "est",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "Price",
                schema: "est",
                table: "Types");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "est",
                table: "PlotType");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                schema: "est",
                table: "PlotType");
        }
    }
}
