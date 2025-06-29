using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApartmentTypeTable_Modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApartmentTypes_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentTypes_ApartmentType",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_ApartmentCategoryId_ApartmentType",
                schema: "est",
                table: "ApartmentTypes",
                columns: new[] { "ApartmentCategoryId", "ApartmentType" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ApartmentTypes_ApartmentCategoryId_ApartmentType",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes",
                column: "ApartmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_ApartmentType",
                schema: "est",
                table: "ApartmentTypes",
                column: "ApartmentType",
                unique: true);
        }
    }
}
