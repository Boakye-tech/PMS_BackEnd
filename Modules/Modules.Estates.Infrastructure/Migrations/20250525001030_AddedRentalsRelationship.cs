using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRentalsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RentalType_RentalCategoryId",
                schema: "est",
                table: "RentalType",
                column: "RentalCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalType_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "RentalType",
                column: "RentalCategoryId",
                principalSchema: "est",
                principalTable: "RentalCategory",
                principalColumn: "RentalCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalType_RentalCategory_RentalCategoryId",
                schema: "est",
                table: "RentalType");

            migrationBuilder.DropIndex(
                name: "IX_RentalType_RentalCategoryId",
                schema: "est",
                table: "RentalType");
        }
    }
}
