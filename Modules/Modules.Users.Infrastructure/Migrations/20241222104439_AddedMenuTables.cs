using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMenuTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "AspNetUserRoles",
                newName: "AssignedOn");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "AspNetUserRoles",
                newName: "AssignedBy");

            migrationBuilder.CreateTable(
                name: "MenuActions",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuActions", x => x.ActionId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenuActions",
                columns: table => new
                {
                    RoleMenuActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    SubMenuId = table.Column<int>(type: "int", nullable: false),
                    ActionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenuActions", x => x.RoleMenuActionId);
                });

            migrationBuilder.CreateTable(
                name: "SubMenus",
                columns: table => new
                {
                    SubMenuId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    SubMenuName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenus", x => x.SubMenuId);
                });

            migrationBuilder.InsertData(
                table: "MenuActions",
                columns: new[] { "ActionId", "ActionName", "Description" },
                values: new object[,]
                {
                    { 1, "No Access", "" },
                    { 2, "Create", "" },
                    { 3, "Read", "" },
                    { 4, "Update", "" },
                    { 5, "Delete", "" },
                    { 6, "Approve", "" },
                    { 7, "Access", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TokenStore_Token",
                table: "TokenStore",
                column: "Token",
                unique: true,
                filter: "[Token] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentUnit_UnitName",
                table: "DepartmentUnit",
                column: "UnitName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentName",
                table: "Department",
                column: "DepartmentName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuActions_ActionName",
                table: "MenuActions",
                column: "ActionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menus_MenuName",
                table: "Menus",
                column: "MenuName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuActions_RoleId_MenuId_ActionId",
                table: "RoleMenuActions",
                columns: new[] { "RoleId", "MenuId", "ActionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubMenus_SubMenuName",
                table: "SubMenus",
                column: "SubMenuName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuActions");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "RoleMenuActions");

            migrationBuilder.DropTable(
                name: "SubMenus");

            migrationBuilder.DropIndex(
                name: "IX_TokenStore_Token",
                table: "TokenStore");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentUnit_UnitName",
                table: "DepartmentUnit");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentName",
                table: "Department");

            migrationBuilder.RenameColumn(
                name: "AssignedOn",
                table: "AspNetUserRoles",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "AssignedBy",
                table: "AspNetUserRoles",
                newName: "CreatedBy");
        }
    }
}
