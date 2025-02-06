using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedSubPermissionsItemsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleMenuActions");

            migrationBuilder.RenameColumn(
                name: "PermissionsId",
                table: "SubPermissionsItems",
                newName: "SubPermissionsItemsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubPermissionsItemsId",
                table: "SubPermissionsItems",
                newName: "PermissionsId");

            migrationBuilder.CreateTable(
                name: "RoleMenuActions",
                columns: table => new
                {
                    RoleMenuActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Approve = table.Column<bool>(type: "bit", nullable: false),
                    Create = table.Column<bool>(type: "bit", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    NoAccess = table.Column<bool>(type: "bit", nullable: false),
                    Read = table.Column<bool>(type: "bit", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubMenuId = table.Column<int>(type: "int", nullable: false),
                    SubMenuItemsId = table.Column<int>(type: "int", nullable: false),
                    Update = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenuActions", x => x.RoleMenuActionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleMenuActions_RoleId_SubMenuId",
                table: "RoleMenuActions",
                columns: new[] { "RoleId", "SubMenuId" },
                unique: true);
        }
    }
}
