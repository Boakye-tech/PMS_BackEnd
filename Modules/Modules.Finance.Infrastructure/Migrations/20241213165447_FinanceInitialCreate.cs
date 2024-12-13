using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Finance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinanceInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "fin");

            migrationBuilder.CreateTable(
                name: "Bank",
                schema: "fin",
                columns: table => new
                {
                    BankId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank", x => x.BankId);
                });

            migrationBuilder.CreateTable(
                name: "BankBranch",
                schema: "fin",
                columns: table => new
                {
                    BranchId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BankId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBranch", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "BankSortCodes",
                schema: "fin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankSortCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChartOfAccounts",
                schema: "fin",
                columns: table => new
                {
                    AccountCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartOfAccounts", x => x.AccountCode);
                });

            migrationBuilder.CreateTable(
                name: "CurrencyAndExchangeRate",
                schema: "fin",
                columns: table => new
                {
                    CurrencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencyInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BuyingRate = table.Column<double>(type: "float", nullable: false),
                    SellingRate = table.Column<double>(type: "float", nullable: false),
                    BaseCurrency = table.Column<bool>(type: "bit", nullable: false),
                    ApplicableDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCurrent = table.Column<short>(type: "smallint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyAndExchangeRate", x => x.CurrencyId);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                schema: "fin",
                columns: table => new
                {
                    FormCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    FormName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AccountCode = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.FormCode);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMode",
                schema: "fin",
                columns: table => new
                {
                    PaymentModeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentModes = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMode", x => x.PaymentModeId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentType",
                schema: "fin",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypes = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentType", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Paypoints",
                schema: "fin",
                columns: table => new
                {
                    PaypointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Paypoint = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paypoints", x => x.PaypointId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                schema: "fin",
                columns: table => new
                {
                    ServiceCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AccountCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bank",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "BankBranch",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "BankSortCodes",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "ChartOfAccounts",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "CurrencyAndExchangeRate",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "Forms",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "PaymentMode",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "PaymentType",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "Paypoints",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "Services",
                schema: "fin");
        }
    }
}
