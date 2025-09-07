using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "doc");

            migrationBuilder.CreateTable(
                name: "FormTemplates",
                schema: "doc",
                columns: table => new
                {
                    FormTemplateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandUseId = table.Column<int>(type: "int", nullable: false),
                    LandUseTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTemplates", x => x.FormTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationFormSubmission",
                schema: "doc",
                columns: table => new
                {
                    FormSubmissionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1000000, 1"),
                    FormTemplateId = table.Column<int>(type: "int", nullable: false),
                    ApplicantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicantEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkflowState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubmittedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastStatusChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFormSubmission", x => x.FormSubmissionId);
                    table.ForeignKey(
                        name: "FK_ApplicationFormSubmission_FormTemplates_FormTemplateId",
                        column: x => x.FormTemplateId,
                        principalSchema: "doc",
                        principalTable: "FormTemplates",
                        principalColumn: "FormTemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormSections",
                schema: "doc",
                columns: table => new
                {
                    FormSectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    FormTemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormSections", x => x.FormSectionId);
                    table.ForeignKey(
                        name: "FK_FormSections_FormTemplates_FormTemplateId",
                        column: x => x.FormTemplateId,
                        principalSchema: "doc",
                        principalTable: "FormTemplates",
                        principalColumn: "FormTemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatusHistory",
                schema: "doc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkflowState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormSubmissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusHistory_ApplicationFormSubmission_FormSubmissionId",
                        column: x => x.FormSubmissionId,
                        principalSchema: "doc",
                        principalTable: "ApplicationFormSubmission",
                        principalColumn: "FormSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormFields",
                schema: "doc",
                columns: table => new
                {
                    FormFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FieldType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    Options = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    FormSectionId = table.Column<int>(type: "int", nullable: false),
                    FormTemplateId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDeleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFields", x => x.FormFieldId);
                    table.ForeignKey(
                        name: "FK_FormFields_FormSections_FormSectionId",
                        column: x => x.FormSectionId,
                        principalSchema: "doc",
                        principalTable: "FormSections",
                        principalColumn: "FormSectionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FormFields_FormTemplates_FormTemplateId",
                        column: x => x.FormTemplateId,
                        principalSchema: "doc",
                        principalTable: "FormTemplates",
                        principalColumn: "FormTemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationFormResponse",
                schema: "doc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormSubmissionId = table.Column<int>(type: "int", nullable: false),
                    FormTemplateId = table.Column<int>(type: "int", nullable: false),
                    FormFieldId = table.Column<int>(type: "int", nullable: false),
                    ResponseValue = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationFormResponse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationFormResponse_ApplicationFormSubmission_FormSubmissionId",
                        column: x => x.FormSubmissionId,
                        principalSchema: "doc",
                        principalTable: "ApplicationFormSubmission",
                        principalColumn: "FormSubmissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationFormResponse_FormFields_FormFieldId",
                        column: x => x.FormFieldId,
                        principalSchema: "doc",
                        principalTable: "FormFields",
                        principalColumn: "FormFieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFormResponse_FormFieldId",
                schema: "doc",
                table: "ApplicationFormResponse",
                column: "FormFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFormResponse_FormSubmissionId",
                schema: "doc",
                table: "ApplicationFormResponse",
                column: "FormSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationFormSubmission_FormTemplateId",
                schema: "doc",
                table: "ApplicationFormSubmission",
                column: "FormTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_FormSectionId",
                schema: "doc",
                table: "FormFields",
                column: "FormSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_FormFields_FormTemplateId",
                schema: "doc",
                table: "FormFields",
                column: "FormTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSections_FormTemplateId",
                schema: "doc",
                table: "FormSections",
                column: "FormTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_FormSections_Name",
                schema: "doc",
                table: "FormSections",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormTemplates_Name",
                schema: "doc",
                table: "FormTemplates",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StatusHistory_FormSubmissionId",
                schema: "doc",
                table: "StatusHistory",
                column: "FormSubmissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationFormResponse",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "StatusHistory",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "FormFields",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "ApplicationFormSubmission",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "FormSections",
                schema: "doc");

            migrationBuilder.DropTable(
                name: "FormTemplates",
                schema: "doc");
        }
    }
}
