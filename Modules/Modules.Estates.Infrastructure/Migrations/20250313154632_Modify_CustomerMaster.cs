using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Modify_CustomerMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfMarriage",
                schema: "est",
                table: "CustomerMaster",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                schema: "est",
                table: "CustomerMaster",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatus",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfMarriage",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                schema: "est",
                table: "CustomerMaster");
        }
    }
}
