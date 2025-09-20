using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Finance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentInitialField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descrption",
                schema: "fin",
                table: "Services",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentInitial",
                schema: "fin",
                table: "Department",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentInitial",
                schema: "fin",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "Description",
                schema: "fin",
                table: "Services",
                newName: "Descrption");
        }
    }
}
