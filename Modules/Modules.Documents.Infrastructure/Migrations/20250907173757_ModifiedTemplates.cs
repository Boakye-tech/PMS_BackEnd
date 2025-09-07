using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedTemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FormSections_Name",
                schema: "doc",
                table: "FormSections");

            migrationBuilder.AlterColumn<string>(
                name: "LandUseTypeId",
                schema: "doc",
                table: "FormTemplates",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_FormSections_Name_FormTemplateId",
                schema: "doc",
                table: "FormSections",
                columns: new[] { "Name", "FormTemplateId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_Label_FormSectionId_FormTemplateId",
                schema: "doc",
                table: "FormFields",
                columns: new[] { "Label", "FormSectionId", "FormTemplateId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FormSections_Name_FormTemplateId",
                schema: "doc",
                table: "FormSections");

            migrationBuilder.DropIndex(
                name: "IX_FormFields_Label_FormSectionId_FormTemplateId",
                schema: "doc",
                table: "FormFields");

            migrationBuilder.AlterColumn<int>(
                name: "LandUseTypeId",
                schema: "doc",
                table: "FormTemplates",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_FormSections_Name",
                schema: "doc",
                table: "FormSections",
                column: "Name",
                unique: true);
        }
    }
}
