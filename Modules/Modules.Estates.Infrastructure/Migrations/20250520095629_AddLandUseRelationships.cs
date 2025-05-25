using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLandUseRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LandUseTypeDescription",
                schema: "est",
                table: "LandUseType",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.CreateIndex(
                name: "IX_LandUseType_LandUseId",
                schema: "est",
                table: "LandUseType",
                column: "LandUseId");

            migrationBuilder.AddForeignKey(
                name: "FK_LandUseType_LandUse_LandUseId",
                schema: "est",
                table: "LandUseType",
                column: "LandUseId",
                principalSchema: "est",
                principalTable: "LandUse",
                principalColumn: "LandUseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LandUseType_LandUse_LandUseId",
                schema: "est",
                table: "LandUseType");

            migrationBuilder.DropIndex(
                name: "IX_LandUseType_LandUseId",
                schema: "est",
                table: "LandUseType");

            migrationBuilder.AlterColumn<string>(
                name: "LandUseTypeDescription",
                schema: "est",
                table: "LandUseType",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);
        }
    }
}
