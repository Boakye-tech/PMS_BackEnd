using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Finance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyChartOfAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChartOfAccounts",
                schema: "fin",
                table: "ChartOfAccounts");

            migrationBuilder.DropColumn(
                name: "AccountCode",
                schema: "fin",
                table: "ChartOfAccounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountCode",
                schema: "fin",
                table: "ChartOfAccounts",
                type: "int",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChartOfAccounts",
                schema: "fin",
                table: "ChartOfAccounts",
                column: "AccountCode");

            migrationBuilder.InsertData(
                schema: "fin",
                table: "ChartOfAccounts",
                columns: new[] { "AccountCode", "AccountName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 23001, "HOUSE RENT DEBTORS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23002, "SHOP RENT DEBTORS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23003, "GROUND RENT DEBTORS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53001, "APPLICATION FORMS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChartOfAccounts",
                schema: "fin",
                table: "ChartOfAccounts");

            migrationBuilder.DropColumn(
                name: "AccountCode",
                schema: "fin",
                table: "ChartOfAccounts");

            migrationBuilder.AddColumn<int>(
                name: "AccountCode",
                schema: "fin",
                table: "ChartOfAccounts",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChartOfAccounts",
                schema: "fin",
                table: "ChartOfAccounts",
                column: "AccountCode");
        }
    }
}
