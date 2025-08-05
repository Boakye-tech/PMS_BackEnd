using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DefineModulesRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModulesPermissions_ApplicationModules_ApplicationModulesModuleId",
                table: "ModulesPermissions");

            migrationBuilder.DropIndex(
                name: "IX_ModulesPermissions_ApplicationModulesModuleId",
                table: "ModulesPermissions");

            migrationBuilder.DropColumn(
                name: "ApplicationModulesModuleId",
                table: "ModulesPermissions");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulesPermissions_ApplicationModules_ModuleId",
                table: "ModulesPermissions",
                column: "ModuleId",
                principalTable: "ApplicationModules",
                principalColumn: "ModuleId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ModulesPermissions_ApplicationModules_ModuleId",
                table: "ModulesPermissions");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationModulesModuleId",
                table: "ModulesPermissions",
                type: "nvarchar(12)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ModulesPermissions_ApplicationModulesModuleId",
                table: "ModulesPermissions",
                column: "ApplicationModulesModuleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ModulesPermissions_ApplicationModules_ApplicationModulesModuleId",
                table: "ModulesPermissions",
                column: "ApplicationModulesModuleId",
                principalTable: "ApplicationModules",
                principalColumn: "ModuleId");
        }
    }
}
