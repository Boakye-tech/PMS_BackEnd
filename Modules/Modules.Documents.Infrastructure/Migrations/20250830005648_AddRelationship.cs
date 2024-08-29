using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FormTemplatesFormTemplateId",
                schema: "doc",
                table: "FormFields",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 1,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 2,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 3,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 4,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 5,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 6,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 7,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 8,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 9,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 10,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 11,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 12,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 13,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 14,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 15,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 16,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 17,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "doc",
                table: "FormFields",
                keyColumn: "FormFieldId",
                keyValue: 18,
                column: "FormTemplatesFormTemplateId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_FormTemplatesFormTemplateId",
                schema: "doc",
                table: "FormFields",
                column: "FormTemplatesFormTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_FormFields_FormTemplates_FormTemplatesFormTemplateId",
                schema: "doc",
                table: "FormFields",
                column: "FormTemplatesFormTemplateId",
                principalSchema: "doc",
                principalTable: "FormTemplates",
                principalColumn: "FormTemplateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FormFields_FormTemplates_FormTemplatesFormTemplateId",
                schema: "doc",
                table: "FormFields");

            migrationBuilder.DropIndex(
                name: "IX_FormFields_FormTemplatesFormTemplateId",
                schema: "doc",
                table: "FormFields");

            migrationBuilder.DropColumn(
                name: "FormTemplatesFormTemplateId",
                schema: "doc",
                table: "FormFields");
        }
    }
}
