using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Finance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PenaltyTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranch_Bank_BankId",
                schema: "fin",
                table: "BankBranch");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                schema: "fin",
                table: "BankBranch",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.CreateTable(
                name: "BankAccountNumbers",
                schema: "fin",
                columns: table => new
                {
                    BankAccountNumbersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    BankId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BranchId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccountNumbers", x => x.BankAccountNumbersId);
                    table.ForeignKey(
                        name: "FK_BankAccountNumbers_BankBranch_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "fin",
                        principalTable: "BankBranch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankAccountNumbers_Bank_BankId",
                        column: x => x.BankId,
                        principalSchema: "fin",
                        principalTable: "Bank",
                        principalColumn: "BankId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankAccountNumbers_CurrencyExchangeRate_CurrencyId",
                        column: x => x.CurrencyId,
                        principalSchema: "fin",
                        principalTable: "CurrencyExchangeRate",
                        principalColumn: "CurrencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PenaltyTypes",
                schema: "fin",
                columns: table => new
                {
                    PenaltyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyTypes", x => x.PenaltyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PenaltyRules",
                schema: "fin",
                columns: table => new
                {
                    PenaltyRuleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PenaltyTypeId = table.Column<int>(type: "int", nullable: false),
                    CalculationMethod = table.Column<int>(type: "int", nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GracePeriodDays = table.Column<int>(type: "int", nullable: false),
                    CapAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PenaltyRules", x => x.PenaltyRuleId);
                    table.ForeignKey(
                        name: "FK_PenaltyRules_PenaltyTypes_PenaltyTypeId",
                        column: x => x.PenaltyTypeId,
                        principalSchema: "fin",
                        principalTable: "PenaltyTypes",
                        principalColumn: "PenaltyTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankAccountNumbers_BankId",
                schema: "fin",
                table: "BankAccountNumbers",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccountNumbers_BranchId",
                schema: "fin",
                table: "BankAccountNumbers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BankAccountNumbers_CurrencyId",
                schema: "fin",
                table: "BankAccountNumbers",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_PenaltyRules_PenaltyTypeId",
                schema: "fin",
                table: "PenaltyRules",
                column: "PenaltyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PenaltyTypes_Name",
                schema: "fin",
                table: "PenaltyTypes",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_BankBranch_Bank_BankId",
                schema: "fin",
                table: "BankBranch",
                column: "BankId",
                principalSchema: "fin",
                principalTable: "Bank",
                principalColumn: "BankId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BankBranch_Bank_BankId",
                schema: "fin",
                table: "BankBranch");

            migrationBuilder.DropTable(
                name: "BankAccountNumbers",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "PenaltyRules",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "PenaltyTypes",
                schema: "fin");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                schema: "fin",
                table: "BankBranch",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

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
    }
}
