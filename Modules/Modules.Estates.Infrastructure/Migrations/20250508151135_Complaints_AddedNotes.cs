using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Complaints_AddedNotes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ComplaintTypes",
                schema: "est",
                table: "ComplaintType",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AddColumn<string>(
                name: "CancelNotes",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClosedNotes",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReopenNotes",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewNotes",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CancelNotes",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ClosedNotes",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ReopenNotes",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "ReviewNotes",
                schema: "est",
                table: "Complaints");

            migrationBuilder.AlterColumn<string>(
                name: "ComplaintTypes",
                schema: "est",
                table: "ComplaintType",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);
        }
    }
}
