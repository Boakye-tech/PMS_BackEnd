using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNullableToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_ApartmentTypes_ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockNumber_BlockNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockSides_BlockSideId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockTypes_BlockTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockUnit_BlockUnitId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PlotType_PlotTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PropertyHeight_PropertyHeightId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_RentalType_RentalTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_SchemeType_SchemeTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_Sites_SiteId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SiteId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SchemeTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlotTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlockUnitId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlockTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlockSideId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_ApartmentTypes_ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentTypeId",
                principalSchema: "est",
                principalTable: "ApartmentTypes",
                principalColumn: "ApartmentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockNumber_BlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockNumberId",
                principalSchema: "est",
                principalTable: "BlockNumber",
                principalColumn: "BlockNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockSides_BlockSideId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockSideId",
                principalSchema: "est",
                principalTable: "BlockSides",
                principalColumn: "SideId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockTypes_BlockTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockTypeId",
                principalSchema: "est",
                principalTable: "BlockTypes",
                principalColumn: "BlockTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockUnit_BlockUnitId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockUnitId",
                principalSchema: "est",
                principalTable: "BlockUnit",
                principalColumn: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PlotType_PlotTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "PlotTypeId",
                principalSchema: "est",
                principalTable: "PlotType",
                principalColumn: "PlotTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PropertyHeight_PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyHeightId",
                principalSchema: "est",
                principalTable: "PropertyHeight",
                principalColumn: "PropertyHeightId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalCategoryId",
                principalSchema: "est",
                principalTable: "RentalCategory",
                principalColumn: "RentalCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_RentalType_RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalTypeId",
                principalSchema: "est",
                principalTable: "RentalType",
                principalColumn: "RentalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_SchemeType_SchemeTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "SchemeTypeId",
                principalSchema: "est",
                principalTable: "SchemeType",
                principalColumn: "SchemeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_Sites_SiteId",
                schema: "est",
                table: "PropertyMaster",
                column: "SiteId",
                principalSchema: "est",
                principalTable: "Sites",
                principalColumn: "SitesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_ApartmentTypes_ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockNumber_BlockNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockSides_BlockSideId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockTypes_BlockTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_BlockUnit_BlockUnitId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PlotType_PlotTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PropertyHeight_PropertyHeightId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_RentalType_RentalTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_SchemeType_SchemeTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_Sites_SiteId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SiteId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SchemeTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlotTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlockUnitId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlockTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlockSideId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_ApartmentTypes_ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentTypeId",
                principalSchema: "est",
                principalTable: "ApartmentTypes",
                principalColumn: "ApartmentTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockNumber_BlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockNumberId",
                principalSchema: "est",
                principalTable: "BlockNumber",
                principalColumn: "BlockNumberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockSides_BlockSideId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockSideId",
                principalSchema: "est",
                principalTable: "BlockSides",
                principalColumn: "SideId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockTypes_BlockTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockTypeId",
                principalSchema: "est",
                principalTable: "BlockTypes",
                principalColumn: "BlockTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_BlockUnit_BlockUnitId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockUnitId",
                principalSchema: "est",
                principalTable: "BlockUnit",
                principalColumn: "UnitId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PlotType_PlotTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "PlotTypeId",
                principalSchema: "est",
                principalTable: "PlotType",
                principalColumn: "PlotTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PropertyHeight_PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyHeightId",
                principalSchema: "est",
                principalTable: "PropertyHeight",
                principalColumn: "PropertyHeightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalCategoryId",
                principalSchema: "est",
                principalTable: "RentalCategory",
                principalColumn: "RentalCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_RentalType_RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalTypeId",
                principalSchema: "est",
                principalTable: "RentalType",
                principalColumn: "RentalTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_SchemeType_SchemeTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "SchemeTypeId",
                principalSchema: "est",
                principalTable: "SchemeType",
                principalColumn: "SchemeTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_Sites_SiteId",
                schema: "est",
                table: "PropertyMaster",
                column: "SiteId",
                principalSchema: "est",
                principalTable: "Sites",
                principalColumn: "SitesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
