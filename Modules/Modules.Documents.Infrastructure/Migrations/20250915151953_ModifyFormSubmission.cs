using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Documents.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifyFormSubmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApplicantEmail",
                schema: "doc",
                table: "ApplicationFormSubmission");

            migrationBuilder.DropColumn(
                name: "ApplicantName",
                schema: "doc",
                table: "ApplicationFormSubmission");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "doc",
                table: "ApplicationFormSubmission",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResponseValue",
                schema: "doc",
                table: "ApplicationFormResponse",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "doc",
                table: "ApplicationFormSubmission");

            migrationBuilder.AddColumn<string>(
                name: "ApplicantEmail",
                schema: "doc",
                table: "ApplicationFormSubmission",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApplicantName",
                schema: "doc",
                table: "ApplicationFormSubmission",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ResponseValue",
                schema: "doc",
                table: "ApplicationFormResponse",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
