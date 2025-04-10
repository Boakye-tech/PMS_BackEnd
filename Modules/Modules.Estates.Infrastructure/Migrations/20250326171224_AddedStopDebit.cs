using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedStopDebit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StopDebit",
                schema: "est",
                columns: table => new
                {
                    StopDebitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PropertyNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Reasons = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DebtorStatus = table.Column<int>(type: "int", nullable: false),
                    ActionOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StopDebit", x => x.StopDebitId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StopDebit",
                schema: "est");
        }
    }
}
