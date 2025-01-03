using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddActivityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity",
                schema: "est",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActivityDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "ActivityType",
                schema: "est",
                columns: table => new
                {
                    ActivityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivityTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ActivityTypeDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.ActivityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerMaster",
                schema: "est",
                columns: table => new
                {
                    CustomerMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    ResidentTypeId = table.Column<int>(type: "int", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    NationalityId = table.Column<int>(type: "int", nullable: false),
                    PostalAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ResidentialAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DigitalAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimaryMobileNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    SecondaryMobileNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    OfficeNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    WhatsAppNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentPermitNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateIssued = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactPerson = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContactPersonPhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    SocialMediaTypeId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdentificationTypeId = table.Column<int>(type: "int", nullable: false),
                    IdentificationTypeNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IdentificationTypeImageOne = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdentificationTypeImageTwo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    InterestExpressed = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DebtorStatus = table.Column<int>(type: "int", nullable: false),
                    ParentCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerMaster", x => x.CustomerMasterId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyMaster",
                schema: "est",
                columns: table => new
                {
                    PropertyMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false),
                    LandUseId = table.Column<int>(type: "int", nullable: false),
                    LandUseTypeId = table.Column<int>(type: "int", nullable: false),
                    AllocationTypeId = table.Column<int>(type: "int", nullable: false),
                    BlockNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PlotNumber = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    AcreageOne = table.Column<double>(type: "float", nullable: false),
                    AcreageTwo = table.Column<double>(type: "float", nullable: false),
                    PropertyHeightId = table.Column<int>(type: "int", nullable: false),
                    PlotSizeId = table.Column<int>(type: "int", nullable: false),
                    SellingPrice = table.Column<double>(type: "float", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    RentalType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TotalNumberOfRooms = table.Column<int>(type: "int", nullable: false),
                    RoomsOccupied = table.Column<int>(type: "int", nullable: false),
                    ApartmentTypeId = table.Column<int>(type: "int", nullable: false),
                    SchemeTypeId = table.Column<int>(type: "int", nullable: false),
                    ApartmentBlockNumberId = table.Column<int>(type: "int", nullable: false),
                    BlockTypeId = table.Column<int>(type: "int", nullable: false),
                    FloorNumberId = table.Column<int>(type: "int", nullable: false),
                    BlockUnitId = table.Column<int>(type: "int", nullable: false),
                    BlockSideId = table.Column<int>(type: "int", nullable: false),
                    FloorArea = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    RightOfEntry = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaseTerm = table.Column<int>(type: "int", nullable: false),
                    LeaseExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DebtorType = table.Column<int>(type: "int", nullable: false),
                    GroupNumber = table.Column<int>(type: "int", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SitePlanNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CadastralPlanNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CoordinateOne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateTwo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateThree = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateFour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateFive = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateSix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MotherPropertyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsLargeScale = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyMaster", x => x.PropertyMasterId);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityDescription", "ActivityName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 10, "VARIOUS LETTERS ON PROPERTY", "LETTERS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES", "DEPOSITS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "ActivityType",
                columns: new[] { "ActivityTypeId", "ActivityId", "ActivityTypeDescription", "ActivityTypeName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 2, 1, "Initial Letter", "APPLICATION LETTER", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, "Acceptance Letter written by customer", "ACCEPTANCE LETTER", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, "Offer Letter Sent to customer", "OFFER LETTER", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES", "KEYS DEPOSITS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, "VARIOUS CUSTOMER DEPOSITS ON PROPERTIES", "WATER DEPOSITS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 5,
                column: "PropertyTypes",
                value: "H.O.S APARTMENT");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 6,
                column: "PropertyTypes",
                value: "SHOP/OFFICE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 7,
                column: "PropertyTypes",
                value: "RENTAL HOUSE");

            migrationBuilder.InsertData(
                schema: "est",
                table: "PropertyType",
                columns: new[] { "PropertyTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "PropertyTypes" },
                values: new object[] { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APARTMENT" });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivityName",
                schema: "est",
                table: "Activity",
                column: "ActivityName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ActivityType_ActivityTypeName",
                schema: "est",
                table: "ActivityType",
                column: "ActivityTypeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerMaster_CustomerCode",
                schema: "est",
                table: "CustomerMaster",
                column: "CustomerCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyMaster_PropertyNumber",
                schema: "est",
                table: "PropertyMaster",
                column: "PropertyNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity",
                schema: "est");

            migrationBuilder.DropTable(
                name: "ActivityType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "CustomerMaster",
                schema: "est");

            migrationBuilder.DropTable(
                name: "PropertyMaster",
                schema: "est");

            migrationBuilder.DeleteData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 5,
                column: "PropertyTypes",
                value: "SHOPS/OFFICES");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 6,
                column: "PropertyTypes",
                value: "RENTAL HOUSE");

            migrationBuilder.UpdateData(
                schema: "est",
                table: "PropertyType",
                keyColumn: "PropertyTypeId",
                keyValue: 7,
                column: "PropertyTypes",
                value: "APARTMENTS");
        }
    }
}
