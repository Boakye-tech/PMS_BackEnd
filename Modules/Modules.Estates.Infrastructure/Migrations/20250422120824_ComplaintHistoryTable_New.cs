using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintHistoryTable_New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComplaintHistory",
                schema: "est",
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

            migrationBuilder.InsertData(
                schema: "est",
                table: "ComplaintStatuses",
                columns: new[] { "ComplaintStatusId", "ComplaintStatus", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Description", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "SUBMITTED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT HAS BEEN SUBMITTED BY THE CUSTOMER.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ACKNOWLEDGED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT HAS BEEN ACKNOWLEDGED BY THE ORGANIZATION.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "DISPATCHED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT FORWARDED TO THE APPROPRIATE DEPARTMENT.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "REVIEWED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT HAS BEEN REVIEWED.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "ASSIGNED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT ASSIGNED TO A HANDLER.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "IN PROGRESS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT IS ACTIVELY BEING WORKED ON.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "RESOLVED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT HAS BEEN RESOLVED.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "REOPENED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT HAS BEEN REOPENED FOR FURTHER ACTION.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "CLOSED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT PROCESS IS COMPLETED AND CLOSED.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "CANCELLED", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "COMPLAINT HAS BEEN CANCELLED.", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintStatuses_ComplaintStatus",
                schema: "est",
                table: "ComplaintStatuses",
                column: "ComplaintStatus",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplaintHistory",
                schema: "est");

            migrationBuilder.DropIndex(
                name: "IX_ComplaintStatuses_ComplaintStatus",
                schema: "est",
                table: "ComplaintStatuses");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "ComplaintStatuses",
                keyColumn: "ComplaintStatusId",
                keyValue: 10);
        }
    }
}
