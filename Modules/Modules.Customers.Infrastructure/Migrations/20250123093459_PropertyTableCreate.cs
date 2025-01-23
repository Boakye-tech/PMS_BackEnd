using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PropertyTableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllocationTypeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ApartmentBlockNumberId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ApartmentTypeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "BlockSideId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "BlockTypeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "BlockUnitId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "FloorNumberId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "LandUseId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "LandUseTypeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "LocalityId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PlotSizeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyHeightId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyTypeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "SchemeTypeId",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "CustomerTypeId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "GenderId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "LocalityId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "OtherNames",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "ResidentTypeId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "SocialMediaTypeId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "SurName",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "TitleId",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.AddColumn<string>(
                name: "AllocationType",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApartmentBlockNumber",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApartmentType",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BlockSide",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BlockType",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BlockUnit",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FloorNumber",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LandUse",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LandUseType",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locality",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlotSize",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PropertyHeight",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PropertyType",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SchemeType",
                schema: "cus",
                table: "PropertyDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "VoucherType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerType",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Locality",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResidentType",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SocialMediaType",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllocationType",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ApartmentBlockNumber",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "ApartmentType",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "BlockSide",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "BlockType",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "BlockUnit",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "Currency",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "FloorNumber",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "LandUse",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "LandUseType",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "Locality",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PlotSize",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyHeight",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "PropertyType",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "SchemeType",
                schema: "cus",
                table: "PropertyDetails");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "CustomerType",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Locality",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "Nationality",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "ResidentType",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.DropColumn(
                name: "SocialMediaType",
                schema: "cus",
                table: "CustomerDetails");

            migrationBuilder.AddColumn<int>(
                name: "AllocationTypeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentBlockNumberId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentTypeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlockSideId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlockTypeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlockUnitId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FloorNumberId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LandUseId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LandUseTypeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalityId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlotSizeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyHeightId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyTypeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchemeTypeId",
                schema: "cus",
                table: "PropertyDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VoucherType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<int>(
                name: "TransactionType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomerTypeId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocalityId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OtherNames",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ResidentTypeId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SocialMediaTypeId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                schema: "cus",
                table: "CustomerDetails",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TitleId",
                schema: "cus",
                table: "CustomerDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
