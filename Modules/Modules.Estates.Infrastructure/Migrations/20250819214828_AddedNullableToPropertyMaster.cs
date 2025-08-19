using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNullableToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster");


            migrationBuilder.AlterColumn<int>(
                name: "ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentCategoryId",
                principalSchema: "est",
                principalTable: "ApartmentCategory",
                principalColumn: "ApartmentCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster");


            migrationBuilder.AlterColumn<int>(
                name: "ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                column: "ApartmentCategoryId",
                principalSchema: "est",
                principalTable: "ApartmentCategory",
                principalColumn: "ApartmentCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
