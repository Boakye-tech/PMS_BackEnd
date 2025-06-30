using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Added_Plotfeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlotFeatures",
                schema: "est",
                columns: table => new
                {
                    PlotFeaturesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotTypeId = table.Column<int>(type: "int", nullable: false),
                    FeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlotFeatures", x => x.PlotFeaturesId);
                    table.ForeignKey(
                        name: "FK_PlotFeatures_Features_FeaturesId",
                        column: x => x.FeaturesId,
                        principalSchema: "est",
                        principalTable: "Features",
                        principalColumn: "FeaturesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlotFeatures_PlotType_PlotTypeId",
                        column: x => x.PlotTypeId,
                        principalSchema: "est",
                        principalTable: "PlotType",
                        principalColumn: "PlotTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlotFeatures_FeaturesId",
                schema: "est",
                table: "PlotFeatures",
                column: "FeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_PlotFeatures_PlotTypeId_FeaturesId",
                schema: "est",
                table: "PlotFeatures",
                columns: new[] { "PlotTypeId", "FeaturesId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlotFeatures",
                schema: "est");
        }
    }
}
