using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class OpeningBalances : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CustomerTransactions_VoucherNumber",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTransactions_VoucherNumber_CustomerCode",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "VoucherNumber",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "VoucherType",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                schema: "cus",
                table: "CustomerTransactions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "cus",
                table: "CustomerTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "cus",
                table: "CustomerTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EntryType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "cus",
                table: "CustomerTransactions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TransactionNumber",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "CustomerOpeningBalances",
                schema: "cus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AccountCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Years = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerOpeningBalances", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_TransactionNumber",
                schema: "cus",
                table: "CustomerTransactions",
                column: "TransactionNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_TransactionNumber_CustomerCode",
                schema: "cus",
                table: "CustomerTransactions",
                columns: new[] { "TransactionNumber", "CustomerCode" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerOpeningBalances",
                schema: "cus");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTransactions_TransactionNumber",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropIndex(
                name: "IX_CustomerTransactions_TransactionNumber_CustomerCode",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "EntryType",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.DropColumn(
                name: "TransactionNumber",
                schema: "cus",
                table: "CustomerTransactions");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<double>(
                name: "Amount",
                schema: "cus",
                table: "CustomerTransactions",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "VoucherNumber",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VoucherType",
                schema: "cus",
                table: "CustomerTransactions",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_VoucherNumber",
                schema: "cus",
                table: "CustomerTransactions",
                column: "VoucherNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_VoucherNumber_CustomerCode",
                schema: "cus",
                table: "CustomerTransactions",
                columns: new[] { "VoucherNumber", "CustomerCode" },
                unique: true);
        }
    }
}
