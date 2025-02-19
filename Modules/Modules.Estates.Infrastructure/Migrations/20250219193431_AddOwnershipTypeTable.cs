using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnershipTypeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "est",
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPersonPhoneNumber",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.RenameColumn(
                name: "LastName",
                schema: "est",
                table: "CustomerMaster",
                newName: "SurName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "est",
                table: "CustomerMaster",
                newName: "OtherNames");

            migrationBuilder.RenameColumn(
                name: "DateIssued",
                schema: "est",
                table: "CustomerMaster",
                newName: "ResidentPermitExpiryDate");

            migrationBuilder.AlterColumn<string>(
                name: "ResidentPermitNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_Address",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_EmailAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_FullName",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactPerson_IdentificationTypeId",
                schema: "est",
                table: "CustomerMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_IdentificationTypeImage",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_IdentificationTypeNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson_PhoneNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalityId",
                schema: "est",
                table: "CustomerMaster",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResidentPermitDateIssued",
                schema: "est",
                table: "CustomerMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "OwnershipType",
                schema: "est",
                columns: table => new
                {
                    OwnershipTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnershipTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnershipType", x => x.OwnershipTypeId);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityDescription", "ActivityName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "VARIOUS LETTERS ON PROPERTY", "LETTERS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES", "DEPOSITS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OwnershipType",
                schema: "est");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "est",
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ContactPerson_Address",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPerson_EmailAddress",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPerson_FullName",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPerson_IdentificationTypeId",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPerson_IdentificationTypeImage",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPerson_IdentificationTypeNumber",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ContactPerson_PhoneNumber",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "LocalityId",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.DropColumn(
                name: "ResidentPermitDateIssued",
                schema: "est",
                table: "CustomerMaster");

            migrationBuilder.RenameColumn(
                name: "SurName",
                schema: "est",
                table: "CustomerMaster",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "ResidentPermitExpiryDate",
                schema: "est",
                table: "CustomerMaster",
                newName: "DateIssued");

            migrationBuilder.RenameColumn(
                name: "OtherNames",
                schema: "est",
                table: "CustomerMaster",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "ResidentPermitNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactPersonPhoneNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                schema: "est",
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityDescription", "ActivityName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 10, "VARIOUS LETTERS ON PROPERTY", "LETTERS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES", "DEPOSITS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
