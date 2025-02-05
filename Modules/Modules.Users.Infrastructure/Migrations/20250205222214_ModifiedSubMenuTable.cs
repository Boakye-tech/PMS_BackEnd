using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedSubMenuTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SubMenus_SubMenuName",
                table: "SubMenus");

            migrationBuilder.CreateTable(
                name: "SubMenuItems",
                columns: table => new
                {
                    SubMenuItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<int>(type: "int", nullable: false),
                    SubMenuId = table.Column<int>(type: "int", nullable: false),
                    SubMenuItemName = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenuItems", x => x.SubMenuItemId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubMenuItems_SubMenuItemName",
                table: "SubMenuItems",
                column: "SubMenuItemName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubMenuItems");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenus_SubMenuName",
                table: "SubMenus",
                column: "SubMenuName",
                unique: true);
        }
    }
}
