using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRentalFeeToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RentalFee",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_CustomerMaster_CustomerCode",
                schema: "est",
                table: "CustomerMaster",
                column: "CustomerCode");


            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_AllocationTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "AllocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_BlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_BlockSideId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockSideId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_BlockTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_BlockUnitId",
                schema: "est",
                table: "PropertyMaster",
                column: "BlockUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                column: "CustomerCode");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "FloorNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_LandUseId",
                schema: "est",
                table: "PropertyMaster",
                column: "LandUseId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_LandUseTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "LandUseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_LocalityId",
                schema: "est",
                table: "PropertyMaster",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PlotDimensionId",
                schema: "est",
                table: "PropertyMaster",
                column: "PlotDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PlotTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "PlotTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyHeightId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PropertyTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_SchemeTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "SchemeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_SiteId",
                schema: "est",
                table: "PropertyMaster",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_TypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_AllocationType_AllocationTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "AllocationTypeId",
                principalSchema: "est",
                principalTable: "AllocationType",
                principalColumn: "AllocationTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentCategoryId",
                principalSchema: "est",
                principalTable: "ApartmentCategory",
                principalColumn: "ApartmentCategoryId",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_PropertyMaster_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                column: "CurrencyId",
                principalSchema: "est",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_CustomerMaster_CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                column: "CustomerCode",
                principalSchema: "est",
                principalTable: "CustomerMaster",
                principalColumn: "CustomerCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_FloorNumbering_FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "FloorNumberId",
                principalSchema: "est",
                principalTable: "FloorNumbering",
                principalColumn: "FloorNumberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_LandUseType_LandUseTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "LandUseTypeId",
                principalSchema: "est",
                principalTable: "LandUseType",
                principalColumn: "LandUseTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_LandUse_LandUseId",
                schema: "est",
                table: "PropertyMaster",
                column: "LandUseId",
                principalSchema: "est",
                principalTable: "LandUse",
                principalColumn: "LandUseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_Locality_LocalityId",
                schema: "est",
                table: "PropertyMaster",
                column: "LocalityId",
                principalSchema: "est",
                principalTable: "Locality",
                principalColumn: "LocalityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PlotDimension_PlotDimensionId",
                schema: "est",
                table: "PropertyMaster",
                column: "PlotDimensionId",
                principalSchema: "est",
                principalTable: "PlotDimension",
                principalColumn: "PlotDimensionId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_PropertyMaster_PropertyStatus_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyStatusId",
                principalSchema: "est",
                principalTable: "PropertyStatus",
                principalColumn: "PropertyStatusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PropertyType_PropertyTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyTypeId",
                principalSchema: "est",
                principalTable: "PropertyType",
                principalColumn: "PropertyTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalCategoryId",
                principalSchema: "est",
                principalTable: "RentalCategory",
                principalColumn: "RentalCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_RentalType_RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "RentalTypeId",
                principalSchema: "est",
                principalTable: "RentalType",
                principalColumn: "RentalTypeId",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_Types_TypeId",
                schema: "est",
                table: "PropertyMaster",
                column: "TypeId",
                principalSchema: "est",
                principalTable: "Types",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_AllocationType_AllocationTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster");

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
                name: "FK_PropertyMaster_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_CustomerMaster_CustomerCode",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_FloorNumbering_FloorNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_LandUseType_LandUseTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_LandUse_LandUseId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_Locality_LocalityId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PlotDimension_PlotDimensionId",
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
                name: "FK_PropertyMaster_PropertyStatus_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PropertyType_PropertyTypeId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_Types_TypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropTable(
                name: "PropertyMasterView",
                schema: "est");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_AllocationTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_ApartmentTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_BlockNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_BlockSideId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_BlockTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_BlockUnitId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_CurrencyId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_CustomerCode",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_FloorNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_LandUseId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_LandUseTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_LocalityId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_PlotDimensionId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_PlotTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_PropertyHeightId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_PropertyTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_RentalCategoryId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_RentalTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_SchemeTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_SiteId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_TypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_CustomerMaster_CustomerCode",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "RentalFee",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);
        }
    }
}
