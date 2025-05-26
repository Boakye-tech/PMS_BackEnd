using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Notification.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIsArchiveField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchive",
                schema: "ntf",
                table: "Notifications",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchive",
                schema: "ntf",
                table: "Notifications");
        }
    }
}
