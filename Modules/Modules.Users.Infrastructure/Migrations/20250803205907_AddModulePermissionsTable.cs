using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddModulePermissionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SubMenus",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "ModulesPermissions",
                columns: table => new
                {
                    ModulesPermissionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleId = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    ApplicationModulesModuleId = table.Column<string>(type: "nvarchar(12)", nullable: true),
                    PermissionName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModulesPermissions", x => x.ModulesPermissionsId);
                    table.ForeignKey(
                        name: "FK_ModulesPermissions_ApplicationModules_ApplicationModulesModuleId",
                        column: x => x.ApplicationModulesModuleId,
                        principalTable: "ApplicationModules",
                        principalColumn: "ModuleId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentUnit_DepartmentId",
                table: "DepartmentUnit",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulesPermissions_ApplicationModulesModuleId",
                table: "ModulesPermissions",
                column: "ApplicationModulesModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ModulesPermissions_ModuleId_PermissionName",
                table: "ModulesPermissions",
                columns: new[] { "ModuleId", "PermissionName" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentUnit_Department_DepartmentId",
                table: "DepartmentUnit",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentUnit_Department_DepartmentId",
                table: "DepartmentUnit");

            migrationBuilder.DropTable(
                name: "ModulesPermissions");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentUnit_DepartmentId",
                table: "DepartmentUnit");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "SubMenus",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
