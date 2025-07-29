using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaseDetailsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionBy",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.RenameColumn(
                name: "DebtorStatus",
                schema: "est",
                table: "StopDebit",
                newName: "PreviousGroupNumber");

            migrationBuilder.RenameColumn(
                name: "ActionOn",
                schema: "est",
                table: "StopDebit",
                newName: "ModifiedOn");

            migrationBuilder.RenameColumn(
                name: "PlotDimension",
                schema: "est",
                table: "PropertyMaster",
                newName: "RoomSize");

            migrationBuilder.AlterColumn<string>(
                name: "Reasons",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                schema: "est",
                table: "StopDebit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedOn",
                schema: "est",
                table: "StopDebit",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GroupNumber",
                schema: "est",
                table: "StopDebit",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfConstruction",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfTenancy",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTransferedToHos",
                schema: "est",
                table: "PropertyMaster",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PlotAcreage2",
                schema: "est",
                table: "PropertyMaster",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlotDimensionId",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RenewablePeriod",
                schema: "est",
                table: "LeaseTypeAndPeriod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ActivityTransactions",
                schema: "est",
                columns: table => new
                {
                    ActivityTransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PropertyNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivityTypeId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityTransactions", x => x.ActivityTransactionId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyLeaseDetails",
                schema: "est",
                columns: table => new
                {
                    PropertyLeaseDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyNumber = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LeaseTypePeriodId = table.Column<int>(type: "int", nullable: false),
                    LeaseStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaseTerm = table.Column<int>(type: "int", nullable: false),
                    RenewableTerm = table.Column<int>(type: "int", nullable: false),
                    MaxRenewalCount = table.Column<int>(type: "int", nullable: false),
                    CurrentRenewalCount = table.Column<int>(type: "int", nullable: false),
                    LastRenewalStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaseStatusId = table.Column<int>(type: "int", nullable: false),
                    RenewalStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyLeaseDetails", x => x.PropertyLeaseDetailsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityTransactions_PropertyNumber_CustomerCode_ActivityId_ActivityTypeId_ActivityDate",
                schema: "est",
                table: "ActivityTransactions",
                columns: new[] { "PropertyNumber", "CustomerCode", "ActivityId", "ActivityTypeId", "ActivityDate" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyLeaseDetails_PropertyNumber_CustomerCode_LeaseTypePeriodId_LeaseStartDate",
                schema: "est",
                table: "PropertyLeaseDetails",
                columns: new[] { "PropertyNumber", "CustomerCode", "LeaseTypePeriodId", "LeaseStartDate" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityTransactions",
                schema: "est");

            migrationBuilder.DropTable(
                name: "PropertyLeaseDetails",
                schema: "est");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.DropColumn(
                name: "DeletedOn",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.DropColumn(
                name: "GroupNumber",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                schema: "est",
                table: "StopDebit");

            migrationBuilder.DropColumn(
                name: "DateOfConstruction",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "DateOfTenancy",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "DateTransferedToHos",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "PlotAcreage2",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "PlotDimensionId",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "RenewablePeriod",
                schema: "est",
                table: "LeaseTypeAndPeriod");

            migrationBuilder.RenameColumn(
                name: "PreviousGroupNumber",
                schema: "est",
                table: "StopDebit",
                newName: "DebtorStatus");

            migrationBuilder.RenameColumn(
                name: "ModifiedOn",
                schema: "est",
                table: "StopDebit",
                newName: "ActionOn");

            migrationBuilder.RenameColumn(
                name: "RoomSize",
                schema: "est",
                table: "PropertyMaster",
                newName: "PlotDimension");

            migrationBuilder.AlterColumn<string>(
                name: "Reasons",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PropertyNumber",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActionBy",
                schema: "est",
                table: "StopDebit",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);
        }
    }
}
