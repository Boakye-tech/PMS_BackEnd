using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedImageToApartmentTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                schema: "est",
                table: "ApartmentTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 1,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                column: "Image",
                value: "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable1Bed.png");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                column: "Image",
                value: "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable2Bed.png");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                column: "Image",
                value: "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Luxury3Bed.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                schema: "est",
                table: "ApartmentTypes");
        }
    }
}
