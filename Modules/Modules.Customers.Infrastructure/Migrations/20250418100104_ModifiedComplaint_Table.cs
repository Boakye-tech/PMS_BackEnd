using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedComplaint_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyLocationId",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AddColumn<string>(
                name: "PropertyLocation",
                schema: "cus",
                table: "Complaint",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyLocation",
                schema: "cus",
                table: "Complaint");

            migrationBuilder.AddColumn<int>(
                name: "PropertyLocationId",
                schema: "cus",
                table: "Complaint",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
