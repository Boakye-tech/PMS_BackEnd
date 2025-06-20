using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TypesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApartmentBlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CadastralPlanNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CostPrice",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DebtorType",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FloorArea",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherPropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RentalType",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RightOfEntry",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RoomsOccupied",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "SellingPrice",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "SitePlanNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalNumberOfRooms",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingRate",
                schema: "est",
                table: "CurrencyExchangeRate",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyingRate",
                schema: "est",
                table: "CurrencyExchangeRate",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Types",
                schema: "est",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RentalCategoryId = table.Column<int>(type: "int", nullable: false),
                    RentalTypeId = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                    table.ForeignKey(
                        name: "FK_Types_RentalCategory_RentalCategoryId",
                        column: x => x.RentalCategoryId,
                        principalSchema: "est",
                        principalTable: "RentalCategory",
                        principalColumn: "RentalCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Types_RentalType_RentalTypeId",
                        column: x => x.RentalTypeId,
                        principalSchema: "est",
                        principalTable: "RentalType",
                        principalColumn: "RentalTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "Types",
                columns: new[] { "TypeId", "Code", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Features", "ModifiedBy", "ModifiedOn", "Notes", "RentalCategoryId", "RentalTypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "BB50", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"2 bedrooms\",\"1 livingRoom\",\"private kitchen\",\"private toilet\",\"private bath\",\"1 garage\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Spacious layout with attached garage and private kitchen.", 1, 3, "BB50 - 2 Bedroom House with Garage" },
                    { 2, "IRO8", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"1 bedrooms\",\"shared toilet\",\"shared bath\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Affordable housing for low-income earners, shared facilities.", 1, 1, "IRO8 - Single Room Low-Income Unit" },
                    { 3, "RRT87", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"3 bedrooms\",\"1 livingRoom\",\"kitchen\",\"private toilet\",\"private bath\",\"0 garage\",\"storeRoom\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Typical 3-bedroom family house with kitchen and living area.", 1, 3, "RRT87 - 3 Bedroom Standard House" },
                    { 4, "YYU9", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"3 bedrooms\",\"1 livingRoom\",\"kitchen\",\"private toilet\",\"private bath\",\"2 garage\",\"storeRoom\",\"lobby\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Premium family house with dual garages and ample storage space.", 1, 4, "YYU9 - 3 Bedroom House with 2 Garages" },
                    { 5, "FLAT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"1 bedrooms\",\"1 livingRoom\",\"private kitchen\",\"private toilet\",\"private bath\",\"0 garage\",\"storeRoom\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ideal for singles or couples. Compact but complete flat unit.", 3, 13, "1-Bedroom Self-Contained Flat" },
                    { 6, "A1", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"30 usableAreaSqm\",\"shared toilet\",\"shared bath\",\"PaidInternet\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shared washroom, tiled floor, suitable for shop or office.", 2, 9, "A1 - Community Commercial Unit" },
                    { 7, "B2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"45 usableAreaSqm\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tenant to install internal partitions, ceiling, toilet. Power available.", 2, 7, "B2 - Shell Commercial Unit" },
                    { 8, "C3", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"25 usableAreaSqm\",\"shared toilet\",\"shared bath\",\"airConditioned\",\"internetReady\",\"furnished\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Includes reception, conference room, cleaning, utilities, WiFi. Ideal for professionals/startups.", 2, 10, "C3 - Serviced Office Suite" },
                    { 9, "D4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "[\"35 usableAreaSqm\",\"private toilet\",\"private bath\",\"airConditioned\",\"internetReady\",\"furnished\"]", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tiled floor, private toilet, retail shelving, ceiling fan, lockable shutters.", 2, 11, "D4 - Retail Shop Unit" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Types_Code",
                schema: "est",
                table: "Types",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Types_RentalCategoryId",
                schema: "est",
                table: "Types",
                column: "RentalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_RentalTypeId",
                schema: "est",
                table: "Types",
                column: "RentalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_TypeName",
                schema: "est",
                table: "Types",
                column: "TypeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Types",
                schema: "est");

            migrationBuilder.DropColumn(
                name: "ApartmentBlockNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "CadastralPlanNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "CostPrice",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "DebtorType",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "FloorArea",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "FloorNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "MotherPropertyNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RentalType",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RightOfEntry",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RoomsOccupied",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "SellingPrice",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "SitePlanNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "TotalNumberOfRooms",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingRate",
                schema: "est",
                table: "CurrencyExchangeRate",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyingRate",
                schema: "est",
                table: "CurrencyExchangeRate",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
