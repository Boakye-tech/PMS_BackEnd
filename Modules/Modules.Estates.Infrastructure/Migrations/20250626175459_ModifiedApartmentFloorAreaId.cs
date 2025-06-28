using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedApartmentFloorAreaId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_ApartmentFeatures_ApartmentTypes_FeaturesId",
            //    schema: "est",
            //    table: "ApartmentFeatures");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Features_ApartmentFeatures_FeaturesId",
            //    schema: "est",
            //    table: "Features");

            //migrationBuilder.DropIndex(
            //    name: "IX_ApartmentFeatures_FeaturesId_FloorArea",
            //    schema: "est",
            //    table: "ApartmentFeatures");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 28);

            migrationBuilder.DropColumn(
                name: "FloorArea",
                schema: "est",
                table: "ApartmentTypes");

            //migrationBuilder.AlterColumn<int>(
            //    name: "FeaturesId",
            //    schema: "est",
            //    table: "Features",
            //    type: "int",
            //    nullable: false,
            //    oldClrType: typeof(int),
            //    oldType: "int")
            //    .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FloorAreaId",
                schema: "est",
                table: "ApartmentTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 1,
                column: "FloorAreaId",
                value: 28);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                column: "FloorAreaId",
                value: 29);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                column: "FloorAreaId",
                value: 30);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                column: "FloorAreaId",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                column: "FloorAreaId",
                value: 25);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                column: "FloorAreaId",
                value: 26);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 18,
                column: "Feature",
                value: "KITCHEN TERRACE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 19,
                column: "Feature",
                value: "LIVING AREA");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 20,
                column: "Feature",
                value: "STUDY");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 21,
                column: "Feature",
                value: "BALCONY");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 22,
                column: "Feature",
                value: "CLOSET SPACE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 23,
                column: "Feature",
                value: "WASHROOM");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 24,
                column: "Feature",
                value: "SHARED WASHROOM");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 25,
                column: "Feature",
                value: "ESCAPE STAIRCASE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 26,
                column: "Feature",
                value: "STAIR HALL");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 27,
                column: "Feature",
                value: "LIFT");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_FloorAreaId",
                schema: "est",
                table: "ApartmentTypes",
                column: "FloorAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFeatures_ApartmentTypeId",
                schema: "est",
                table: "ApartmentFeatures",
                column: "ApartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFeatures_FeaturesId",
                schema: "est",
                table: "ApartmentFeatures",
                column: "FeaturesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeatures_ApartmentTypes_ApartmentTypeId",
                schema: "est",
                table: "ApartmentFeatures",
                column: "ApartmentTypeId",
                principalSchema: "est",
                principalTable: "ApartmentTypes",
                principalColumn: "ApartmentTypeId",
                onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApartmentFeatures_Features_FeaturesId",
            //    schema: "est",
            //    table: "ApartmentFeatures",
            //    column: "FeaturesId",
            //    principalSchema: "est",
            //    principalTable: "Features",
            //    principalColumn: "FeaturesId",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_ApartmentTypes_FloorArea_FloorAreaId",
            //    schema: "est",
            //    table: "ApartmentTypes",
            //    column: "FloorAreaId",
            //    principalSchema: "est",
            //    principalTable: "FloorArea",
            //    principalColumn: "FloorAreaId",
            //    onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeatures_ApartmentTypes_ApartmentTypeId",
                schema: "est",
                table: "ApartmentFeatures");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_ApartmentFeatures_Features_FeaturesId",
            //    schema: "est",
            //    table: "ApartmentFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentTypes_FloorArea_FloorAreaId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentTypes_FloorAreaId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentFeatures_ApartmentTypeId",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentFeatures_FeaturesId",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.DropColumn(
                name: "FloorAreaId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.AlterColumn<int>(
                name: "FeaturesId",
                schema: "est",
                table: "Features",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<double>(
                name: "FloorArea",
                schema: "est",
                table: "ApartmentTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 1,
                column: "FloorArea",
                value: 27.43);

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

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                column: "FloorArea",
                value: 74.799999999999997);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                column: "FloorArea",
                value: 107.0);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                column: "FloorArea",
                value: 218.0);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 18,
                column: "Feature",
                value: "KITCHEN");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 19,
                column: "Feature",
                value: "KITCHEN TERRACE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 20,
                column: "Feature",
                value: "LIVING AREA");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 21,
                column: "Feature",
                value: "STUDY");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 22,
                column: "Feature",
                value: "BALCONY");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 23,
                column: "Feature",
                value: "CLOSET SPACE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 24,
                column: "Feature",
                value: "WASHROOM");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 25,
                column: "Feature",
                value: "SHARED WASHROOM");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 26,
                column: "Feature",
                value: "ESCAPE STAIRCASE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Features",
                keyColumn: "FeaturesId",
                keyValue: 27,
                column: "Feature",
                value: "STAIR HALL");

            migrationBuilder.InsertData(
                schema: "est",
                table: "Features",
                columns: new[] { "FeaturesId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Feature", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LIFT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFeatures_FeaturesId_FloorArea",
                schema: "est",
                table: "ApartmentFeatures",
                columns: new[] { "FeaturesId", "FloorArea" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeatures_ApartmentTypes_FeaturesId",
                schema: "est",
                table: "ApartmentFeatures",
                column: "FeaturesId",
                principalSchema: "est",
                principalTable: "ApartmentTypes",
                principalColumn: "ApartmentTypeId",
                onDelete: ReferentialAction.Restrict);

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
    }
}
