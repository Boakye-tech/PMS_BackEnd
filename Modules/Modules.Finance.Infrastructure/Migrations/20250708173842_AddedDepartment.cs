using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Finance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SellingRate",
                schema: "fin",
                table: "CurrencyExchangeRateHistory",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyingRate",
                schema: "fin",
                table: "CurrencyExchangeRateHistory",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingRate",
                schema: "fin",
                table: "CurrencyExchangeRate",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyingRate",
                schema: "fin",
                table: "CurrencyExchangeRate",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Department",
                schema: "fin",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentUnit",
                schema: "fin",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentUnit", x => x.UnitId);
                    table.ForeignKey(
                        name: "FK_DepartmentUnit_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalSchema: "fin",
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankBranch_BankId",
                schema: "fin",
                table: "BankBranch",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentUnit_DepartmentId",
                schema: "fin",
                table: "DepartmentUnit",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranch_Bank_BankId",
                schema: "fin",
                table: "BankBranch",
                column: "BankId",
                principalSchema: "fin",
                principalTable: "Bank",
                principalColumn: "BankId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranch_Bank_BankId",
                schema: "fin",
                table: "BankBranch");

            migrationBuilder.DropTable(
                name: "DepartmentUnit",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "Department",
                schema: "fin");

            migrationBuilder.DropIndex(
                name: "IX_BankBranch_BankId",
                schema: "fin",
                table: "BankBranch");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingRate",
                schema: "fin",
                table: "CurrencyExchangeRateHistory",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyingRate",
                schema: "fin",
                table: "CurrencyExchangeRateHistory",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellingRate",
                schema: "fin",
                table: "CurrencyExchangeRate",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BuyingRate",
                schema: "fin",
                table: "CurrencyExchangeRate",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");
        }
    }
}
