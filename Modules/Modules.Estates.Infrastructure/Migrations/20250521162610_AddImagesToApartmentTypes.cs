using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToApartmentTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                schema: "est",
                table: "ApartmentTypes",
                newName: "ImageTwo");

            migrationBuilder.AddColumn<string>(
                name: "ImageFive",
                schema: "est",
                table: "ApartmentTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageFour",
                schema: "est",
                table: "ApartmentTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageOne",
                schema: "est",
                table: "ApartmentTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageThree",
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
                columns: new[] { "ImageFive", "ImageFour", "ImageOne", "ImageThree" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 2,
                columns: new[] { "ImageFive", "ImageFour", "ImageOne", "ImageThree", "ImageTwo" },
                values: new object[] { "", "", "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable1Bed.png", "", "" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 3,
                columns: new[] { "ImageFive", "ImageFour", "ImageOne", "ImageThree" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 4,
                columns: new[] { "ImageFive", "ImageFour", "ImageOne", "ImageThree", "ImageTwo" },
                values: new object[] { "", "", "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable2Bed.png", "", "" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 5,
                columns: new[] { "ImageFive", "ImageFour", "ImageOne", "ImageThree" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                columns: new[] { "ImageFive", "ImageFour", "ImageOne", "ImageThree", "ImageTwo" },
                values: new object[] { "", "", "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Luxury3Bed.png", "", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFive",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropColumn(
                name: "ImageFour",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropColumn(
                name: "ImageOne",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropColumn(
                name: "ImageThree",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.RenameColumn(
                name: "ImageTwo",
                schema: "est",
                table: "ApartmentTypes",
                newName: "Image");

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
                keyValue: 4,
                column: "Image",
                value: "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Affordable2Bed.png");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "ApartmentTypes",
                keyColumn: "ApartmentTypeId",
                keyValue: 6,
                column: "Image",
                value: "https://mindspringsimagesonline.blob.core.windows.net/mindspringsimagesonline/Luxury3Bed.png");
        }
    }
}
