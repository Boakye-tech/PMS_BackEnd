using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TypesFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileNames",
                schema: "est",
                table: "ActivityTransactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]");

            migrationBuilder.AddForeignKey(
                name: "FK_Types_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "Types",
                column: "CurrencyId",
                principalSchema: "est",
                principalTable: "CurrencyExchangeRate",
                principalColumn: "CurrencyId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileNames",
                schema: "est",
                table: "ActivityTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Types_CurrencyExchangeRate_CurrencyId",
                schema: "est",
                table: "Types");
        }
    }
}
