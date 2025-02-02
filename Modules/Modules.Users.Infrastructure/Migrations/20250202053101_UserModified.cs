using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UserModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Channel",
                schema: "dbo",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "ChannelId",
                schema: "dbo",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChannelId",
                schema: "dbo",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "Channel",
                schema: "dbo",
                table: "Users",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);
        }
    }
}
