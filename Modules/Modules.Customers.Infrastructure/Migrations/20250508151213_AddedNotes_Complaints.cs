using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedNotes_Complaints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.RenameColumn(
                name: "ModifiedBy",
                schema: "cus",
                table: "Complaint",
                newName: "ReviewNotes");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                schema: "cus",
                table: "Complaint",
                newName: "ReopenNotes");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                schema: "cus",
                table: "Complaint",
                newName: "ClosedNotes");

            migrationBuilder.AddColumn<string>(
                name: "CancelNotes",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelNotes",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.RenameColumn(
                name: "ReviewNotes",
                schema: "cus",
                table: "Complaint",
                newName: "ModifiedBy");

            migrationBuilder.RenameColumn(
                name: "ReopenNotes",
                schema: "cus",
                table: "Complaint",
                newName: "DeletedBy");

            migrationBuilder.RenameColumn(
                name: "ClosedNotes",
                schema: "cus",
                table: "Complaint",
                newName: "CreatedBy");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
