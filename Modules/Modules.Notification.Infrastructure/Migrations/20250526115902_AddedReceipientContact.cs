using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Notification.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedReceipientContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RecipientContact",
                schema: "ntf",
                table: "Notifications",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecipientContact",
                schema: "ntf",
                table: "Notifications");
        }
    }
}
