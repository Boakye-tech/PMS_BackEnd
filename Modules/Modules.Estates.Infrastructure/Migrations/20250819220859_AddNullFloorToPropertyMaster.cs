using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddNullFloorToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_FloorNumbering_FloorNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PropertyStatus_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                column: "CurrencyId",
                principalSchema: "est",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_FloorNumbering_FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "FloorNumberId",
                principalSchema: "est",
                principalTable: "FloorNumbering",
                principalColumn: "FloorNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PropertyStatus_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyStatusId",
                principalSchema: "est",
                principalTable: "PropertyStatus",
                principalColumn: "PropertyStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_FloorNumbering_FloorNumberId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_PropertyMaster_PropertyStatus_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.AlterColumn<int>(
                name: "PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "PropertyMaster",
                column: "CurrencyId",
                principalSchema: "est",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_FloorNumbering_FloorNumberId",
                schema: "est",
                table: "PropertyMaster",
                column: "FloorNumberId",
                principalSchema: "est",
                principalTable: "FloorNumbering",
                principalColumn: "FloorNumberId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyMaster_PropertyStatus_PropertyStatusId",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyStatusId",
                principalSchema: "est",
                principalTable: "PropertyStatus",
                principalColumn: "PropertyStatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
