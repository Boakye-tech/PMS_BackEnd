using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Users.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentificationTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentificationType",
                columns: table => new
                {
                    IdentificationTypeId = table.Column<int>(type: "int", nullable: false),
                    IdentificationTypes = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdentificationType_IdentificationTypeId_IdentificationTypes",
                table: "IdentificationType",
                columns: new[] { "IdentificationTypeId", "IdentificationTypes" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentificationType");
        }
    }
}
