using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMissingColumnsToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FloorArea",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "IsLargeScale",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RentalType",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.RenameColumn(
                name: "PropertyTypeId",
                schema: "est",
                table: "PropertyMaster",
                newName: "TypeId");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<double>(
                name: "PlotDimension",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "PlotAcreage",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "MotherPropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LeaseTermInYears",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeaseExpiryDate",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Images",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateTwo",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateThree",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateSix",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateOne",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateFour",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateFive",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommencementDate",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "BlockNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AddColumn<string>(
                name: "OldPropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotTypeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OldPropertyNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "PlotTypeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                schema: "est",
                table: "PropertyMaster",
                newName: "PropertyTypeId");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PlotDimension",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PlotAcreage",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MotherPropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LeaseTermInYears",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "LeaseExpiryDate",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Images",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateTwo",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateThree",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateSix",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateOne",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateFour",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoordinateFive",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CommencementDate",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BlockNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloorArea",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsLargeScale",
                schema: "est",
                table: "PropertyMaster",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RentalType",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
