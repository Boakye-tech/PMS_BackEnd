using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddActivityRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ActivityType_ActivityId",
                schema: "est",
                table: "ActivityType",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityType_Activity_ActivityId",
                schema: "est",
                table: "ActivityType",
                column: "ActivityId",
                principalSchema: "est",
                principalTable: "Activity",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityType_Activity_ActivityId",
                schema: "est",
                table: "ActivityType");

            migrationBuilder.DropIndex(
                name: "IX_ActivityType_ActivityId",
                schema: "est",
                table: "ActivityType");
        }
    }
}
