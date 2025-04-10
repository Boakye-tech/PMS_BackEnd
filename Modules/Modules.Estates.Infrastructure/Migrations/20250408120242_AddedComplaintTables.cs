using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedComplaintTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Complaints",
                schema: "est",
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
                    table.PrimaryKey("PK_Complaints", x => x.ComplaintId);
                });

            migrationBuilder.CreateTable(
                name: "ComplaintType",
                schema: "est",
                columns: table => new
                {
                    ComplaintTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintTypes = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplaintType", x => x.ComplaintTypeId);
                });

            migrationBuilder.CreateTable(
                name: "NatureOfComplaint",
                schema: "est",
                columns: table => new
                {
                    NatureOfComplaintId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplaintTypeId = table.Column<int>(type: "int", nullable: false),
                    NatureOfComplaints = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NatureOfComplaint", x => x.NatureOfComplaintId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complaints",
                schema: "est");

            migrationBuilder.DropTable(
                name: "ComplaintType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "NatureOfComplaint",
                schema: "est");
        }
    }
}
