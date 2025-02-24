using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MOdifiedInoiceAndPaymentTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceItemsId",
                schema: "cus",
                table: "CustomerPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                schema: "cus",
                table: "CustomerInvoiceItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "AmountPaid",
                schema: "cus",
                table: "CustomerInvoiceItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BalanceDue",
                schema: "cus",
                table: "CustomerInvoiceItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "AmountPaid",
                schema: "cus",
                table: "CustomerInvoice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BalanceDue",
                schema: "cus",
                table: "CustomerInvoice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceStatus",
                schema: "cus",
                table: "CustomerInvoice",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceItemsId",
                schema: "cus",
                table: "CustomerPayments");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                schema: "cus",
                table: "CustomerInvoiceItems");

            migrationBuilder.DropColumn(
                name: "BalanceDue",
                schema: "cus",
                table: "CustomerInvoiceItems");

            migrationBuilder.DropColumn(
                name: "AmountPaid",
                schema: "cus",
                table: "CustomerInvoice");

            migrationBuilder.DropColumn(
                name: "BalanceDue",
                schema: "cus",
                table: "CustomerInvoice");

            migrationBuilder.DropColumn(
                name: "InvoiceStatus",
                schema: "cus",
                table: "CustomerInvoice");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                schema: "cus",
                table: "CustomerInvoiceItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
