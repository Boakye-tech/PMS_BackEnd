using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PropertyMaster_ValueObjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PropertyMaster_PropertyNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "AcreageOne",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "ApartmentBlockNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "CadastralPlanNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "Comments",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "DebtorType",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "FloorArea",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "FloorNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "LeaseTerm",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "MotherPropertyNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "PlotSizeId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RentalType",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "SitePlanNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.RenameColumn(
                name: "TotalNumberOfRooms",
                schema: "est",
                table: "PropertyMaster",
                newName: "SiteId");

            migrationBuilder.RenameColumn(
                name: "SellingPrice",
                schema: "est",
                table: "PropertyMaster",
                newName: "PlotDimension");

            migrationBuilder.RenameColumn(
                name: "RoomsOccupied",
                schema: "est",
                table: "PropertyMaster",
                newName: "PropertyStatusId");

            migrationBuilder.RenameColumn(
                name: "RightOfEntry",
                schema: "est",
                table: "PropertyMaster",
                newName: "CommencementDate");

            migrationBuilder.RenameColumn(
                name: "PropertyHeightId",
                schema: "est",
                table: "PropertyMaster",
                newName: "LeaseTermInYears");

            migrationBuilder.RenameColumn(
                name: "AcreageTwo",
                schema: "est",
                table: "PropertyMaster",
                newName: "PlotAcreage");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
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
                name: "Images",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Images",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.RenameColumn(
                name: "SiteId",
                schema: "est",
                table: "PropertyMaster",
                newName: "TotalNumberOfRooms");

            migrationBuilder.RenameColumn(
                name: "PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                newName: "RoomsOccupied");

            migrationBuilder.RenameColumn(
                name: "PlotDimension",
                schema: "est",
                table: "PropertyMaster",
                newName: "SellingPrice");

            migrationBuilder.RenameColumn(
                name: "PlotAcreage",
                schema: "est",
                table: "PropertyMaster",
                newName: "AcreageTwo");

            migrationBuilder.RenameColumn(
                name: "LeaseTermInYears",
                schema: "est",
                table: "PropertyMaster",
                newName: "PropertyHeightId");

            migrationBuilder.RenameColumn(
                name: "CommencementDate",
                schema: "est",
                table: "PropertyMaster",
                newName: "RightOfEntry");

            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerCode",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(10)",
                maxLength: 10,
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
                name: "BlockNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AddColumn<double>(
                name: "AcreageOne",
                schema: "est",
                table: "PropertyMaster",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentBlockNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CadastralPlanNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Comments",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DebtorType",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FloorArea",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeaseTerm",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherPropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotSizeId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RentalType",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SitePlanNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyNumber",
                unique: true);
        }
    }
}
