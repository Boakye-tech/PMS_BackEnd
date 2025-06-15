using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PlotTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyType",
                schema: "est");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 12);

            migrationBuilder.CreateTable(
                name: "PlotType",
                schema: "est",
                columns: table => new
                {
                    PlotTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlotType", x => x.PlotTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SchemeType",
                schema: "est",
                columns: table => new
                {
                    SchemeTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchemeTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchemeType", x => x.SchemeTypeId);
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 1,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "RES", "RESIDENTIAL USE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 2,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "COM", "COMMERCIAL USE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 3,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "IND", "INDUSTRIAL" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 4,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "INS", "INSTITUTIONAL" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 5,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "REC", "RECREATIONAL" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 1,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "Lesse Built Houses", "RPL", "RESIDENTIAL PLOT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 2,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "TDC Built Houses", "HOS", "HOUSE OWNERSHIP SCHEME" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 3,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "Houses by Estates Developer", "LSD", "LARGE SCALE DEVELOPMENT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 4,
                columns: new[] { "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "HSE", "HOUSE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 5,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 1, "FLT", "FLAT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 6,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 1, "HOS", "APARTMENTS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 7,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "CPL", "COMMERCIAL PLOT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 8,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "SHP", "SHOPS & OFFICES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 9,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "LIC", "LICENSE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 10,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "RSP", "RESTAURANTS & PUBS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 11,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "HTL", "GUEST HOUSE & HOTELS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 12,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "PFS", "PETROL FILLING STATION" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 13,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "EVC", "EVENT CENTRES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 14,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "CLH", "CLUB HOUSES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 15,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "WHB", "WASHING BAY" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 16,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 2, "CMS", "CORN MILL SITE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 17,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 3, "IND", "INDUSTRIAL PLOT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 18,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 3, "HIA", "HEAVY INDUSTRIAL ACTIVITIES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 19,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 3, "LIA", "LIGHT INDUSTRIAL ACTIVITIES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 20,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 3, "AGR", "AGRO INDUSTRIAL ACTIVITIES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 21,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 3, "EMT", "EASEMENT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 22,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 4, "INS", "INSTITUTIONAL PLOT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 23,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 4, "SCH", "SCHOOLS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 24,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 4, "CHU", "CHURCHES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 25,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 4, "MOS", "MOSQUES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 26,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 4, "LIB", "LIBRARY" });

            migrationBuilder.InsertData(
                schema: "est",
                table: "LandUseType",
                columns: new[] { "LandUseTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "LandUseId", "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "", "PIN", "PUBLIC INSTITUTIONS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "", "CLI", "CLINICS & HOSPITALS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", "REC", "RECREATIONAL plot", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", "GOC", "GOLF COURSE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", "PLG", "PLAYGROUND", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "", "HOR", "HORTICULTURE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "PlotType",
                columns: new[] { "PlotTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "PlotTypes" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SERVICED PLOT" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PARTIALLY SERVICED PLOT" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNSERVICED PLOT" }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "SchemeType",
                columns: new[] { "SchemeTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "SchemeTypeName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TDC HOUSE OWNERHISP SCHEME" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KPONE AFFORDABLE HOUSE OWNERHISP SCHEME" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RENTAL HOUSE OWNERHISP SCHEME" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlotType_PlotTypes",
                schema: "est",
                table: "PlotType",
                column: "PlotTypes",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SchemeType_SchemeTypeName",
                schema: "est",
                table: "SchemeType",
                column: "SchemeTypeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlotType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "SchemeType",
                schema: "est");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 32);

            migrationBuilder.CreateTable(
                name: "PropertyType",
                schema: "est",
                columns: table => new
                {
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropertyTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.PropertyTypeId);
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 1,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "RPL", "RESIDENTIAL" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 2,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "HOS", "HOUSE OWNERSHIP SCHEME" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 3,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "LSD", "LARGE SCALE DEVELOPMENT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 4,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "HSE", "HOUSE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUse",
                keyColumn: "LandUseId",
                keyValue: 5,
                columns: new[] { "LandUseInitial", "LandUseName" },
                values: new object[] { "FLT", "FLAT" });

            migrationBuilder.InsertData(
                schema: "est",
                table: "LandUse",
                columns: new[] { "LandUseId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "LandUseInitial", "LandUseName", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CPL", "COMMERCIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SHP", "SHOPS & OFFICES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LIC", "LICENSE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IND", "INDUSTRIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMT", "EASEMENT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INS", "INSTITUTIONAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REC", "RECREATIONAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 1,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "", "", "TDC BUILT HOUSES (HOS)" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 2,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "", "", "LESSEE BUILT HOUSES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 3,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "", "", "APARTMENTS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 4,
                columns: new[] { "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { "", "HOUSES BY ESTATE DEVELOPERS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 5,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "SHP", "SHOPS & OFFICES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 6,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "RES", "RESTAURANTS & PUBS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 7,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "HTL", "GUEST HOUSE & HOTELS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 8,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "PFS", "PETROL FILLING STATION" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 9,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "EVT", "EVENT CENTRES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 10,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "CLH", "CLUB HOUSES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 11,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "WHB", "WASHING BAY" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 12,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "CMS", "CORN MILL SITE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 13,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 6, "LIC", "LICENSE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 14,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 9, "HIA", "HEAVY INDUSTRIAL ACTIVITIES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 15,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 9, "LIA", "LIGHT INDUSTRIAL ACTIVITIES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 16,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 9, "AGR", "AGRO INDUSTRIAL ACTIVITIES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 17,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 9, "EMT", "EASEMENT" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 18,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 11, "SCH", "SCHOOLS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 19,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 11, "CHU", "CHURCHES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 20,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 11, "MOS", "MOSQUES" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 21,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 11, "LIB", "LIBRARY" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 22,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 11, "PUB", "PUBLIC INSTITUTIONS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 23,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 11, "CLI", "CLINICS & HOSPITALS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 24,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 12, "GOC", "GOLF COURSE" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 25,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 12, "PLG", "PLAYGROUND" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 26,
                columns: new[] { "LandUseId", "LandUseTypeInitial", "LandUseTypeName" },
                values: new object[] { 12, "HOR", "HORTICULTURE" });

            migrationBuilder.InsertData(
                schema: "est",
                table: "PropertyType",
                columns: new[] { "PropertyTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "PropertyTypes" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SERVICED PLOT" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PARTIALLY SERVICED PLOT" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNSERVICED PLOT" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "H.O.S HOUSE" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "H.O.S APARTMENT" },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SHOP/OFFICE" },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RENTAL HOUSE" },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APARTMENT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertyType_PropertyTypes",
                schema: "est",
                table: "PropertyType",
                column: "PropertyTypes",
                unique: true);
        }
    }
}
