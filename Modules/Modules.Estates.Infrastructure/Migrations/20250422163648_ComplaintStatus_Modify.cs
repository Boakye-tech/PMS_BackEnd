using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ComplaintStatus_Modify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DispatachedTo_Department",
                schema: "est",
                table: "Complaints",
                type: "int",
                maxLength: 36,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DispatachedTo_DepartmentUnit",
                schema: "est",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ComplaintHistory_ComplaintNumber_ComplaintStatus",
                schema: "est",
                table: "ComplaintHistory",
                columns: new[] { "ComplaintNumber", "ComplaintStatus" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ComplaintHistory_ComplaintNumber_ComplaintStatus",
                schema: "est",
                table: "ComplaintHistory");

            migrationBuilder.DropColumn(
                name: "AssignedTo",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DispatachedTo_Department",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DispatachedTo_DepartmentUnit",
                schema: "est",
                table: "Complaints");
        }
    }
}
