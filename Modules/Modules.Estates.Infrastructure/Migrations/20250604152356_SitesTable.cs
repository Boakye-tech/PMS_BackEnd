using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SitesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityType_Activity_ActivityId",
                schema: "est",
                table: "ActivityType");

            migrationBuilder.DropForeignKey(
                name: "FK_LandUseType_LandUse_LandUseId",
                schema: "est",
                table: "LandUseType");

            migrationBuilder.DropColumn(
                name: "DocumentOne",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DocumentThree",
                schema: "est",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "DocumentTwo",
                schema: "est",
                table: "Complaints");

            migrationBuilder.AlterColumn<int>(
                name: "RoomNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

            migrationBuilder.AddColumn<string>(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DocumentList",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sites",
                schema: "est",
                columns: table => new
                {
                    SitesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalityId = table.Column<int>(type: "int", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sites", x => x.SitesId);
                    table.ForeignKey(
                        name: "FK_Sites_Locality_LocalityId",
                        column: x => x.LocalityId,
                        principalSchema: "est",
                        principalTable: "Locality",
                        principalColumn: "LocalityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "Sites",
                columns: new[] { "SitesId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "LocalityId", "ModifiedBy", "ModifiedOn", "SiteName" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SITE 3" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SITE 5" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SITE 7" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SITE 3" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TOWERS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sites_LocalityId_SiteName",
                schema: "est",
                table: "Sites",
                columns: new[] { "LocalityId", "SiteName" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityType_Activity_ActivityId",
                schema: "est",
                table: "ActivityType",
                column: "ActivityId",
                principalSchema: "est",
                principalTable: "Activity",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LandUseType_LandUse_LandUseId",
                schema: "est",
                table: "LandUseType",
                column: "LandUseId",
                principalSchema: "est",
                principalTable: "LandUse",
                principalColumn: "LandUseId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActivityType_Activity_ActivityId",
                schema: "est",
                table: "ActivityType");

            migrationBuilder.DropForeignKey(
                name: "FK_LandUseType_LandUse_LandUseId",
                schema: "est",
                table: "LandUseType");

            migrationBuilder.DropTable(
                name: "Sites",
                schema: "est");

            migrationBuilder.DropColumn(
                name: "PlotNumber",
                schema: "est",
                table: "PropertyMaster");

            migrationBuilder.DropColumn(
                name: "DocumentList",
                schema: "est",
                table: "Complaints");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                schema: "est",
                table: "PropertyMaster",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DocumentOne",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentThree",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentTwo",
                schema: "est",
                table: "Complaints",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ActivityType_Activity_ActivityId",
                schema: "est",
                table: "ActivityType",
                column: "ActivityId",
                principalSchema: "est",
                principalTable: "Activity",
                principalColumn: "ActivityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LandUseType_LandUse_LandUseId",
                schema: "est",
                table: "LandUseType",
                column: "LandUseId",
                principalSchema: "est",
                principalTable: "LandUse",
                principalColumn: "LandUseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
