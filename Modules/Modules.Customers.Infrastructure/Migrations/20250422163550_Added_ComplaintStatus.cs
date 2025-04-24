using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_ComplaintStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssignedBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CancelledBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "CancelledDate",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DateAssigned",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DateReviewed",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ResolutionDate",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ResolvedBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "ReviewedBy",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AddColumn<int>(
                name: "DispatachedTo_Department",
                schema: "cus",
                table: "Complaint",
                type: "int",
                maxLength: 36,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DispatachedTo_DepartmentUnit",
                schema: "cus",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ComplaintHistory",
                schema: "cus",
                columns: table => new
                {
                    ComplaintHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ComplaintStatus = table.Column<int>(type: "int", nullable: false),
                    ActionBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    ActionOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintHistory", x => x.ComplaintHistoryId);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintStatus",
                schema: "cus",
                columns: table => new
                {
                    ComplaintStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintStatus", x => x.ComplaintStatusId);
                });

            migrationBuilder.InsertData(
                schema: "cus",
                table: "ComplaintStatus",
                columns: new[] { "ComplaintStatusId", "ComplaintStatus", "Description" },
                values: new object[,]
                {
                    { 1, "SUBMITTED", "COMPLAINT HAS BEEN SUBMITTED BY THE CUSTOMER." },
                    { 2, "ACKNOWLEDGED", "COMPLAINT HAS BEEN ACKNOWLEDGED BY THE ORGANIZATION." },
                    { 3, "DISPATCHED", "COMPLAINT FORWARDED TO THE APPROPRIATE DEPARTMENT." },
                    { 4, "REVIEWED", "COMPLAINT HAS BEEN REVIEWED." },
                    { 5, "ASSIGNED", "COMPLAINT ASSIGNED TO A HANDLER." },
                    { 6, "IN PROGRESS", "COMPLAINT IS ACTIVELY BEING WORKED ON." },
                    { 7, "RESOLVED", "COMPLAINT HAS BEEN RESOLVED." },
                    { 8, "REOPENED", "COMPLAINT HAS BEEN REOPENED FOR FURTHER ACTION." },
                    { 9, "CLOSED", "COMPLAINT PROCESS IS COMPLETED AND CLOSED." },
                    { 10, "CANCELLED", "COMPLAINT HAS BEEN CANCELLED." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintHistory_ComplaintNumber_ComplaintStatus",
                schema: "cus",
                table: "ComplaintHistory",
                columns: new[] { "ComplaintNumber", "ComplaintStatus" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintStatus_ComplaintStatus",
                schema: "cus",
                table: "ComplaintStatus",
                column: "ComplaintStatus",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplaintHistory",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "ComplaintStatus",
                schema: "cus");

            migrationBuilder.DropColumn(
                name: "DispatachedTo_Department",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DispatachedTo_DepartmentUnit",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AddColumn<string>(
                name: "AssignedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

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
                name: "DateAssigned",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReviewed",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ResolutionDate",
                schema: "cus",
                table: "Complaint",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ResolvedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewedBy",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }
    }
}
