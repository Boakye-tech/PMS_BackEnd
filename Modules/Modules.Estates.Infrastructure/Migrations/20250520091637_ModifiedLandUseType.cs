using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedLandUseType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LandUseTypeDescription",
                schema: "est",
                table: "LandUseType",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ActivityTypeDescription",
                schema: "est",
                table: "ActivityType",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 1,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 2,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 3,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 4,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 5,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 6,
                columns: new[] { "LandUseTypeDescription", "LandUseTypeName" },
                values: new object[] { "", "RESTAURANTS & PUBS" });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 7,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 8,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 9,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 10,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 11,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 12,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 13,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 14,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 15,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 16,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 17,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 18,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 19,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 20,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 21,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 22,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 23,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 24,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 25,
                column: "LandUseTypeDescription",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 26,
                column: "LandUseTypeDescription",
                value: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LandUseTypeDescription",
                schema: "est",
                table: "LandUseType");

            migrationBuilder.AlterColumn<string>(
                name: "ActivityTypeDescription",
                schema: "est",
                table: "ActivityType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "LandUseType",
                keyColumn: "LandUseTypeId",
                keyValue: 6,
                column: "LandUseTypeName",
                value: "RESTAURANTS & PUS");
        }
    }
}
