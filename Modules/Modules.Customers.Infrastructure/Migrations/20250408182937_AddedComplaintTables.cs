using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Customers.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedComplaintTables : Migration
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
                    ComplaintTypeId = table.Column<int>(type: "int", nullable: false),
                    NatureOfComplaintId = table.Column<int>(type: "int", nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PropertyLocationId = table.Column<int>(type: "int", nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CustomerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    IsTheMatterInCourt = table.Column<bool>(type: "bit", nullable: false),
                    DetailsOfComplaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmittedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    DocumentOne = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentTwo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DocumentThree = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ComplaintStatus = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ReviewedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    DateReviewed = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AssignedTo = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    AssignedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    DateAssigned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResolvedBy = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ResolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaint", x => x.ComplaintId);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintType",
                schema: "cus",
                columns: table => new
                {
                    ComplaintTypeId = table.Column<int>(type: "int", nullable: false),
                    ComplaintTypes = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintType", x => x.ComplaintTypeId);
                });

           

           
           

            migrationBuilder.CreateTable(
                name: "NatureOfComplaint",
                schema: "cus",
                columns: table => new
                {
                    NatureOfComplaintId = table.Column<int>(type: "int", nullable: false),
                    ComplaintTypeId = table.Column<int>(type: "int", nullable: false),
                    NatureOfComplaints = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureOfComplaint", x => x.NatureOfComplaintId);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_Complaint_ComplaintNumber",
                schema: "cus",
                table: "Complaint",
                column: "ComplaintNumber",
                unique: true);

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaint",
                schema: "cus");

            migrationBuilder.DropTable(
                name: "ComplaintType",
                schema: "cus");

            

            migrationBuilder.DropTable(
                name: "NatureOfComplaint",
                schema: "cus");

           
        }
    }
}
