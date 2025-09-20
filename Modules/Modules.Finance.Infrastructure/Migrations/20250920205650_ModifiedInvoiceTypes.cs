using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Finance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedInvoiceTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentUnit_Department_DepartmentId",
                schema: "fin",
                table: "DepartmentUnit");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "fin",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                schema: "fin",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "InvoiceAmount",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropColumn(
                name: "InvoiceInitials",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceDescriptions",
                schema: "fin",
                table: "InvoiceTypes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                schema: "fin",
                table: "InvoiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentUnitId",
                schema: "fin",
                table: "InvoiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceName",
                schema: "fin",
                table: "InvoiceTypes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PaymentTermsId",
                schema: "fin",
                table: "InvoiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                schema: "fin",
                table: "InvoiceTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceTypes",
                schema: "fin",
                table: "InvoiceTypes",
                column: "InvoiceTypesId");

            migrationBuilder.CreateTable(
                name: "InvoiceTypeServices",
                schema: "fin",
                columns: table => new
                {
                    InvoiceTypesId = table.Column<int>(type: "int", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceTypeServices", x => new { x.InvoiceTypesId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_InvoiceTypeServices_InvoiceTypes_InvoiceTypesId",
                        column: x => x.InvoiceTypesId,
                        principalSchema: "fin",
                        principalTable: "InvoiceTypes",
                        principalColumn: "InvoiceTypesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InvoiceTypeServices_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalSchema: "fin",
                        principalTable: "Services",
                        principalColumn: "ServicesId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTerms",
                schema: "fin",
                columns: table => new
                {
                    PaymentTermsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTerm = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTerms", x => x.PaymentTermsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypes_DepartmentId",
                schema: "fin",
                table: "InvoiceTypes",
                column: "DepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceTypeServices_ServicesId",
                schema: "fin",
                table: "InvoiceTypeServices",
                column: "ServicesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentUnit_Department_DepartmentId",
                schema: "fin",
                table: "DepartmentUnit",
                column: "DepartmentId",
                principalSchema: "fin",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceTypes_Department_DepartmentId",
                schema: "fin",
                table: "InvoiceTypes",
                column: "DepartmentId",
                principalSchema: "fin",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentUnit_Department_DepartmentId",
                schema: "fin",
                table: "DepartmentUnit");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceTypes_Department_DepartmentId",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropTable(
                name: "InvoiceTypeServices",
                schema: "fin");

            migrationBuilder.DropTable(
                name: "PaymentTerms",
                schema: "fin");

            migrationBuilder.DropIndex(
                name: "IX_InvoiceTypes_DepartmentId",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropColumn(
                name: "DepartmentUnitId",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropColumn(
                name: "InvoiceName",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropColumn(
                name: "PaymentTermsId",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.DropColumn(
                name: "RoomNumber",
                schema: "fin",
                table: "InvoiceTypes");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                schema: "fin",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoomNumber",
                schema: "fin",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceDescriptions",
                schema: "fin",
                table: "InvoiceTypes",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<double>(
                name: "InvoiceAmount",
                schema: "fin",
                table: "InvoiceTypes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "InvoiceInitials",
                schema: "fin",
                table: "InvoiceTypes",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentUnit_Department_DepartmentId",
                schema: "fin",
                table: "DepartmentUnit",
                column: "DepartmentId",
                principalSchema: "fin",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
