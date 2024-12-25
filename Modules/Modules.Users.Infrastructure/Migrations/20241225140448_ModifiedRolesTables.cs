using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedRolesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoleMenuActions_RoleId_MenuId_ActionId",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "ActionId",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "RoleMenuActions");

            migrationBuilder.AddColumn<string>(
                name: "Approve",
                table: "RoleMenuActions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Create",
                table: "RoleMenuActions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Delete",
                table: "RoleMenuActions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NoAccess",
                table: "RoleMenuActions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Read",
                table: "RoleMenuActions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "RoleMenuActions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Update",
                table: "RoleMenuActions",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "Status",
                table: "AspNetRoles",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuActions_RoleName_MenuId",
                table: "RoleMenuActions",
                columns: new[] { "RoleName", "MenuId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoleMenuActions_RoleName_MenuId",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Approve",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Create",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Delete",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "NoAccess",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Read",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Update",
                table: "RoleMenuActions");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<int>(
                name: "ActionId",
                table: "RoleMenuActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "RoleMenuActions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuActions_RoleId_MenuId_ActionId",
                table: "RoleMenuActions",
                columns: new[] { "RoleId", "MenuId", "ActionId" },
                unique: true);
        }
    }
}
