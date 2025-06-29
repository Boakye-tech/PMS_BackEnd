using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApartmentCategoryField_Modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApartmentCategory",
                schema: "est",
                table: "ApartmentFeatures",
                newName: "ApartmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentFeatures_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentFeatures",
                column: "ApartmentCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentFeatures_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentFeatures",
                column: "ApartmentCategoryId",
                principalSchema: "est",
                principalTable: "ApartmentCategory",
                principalColumn: "ApartmentCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentFeatures_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentFeatures_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentFeatures");

            migrationBuilder.RenameColumn(
                name: "ApartmentCategoryId",
                schema: "est",
                table: "ApartmentFeatures",
                newName: "ApartmentCategory");
        }
    }
}
