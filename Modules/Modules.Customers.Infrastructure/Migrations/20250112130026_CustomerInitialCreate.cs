using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CustomerInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cus");

            migrationBuilder.CreateTable(
                name: "Complaint",
                schema: "cus",
                columns: table => new
                {
                    ComplaintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Locality = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DetailsOfComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTheMatterInCourt = table.Column<bool>(type: "bit", nullable: false),
                    ComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmittedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentOne = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentTwo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentThree = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDetails",
                schema: "cus",
                columns: table => new
                {
                    CustomerMasterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false),
                    ResidentTypeId = table.Column<int>(type: "int", nullable: false),
                    LocalityId = table.Column<int>(type: "int", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TitleId = table.Column<int>(type: "int", nullable: false),
                    SurName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OtherNames = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    EmailAddress = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SocialMediaTypeId = table.Column<int>(type: "int", nullable: false),
                    SocialMediaAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDetails", x => x.CustomerMasterId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInvoice",
                schema: "cus",
                columns: table => new
                {
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Acreage = table.Column<double>(type: "float", nullable: false),
                    TransactionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInvoice", x => x.InvoiceNumber);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInvoiceItems",
                schema: "cus",
                columns: table => new
                {
                    InvoiceItemsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInvoiceItems", x => x.InvoiceItemsId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerPayments",
                schema: "cus",
                columns: table => new
                {
                    ReceiptNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateOfPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    AmountPaid = table.Column<float>(type: "real", nullable: false),
                    IssuingBank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuingBranch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChequeNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PayeeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Narration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPayments", x => x.ReceiptNumber);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTransactions",
                schema: "cus",
                columns: table => new
                {
                    CustomerTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoucherNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChequeNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AccountCode = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    VoucherType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTransactions", x => x.CustomerTransactionId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyDetails",
                schema: "cus",
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
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SitePlanNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CadastralPlanNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CoordinateOne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateTwo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateThree = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateFour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateFive = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CoordinateSix = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsLargeScale = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyDetails", x => x.PropertyMasterId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDetails_CustomerCode",
                schema: "cus",
                table: "CustomerDetails",
                column: "CustomerCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoice_InvoiceNumber",
                schema: "cus",
                table: "CustomerInvoice",
                column: "InvoiceNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoice_InvoiceNumber_CustomerCode",
                schema: "cus",
                table: "CustomerInvoice",
                columns: new[] { "InvoiceNumber", "CustomerCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPayments_ReceiptNumber",
                schema: "cus",
                table: "CustomerPayments",
                column: "ReceiptNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPayments_ReceiptNumber_CustomerCode",
                schema: "cus",
                table: "CustomerPayments",
                columns: new[] { "ReceiptNumber", "CustomerCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_VoucherNumber",
                schema: "cus",
                table: "CustomerTransactions",
                column: "VoucherNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTransactions_VoucherNumber_CustomerCode",
                schema: "cus",
                table: "CustomerTransactions",
                columns: new[] { "VoucherNumber", "CustomerCode" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyDetails_PropertyNumber",
                schema: "cus",
                table: "PropertyDetails",
                column: "PropertyNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaint",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "CustomerDetails",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "CustomerInvoice",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "CustomerInvoiceItems",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "CustomerPayments",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "CustomerTransactions",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "PropertyDetails",
                schema: "cus");
        }
    }
}
