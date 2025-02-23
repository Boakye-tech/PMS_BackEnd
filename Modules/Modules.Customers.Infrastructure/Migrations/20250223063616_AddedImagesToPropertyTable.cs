using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedImagesToPropertyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageFive",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFour",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageOne",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageThree",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageTwo",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageFive",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ImageFour",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ImageOne",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ImageThree",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ImageTwo",
                schema: "cus",
                table: "PropertyDetails");
        }
    }
}
