using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedColumnsToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.RenameColumn(
                name: "RoomNumber",
                schema: "est",
                table: "PropertyMaster",
                newName: "RentalTypeId");

            migrationBuilder.RenameColumn(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "ApartmentBlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                newName: "RentalCategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "PlotDimension",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PlotAcreage",
                schema: "est",
                table: "PropertyMaster",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentCategoryId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "BlockNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "PropertyHeightId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.RenameColumn(
                name: "RentalTypeId",
                schema: "est",
                table: "PropertyMaster",
                newName: "RoomNumber");

            migrationBuilder.RenameColumn(
                name: "RentalCategoryId",
                schema: "est",
                table: "PropertyMaster",
                newName: "ApartmentBlockNumberId");

            migrationBuilder.RenameColumn(
                name: "Number",
                schema: "est",
                table: "PropertyMaster",
                newName: "PlotNumber");

            migrationBuilder.AlterColumn<double>(
                name: "PlotDimension",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PlotAcreage",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BlockNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);
        }
    }
}
