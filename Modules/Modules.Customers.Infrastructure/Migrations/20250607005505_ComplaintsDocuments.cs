using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintsDocuments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentOne",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DocumentThree",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.DropColumn(
                name: "DocumentTwo",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AddColumn<string>(
                name: "DocumentList",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentList",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AddColumn<string>(
                name: "DocumentOne",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentThree",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentTwo",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }
    }
}
