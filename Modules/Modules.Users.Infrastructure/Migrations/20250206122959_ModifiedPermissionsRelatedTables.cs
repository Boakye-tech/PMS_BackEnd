using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedPermissionsRelatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PermissionsId",
                table: "SubPermissionsItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubPermissionsId",
                table: "SubPermissionsItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PermissionsId",
                table: "SubPermissions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissionsId",
                table: "SubPermissionsItems");

            migrationBuilder.DropColumn(
                name: "SubPermissionsId",
                table: "SubPermissionsItems");

            migrationBuilder.DropColumn(
                name: "PermissionsId",
                table: "SubPermissions");
        }
    }
}
