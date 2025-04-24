using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintHistoryTable_Added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedBy",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "AssignedTo",
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
                name: "CreatedBy",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DateAssigned",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DateReviewed",
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
                name: "ResolutionDate",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ResolvedBy",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ReviewedBy",
                schema: "est",
                table: "Complaints");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

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

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAssigned",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReviewed",
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

            migrationBuilder.AddColumn<DateTime>(
                name: "ResolutionDate",
                schema: "est",
                table: "Complaints",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ResolvedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewedBy",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }
    }
}
