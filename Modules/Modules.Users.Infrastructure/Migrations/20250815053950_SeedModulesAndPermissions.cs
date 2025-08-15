using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedModulesAndPermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropIndex(
            //    name: "IX_ModulesPermissions_ApplicationModulesModuleId",
            //    table: "ModulesPermissions");

            //migrationBuilder.DropColumn(
            //    name: "ApplicationModulesModuleId",
            //    table: "ModulesPermissions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationModulesModuleId",
                table: "ModulesPermissions",
                type: "nvarchar(12)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModulesPermissions_ApplicationModulesModuleId",
                table: "ModulesPermissions",
                column: "ApplicationModulesModuleId");
        }
    }
}
