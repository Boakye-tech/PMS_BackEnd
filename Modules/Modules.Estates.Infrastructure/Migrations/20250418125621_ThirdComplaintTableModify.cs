using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ThirdComplaintTableModify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PropertyLocationId",
                schema: "est",
                table: "Complaints");

            migrationBuilder.AddColumn<string>(
                name: "PropertyLocation",
                schema: "est",
                table: "Complaints",
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
                schema: "est",
                table: "Complaints");

            migrationBuilder.AddColumn<int>(
                name: "PropertyLocationId",
                schema: "est",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
