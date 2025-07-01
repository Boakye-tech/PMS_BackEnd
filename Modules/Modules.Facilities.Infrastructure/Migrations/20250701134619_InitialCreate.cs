using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Facilities.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "fac");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "fac",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cleaners",
                schema: "fac",
                columns: table => new
                {
                    StaffID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfilePhoto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedProperties = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Images = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cleaners", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "ItemsCategory",
                schema: "fac",
                columns: table => new
                {
                    ItemCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsCategory", x => x.ItemCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceProviders",
                schema: "fac",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyRegistrationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TINNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DigitalAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Images = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ListOfServices = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ContactPerson_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactPerson_MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPerson_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactPerson_JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPerson_PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContactPerson_EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProviders", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                schema: "fac",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                schema: "fac",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyRegistrationNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TINNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyAddress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DigitalAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Images = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ContactPerson_FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactPerson_MiddleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPerson_LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactPerson_JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactPerson_PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ContactPerson_EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                schema: "fac",
                columns: table => new
                {
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ItemCategoryId = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ItemsCategoryItemCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemCode);
                    table.ForeignKey(
                        name: "FK_Items_ItemsCategory_ItemsCategoryItemCategoryId",
                        column: x => x.ItemsCategoryItemCategoryId,
                        principalSchema: "fac",
                        principalTable: "ItemsCategory",
                        principalColumn: "ItemCategoryId");
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategory",
                schema: "fac",
                columns: table => new
                {
                    ServiceCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServicesServiceId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCategory", x => x.ServiceCategoryId);
                    table.ForeignKey(
                        name: "FK_ServiceCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "fac",
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServiceCategory_Services_ServicesServiceId",
                        column: x => x.ServicesServiceId,
                        principalSchema: "fac",
                        principalTable: "Services",
                        principalColumn: "ServiceId");
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                schema: "fac",
                columns: table => new
                {
                    StockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReceiptNoteNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantityReceived = table.Column<int>(type: "int", nullable: true),
                    IssueNoteNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    QuantityIssues = table.Column<int>(type: "int", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LowStockThreshold = table.Column<int>(type: "int", nullable: false),
                    LastRestockedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemsItemCode = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    SuppliersSupplierID = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.StockId);
                    table.ForeignKey(
                        name: "FK_Stock_Items_ItemsItemCode",
                        column: x => x.ItemsItemCode,
                        principalSchema: "fac",
                        principalTable: "Items",
                        principalColumn: "ItemCode");
                    table.ForeignKey(
                        name: "FK_Stock_Suppliers_SuppliersSupplierID",
                        column: x => x.SuppliersSupplierID,
                        principalSchema: "fac",
                        principalTable: "Suppliers",
                        principalColumn: "SupplierID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemsCategoryItemCategoryId",
                schema: "fac",
                table: "Items",
                column: "ItemsCategoryItemCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCategory_CategoryId",
                schema: "fac",
                table: "ServiceCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceCategory_ServicesServiceId",
                schema: "fac",
                table: "ServiceCategory",
                column: "ServicesServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_ItemsItemCode",
                schema: "fac",
                table: "Stock",
                column: "ItemsItemCode");

            migrationBuilder.CreateIndex(
                name: "IX_Stock_SuppliersSupplierID",
                schema: "fac",
                table: "Stock",
                column: "SuppliersSupplierID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cleaners",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "ServiceCategory",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "ServiceProviders",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "Stock",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "Services",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "Items",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "Suppliers",
                schema: "fac");

            migrationBuilder.DropTable(
                name: "ItemsCategory",
                schema: "fac");
        }
    }
}
