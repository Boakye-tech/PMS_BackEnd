using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Modified_ComplaintTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CancelledBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledDate",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Source",
                schema: "cus",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelledBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CancelledDate",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "Source",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
