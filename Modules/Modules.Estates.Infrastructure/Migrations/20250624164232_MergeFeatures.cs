using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MergeFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "Feature",
            //    schema: "est",
            //    table: "ApartmentFeatures");

            //migrationBuilder.AlterColumn<int>(
            //    name: "FeaturesId",
            //    schema: "est",
            //    table: "Features",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .OldAnnotation("SqlServer:Identity", "1, 1");

            //migrationBuilder.AddColumn<int>(
            //    name: "FeaturesId",
            //    schema: "est",
            //    table: "ApartmentFeatures",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            migrationBuilder.InsertData(
                schema: "est",
                table: "ApartmentFeatures",
                columns: new[] { "ApartmentFeaturesId", "ApartmentCategory", "ApartmentTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "FeaturesId", "FloorArea", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8.714m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 9.404m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5.108m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4.200m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 9.548m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 15.390m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7.260m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2.125m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1.760m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 1, 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5.04m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 18.480m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 18.480m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7.840m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2.520m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 5.474m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 1, 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7.840m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 13.316m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 13475m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9.875m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 5.900m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2.750m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6.793m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 12.748m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 1.968m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 4.329m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, 1, 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3.650m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, 2, 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, 2, 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, 0m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                column: "FloorArea",
                value: 41.122999999999998);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                column: "FloorArea",
                value: 60.634);

            //migrationBuilder.UpdateData(
            //    schema: "est",
            //    table: "ApartmentTypes",
            //    keyColumn: "ApartmentTypeId",
            //    keyValue: 4,
            //    column: "ApartmentType",
            //    value: "TWO BEDROOM");

            //migrationBuilder.UpdateData(
            //    schema: "est",
            //    table: "ApartmentTypes",
            //    keyColumn: "ApartmentTypeId",
            //    keyValue: 5,
            //    column: "ApartmentType",
            //    value: "TWO BEDROOMS");

            //migrationBuilder.UpdateData(
            //    schema: "est",
            //    table: "ApartmentTypes",
            //    keyColumn: "ApartmentTypeId",
            //    keyValue: 6,
            //    column: "ApartmentType",
            //    value: "THREE BEDROOMS");

            migrationBuilder.InsertData(
                schema: "est",
                table: "Features",
                columns: new[] { "FeaturesId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Feature", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LIVING ROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BEDROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KITCHEN", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SANITARY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "STORE ROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LOBBY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DINING", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ENT. LOBBY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BEDROOM 1", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BEDROOM 2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MASTER BEDROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TERRACE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CORRIDOR", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UTILITY AREA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BOX ROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VISITORS WASH ROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KITCHEN STORE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KITCHEN TERRACE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LIVING AREA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "STUDY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BALCONY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLOSET SPACE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WASHROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SHARED WASHROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ESCAPE STAIRCASE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "STAIR HALL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LIFT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Features_Feature",
            //    schema: "est",
            //    table: "Features",
            //    column: "Feature",
            //    unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_CurrencyId",
                schema: "est",
                table: "ApartmentTypes",
                column: "CurrencyId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_ApartmentFeatures_FeaturesId_FloorArea",
            //    schema: "est",
            //    table: "ApartmentFeatures",
            //    columns: new[] { "FeaturesId", "FloorArea" },
            //    unique: true);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApartmentFeatures_ApartmentTypes_FeaturesId",
            //    schema: "est",
            //    table: "ApartmentFeatures",
            //    column: "FeaturesId",
            //    principalSchema: "est",
            //    principalTable: "ApartmentTypes",
            //    principalColumn: "ApartmentTypeId",
            //    onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentTypes_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "ApartmentTypes",
                column: "CurrencyId",
                principalSchema: "est",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Features_ApartmentFeatures_FeaturesId",
                schema: "est",
                table: "Features",
                column: "FeaturesId",
                principalSchema: "est",
                principalTable: "ApartmentFeatures",
                principalColumn: "ApartmentFeaturesId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeatures_ApartmentTypes_FeaturesId",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentTypes_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_Features_ApartmentFeatures_FeaturesId",
                schema: "est",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_Features_Feature",
                schema: "est",
                table: "Features");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentTypes_CurrencyId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentFeatures_FeaturesId_FloorArea",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ApartmentFeatures",
                keyColumn: "ApartmentFeaturesId",
                keyValue: 28);

            migrationBuilder.DropColumn(
                name: "FeaturesId",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.AlterColumn<int>(
                name: "FeaturesId",
                schema: "est",
                table: "Features",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Feature",
                schema: "est",
                table: "ApartmentFeatures",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                column: "FloorArea",
                value: 41.119999999999997);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                column: "FloorArea",
                value: 60.630000000000003);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                column: "ApartmentType",
                value: "TWO BEDROOMS");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                column: "ApartmentType",
                value: "TWO BEDROOM");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                column: "ApartmentType",
                value: "THREE BEDROOM");
        }
    }
}
