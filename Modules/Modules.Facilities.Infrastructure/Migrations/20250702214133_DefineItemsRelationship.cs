using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Facilities.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DefineItemsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsCategory_ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items");

            migrationBuilder.InsertData(
                schema: "fac",
                table: "ItemsCategory",
                columns: new[] { "ItemCategoryId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ItemCategoryName", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "WASHROOM CONSUMABLES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLEANING SUPPLIES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CLEANING TOOLS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemsCategory_ItemCategoryName",
                schema: "fac",
                table: "ItemsCategory",
                column: "ItemCategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCategoryId",
                schema: "fac",
                table: "Items",
                column: "ItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsCategory_ItemCategoryId",
                schema: "fac",
                table: "Items",
                column: "ItemCategoryId",
                principalSchema: "fac",
                principalTable: "ItemsCategory",
                principalColumn: "ItemCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemsCategory_ItemCategoryId",
                schema: "fac",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_ItemsCategory_ItemCategoryName",
                schema: "fac",
                table: "ItemsCategory");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemCategoryId",
                schema: "fac",
                table: "Items");

            migrationBuilder.DeleteData(
                schema: "fac",
                table: "ItemsCategory",
                keyColumn: "ItemCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "fac",
                table: "ItemsCategory",
                keyColumn: "ItemCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "fac",
                table: "ItemsCategory",
                keyColumn: "ItemCategoryId",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items",
                column: "ItemsCategoryItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemsCategory_ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items",
                column: "ItemsCategoryItemCategoryId",
                principalSchema: "fac",
                principalTable: "ItemsCategory",
                principalColumn: "ItemCategoryId");
        }
    }
}
