using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRegistrationNumberToPropertyMaster : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AddColumn<string>(
                name: "BuildingPermitNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsRegistered",
                schema: "est",
                table: "PropertyMaster",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "BuildingPermitNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "IsRegistered",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                schema: "est",
                table: "PropertyMaster");
        }
    }
}
