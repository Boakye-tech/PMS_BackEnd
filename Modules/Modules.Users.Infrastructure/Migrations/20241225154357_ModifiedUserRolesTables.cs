using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedUserRolesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoleMenuActions_RoleName_MenuId",
                table: "RoleMenuActions");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "RoleMenuActions",
                newName: "RoleId");

            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "AspNetUserRoles",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuActions_RoleId_SubMenuId",
                table: "RoleMenuActions",
                columns: new[] { "RoleId", "SubMenuId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoleMenuActions_RoleId_SubMenuId",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUserRoles");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "RoleMenuActions",
                newName: "RoleName");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuActions_RoleName_MenuId",
                table: "RoleMenuActions",
                columns: new[] { "RoleName", "MenuId" },
                unique: true);
        }
    }
}
