using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModifiedLocalityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerCodeCounter",
                schema: "est",
                table: "Locality",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "WhatsAppNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "TinNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "SocialMediaAccount",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SecondaryMobileNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "ResidentialAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ResidentPermitNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "ParentCode",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "OtherNames",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "OfficeNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12);

            migrationBuilder.AlterColumn<string>(
                name: "InterestExpressed",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationTypeNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationTypeImageTwo",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationTypeImageOne",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "DigitalAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 1,
                column: "CustomerCodeCounter",
                value: 1052);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 2,
                column: "CustomerCodeCounter",
                value: 201);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 3,
                column: "CustomerCodeCounter",
                value: 123);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 4,
                column: "CustomerCodeCounter",
                value: 99);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 5,
                column: "CustomerCodeCounter",
                value: 101);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 6,
                column: "CustomerCodeCounter",
                value: 43);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 7,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 8,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 9,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 10,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 11,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 12,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 13,
                column: "CustomerCodeCounter",
                value: 5);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 14,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 15,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 16,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 17,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 18,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 19,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 20,
                column: "CustomerCodeCounter",
                value: 76);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 21,
                column: "CustomerCodeCounter",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 22,
                column: "CustomerCodeCounter",
                value: 22);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 23,
                column: "CustomerCodeCounter",
                value: 15);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 24,
                column: "CustomerCodeCounter",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 25,
                column: "CustomerCodeCounter",
                value: 53);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 26,
                column: "CustomerCodeCounter",
                value: 31);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 27,
                column: "CustomerCodeCounter",
                value: 501);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 28,
                column: "CustomerCodeCounter",
                value: 21);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 29,
                column: "CustomerCodeCounter",
                value: 411);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 30,
                column: "CustomerCodeCounter",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 31,
                column: "CustomerCodeCounter",
                value: 224);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 32,
                column: "CustomerCodeCounter",
                value: 102);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 33,
                column: "CustomerCodeCounter",
                value: 51);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 34,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 35,
                columns: new[] { "CustomerCode", "CustomerCodeCounter" },
                values: new object[] { "2HI", 103 });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 36,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 37,
                columns: new[] { "CustomerCode", "CustomerCodeCounter" },
                values: new object[] { "2LA", 103 });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 38,
                columns: new[] { "CustomerCode", "CustomerCodeCounter" },
                values: new object[] { "2TC", 103 });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 39,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 40,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 41,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 42,
                columns: new[] { "CustomerCode", "CustomerCodeCounter" },
                values: new object[] { "2MK", 103 });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 43,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 44,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 45,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 46,
                columns: new[] { "CustomerCode", "CustomerCodeCounter" },
                values: new object[] { "2MI", 103 });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 47,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 48,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 49,
                column: "CustomerCodeCounter",
                value: 103);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 50,
                columns: new[] { "CustomerCode", "CustomerCodeCounter" },
                values: new object[] { "2MS", 103 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerCodeCounter",
                schema: "est",
                table: "Locality");

            migrationBuilder.AlterColumn<string>(
                name: "WhatsAppNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TinNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SocialMediaAccount",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SecondaryMobileNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResidentialAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ResidentPermitNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Picture",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ParentCode",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherNames",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OfficeNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(12)",
                oldMaxLength: 12,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InterestExpressed",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationTypeNumber",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationTypeImageTwo",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdentificationTypeImageOne",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DigitalAddress",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                schema: "est",
                table: "CustomerMaster",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 35,
                column: "CustomerCode",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 37,
                column: "CustomerCode",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 38,
                column: "CustomerCode",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 42,
                column: "CustomerCode",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 46,
                column: "CustomerCode",
                value: "");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "Locality",
                keyColumn: "LocalityId",
                keyValue: 50,
                column: "CustomerCode",
                value: "");
        }
    }
}
