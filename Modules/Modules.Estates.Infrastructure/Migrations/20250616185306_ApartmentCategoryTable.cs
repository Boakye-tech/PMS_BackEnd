using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ApartmentCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ApartmentCategory",
                schema: "est",
                table: "ApartmentTypes",
                newName: "ApartmentCategoryId");

            migrationBuilder.CreateTable(
                name: "ApartmentCategory",
                schema: "est",
                columns: table => new
                {
                    ApartmentCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentCategory", x => x.ApartmentCategoryId);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "ApartmentCategory",
                columns: new[] { "ApartmentCategoryId", "ApartmentCategoryName", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "AFFORDABLE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "LUXURY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "MIDRANGE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes",
                column: "ApartmentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentCategory_ApartmentCategoryName",
                schema: "est",
                table: "ApartmentCategory",
                column: "ApartmentCategoryName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentTypes_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes",
                column: "ApartmentCategoryId",
                principalSchema: "est",
                principalTable: "ApartmentCategory",
                principalColumn: "ApartmentCategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentTypes_ApartmentCategory_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.DropTable(
                name: "ApartmentCategory",
                schema: "est");

            migrationBuilder.DropIndex(
                name: "IX_ApartmentTypes_ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes");

            migrationBuilder.RenameColumn(
                name: "ApartmentCategoryId",
                schema: "est",
                table: "ApartmentTypes",
                newName: "ApartmentCategory");
        }
    }
}
