using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintTable_Modified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(36)",
                oldMaxLength: 36,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CancelledBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledDate",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Source",
                schema: "est",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Complaints_ComplaintNumber",
                schema: "est",
                table: "Complaints",
                column: "ComplaintNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Complaints_ComplaintNumber",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CancelledBy",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CancelledDate",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "Source",
                schema: "est",
                table: "Complaints");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
