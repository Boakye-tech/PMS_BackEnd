using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDepartmentInitialField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentInitial",
                table: "Department",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 401,
                columns: new[] { "DepartmentInitial", "DepartmentName" },
                values: new object[] { "FIN", "FINANCE" });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 402,
                columns: new[] { "DepartmentInitial", "DepartmentName" },
                values: new object[] { "EST", "ESTATES" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DepartmentInitial", "DepartmentName", "ModifiedBy", "ModifiedOn" },
                values: new object[] { 403, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LEG", "LEGAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 211,
                column: "UnitName",
                value: "REVENUE");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 212,
                column: "UnitName",
                value: "CASH&BANK");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 213,
                column: "UnitName",
                value: "FACILITIES");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 214,
                column: "UnitName",
                value: "RECORDS");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 215,
                column: "UnitName",
                value: "SEERVICED PLOTS");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 216,
                column: "UnitName",
                value: "HOUSES");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 217,
                column: "UnitName",
                value: "SHOPS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 403);

            migrationBuilder.DropColumn(
                name: "DepartmentInitial",
                table: "Department");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 401,
                column: "DepartmentName",
                value: "Finance");

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 402,
                column: "DepartmentName",
                value: "Estates");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 211,
                column: "UnitName",
                value: "Revenue");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 212,
                column: "UnitName",
                value: "Cash&Bank");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 213,
                column: "UnitName",
                value: "Facilities");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 214,
                column: "UnitName",
                value: "Records");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 215,
                column: "UnitName",
                value: "Plots");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 216,
                column: "UnitName",
                value: "Houses");

            migrationBuilder.UpdateData(
                table: "DepartmentUnit",
                keyColumn: "UnitId",
                keyValue: 217,
                column: "UnitName",
                value: "Shops");
        }
    }
}
