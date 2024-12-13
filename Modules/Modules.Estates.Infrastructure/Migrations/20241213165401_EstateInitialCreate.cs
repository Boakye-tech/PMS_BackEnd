using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modules.Estates.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EstateInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "est");

            migrationBuilder.CreateTable(
                name: "AllocationType",
                schema: "est",
                columns: table => new
                {
                    AllocationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllocationTypeInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    AllocationTypes = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllocationType", x => x.AllocationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentTypes",
                schema: "est",
                columns: table => new
                {
                    ApartmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SellingPrice = table.Column<float>(type: "real", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    FloorArea = table.Column<double>(type: "float", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentTypes", x => x.ApartmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BlockNumber",
                schema: "est",
                columns: table => new
                {
                    BlockNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockNumbers = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockNumber", x => x.BlockNumberId);
                });

            migrationBuilder.CreateTable(
                name: "BlockSides",
                schema: "est",
                columns: table => new
                {
                    SideId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Side = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockSides", x => x.SideId);
                });

            migrationBuilder.CreateTable(
                name: "BlockStatus",
                schema: "est",
                columns: table => new
                {
                    BlockStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockStatusType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockStatus", x => x.BlockStatusId);
                });

            migrationBuilder.CreateTable(
                name: "BlockTypes",
                schema: "est",
                columns: table => new
                {
                    BlockTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockTypes", x => x.BlockTypeId);
                });

            migrationBuilder.CreateTable(
                name: "BlockUnit",
                schema: "est",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlockUnit", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerType",
                schema: "est",
                columns: table => new
                {
                    CustomerTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerType", x => x.CustomerTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Facilities",
                schema: "est",
                columns: table => new
                {
                    FacilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facility = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facilities", x => x.FacilityId);
                });

            migrationBuilder.CreateTable(
                name: "FloorNumbering",
                schema: "est",
                columns: table => new
                {
                    FloorNumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorNumbering", x => x.FloorNumberId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                schema: "est",
                columns: table => new
                {
                    GenderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.GenderId);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationType",
                schema: "est",
                columns: table => new
                {
                    IdentificationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdentificationTypes = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationType", x => x.IdentificationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LandUse",
                schema: "est",
                columns: table => new
                {
                    LandUseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandUseInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LandUseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandUse", x => x.LandUseId);
                });

            migrationBuilder.CreateTable(
                name: "LandUseType",
                schema: "est",
                columns: table => new
                {
                    LandUseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LandUseId = table.Column<int>(type: "int", nullable: false),
                    LandUseTypeInitial = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    LandUseTypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LandUseType", x => x.LandUseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Locality",
                schema: "est",
                columns: table => new
                {
                    LocalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalityInitial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocalityName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CustomerCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locality", x => x.LocalityId);
                });

            migrationBuilder.CreateTable(
                name: "Nationality",
                schema: "est",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nationalities = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationality", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "PlotSize",
                schema: "est",
                columns: table => new
                {
                    PlotSizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlotSizes = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlotSize", x => x.PlotSizeId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyHeight",
                schema: "est",
                columns: table => new
                {
                    PropertyHeightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyHeights = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyHeight", x => x.PropertyHeightId);
                });

            migrationBuilder.CreateTable(
                name: "PropertyType",
                schema: "est",
                columns: table => new
                {
                    PropertyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyType", x => x.PropertyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ResidentType",
                schema: "est",
                columns: table => new
                {
                    ResidentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentTypes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentType", x => x.ResidentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                schema: "est",
                columns: table => new
                {
                    SocialMediaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialMediaPlatform = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.SocialMediaId);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                schema: "est",
                columns: table => new
                {
                    TitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titles = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.TitleId);
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "AllocationType",
                columns: new[] { "AllocationTypeId", "AllocationTypeInitial", "AllocationTypes", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, "DTA", "DIRECT ALLOCATION", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "DTR", "DIRECT RENT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "RGU", "REGULARIZATION", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "DPA", "DUTY POST ALLOCATION", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "TTC", "TEMA TRADITIONAL COUNCIL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "NTC", "NUNGUA TRADITIONAL COUNCIL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "KTC", "KPONE TRADITIONAL COUNCIL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "ApartmentTypes",
                columns: new[] { "ApartmentTypeId", "ApartmentType", "CreatedBy", "CreatedOn", "CurrencyId", "DeletedBy", "DeletedOn", "FloorArea", "ModifiedBy", "ModifiedOn", "SellingPrice" },
                values: new object[,]
                {
                    { 1, "STUDIO", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 27.43, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000f },
                    { 2, "ONE BEDROOM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 41.119999999999997, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17000f },
                    { 3, "ONE BEDROOM (SPECIAL)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.630000000000003, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 24000f },
                    { 4, "TWO BEDROOMS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 74.799999999999997, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 28000f }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "LandUse",
                columns: new[] { "LandUseId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "LandUseInitial", "LandUseName", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RPL", "RESIDENTIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HOS", "HOUSE OWNERSHIP SCHEME", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LSD", "LARGE SCALE DEVELOPMENT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HSE", "HOUSE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "FLT", "FLAT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CPL", "COMMERCIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SHP", "SHOPS & OFFICES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LIC", "LICENSE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IND", "INDUSTRIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "EMT", "EASEMENT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "INS", "INSTITUTIONAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "REC", "RECREATIONAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "LandUseType",
                columns: new[] { "LandUseTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "LandUseId", "LandUseTypeInitial", "LandUseTypeName", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "TDC BUILT HOUSES (HOS)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "LESSEE BUILT HOUSES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "APARTMENTS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "HOUSES BY ESTATE DEVELOPERS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "SHP", "SHOPS & OFFICES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "RES", "RESTAURANTS & PUS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "HTL", "GUEST HOUSE & HOTELS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "PFS", "PETROL FILLING STATION", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "EVT", "EVENT CENTRES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "CLH", "CLUB HOUSES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "WHB", "WASHING BAY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "CMS", "CORN MILL SITE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "LIC", "LICENSE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "HIA", "HEAVY INDUSTRIAL ACTIVITIES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "LIA", "LIGHT INDUSTRIAL ACTIVITIES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "AGR", "AGRO INDUSTRIAL ACTIVITIES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "EMT", "EASEMENT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "SCH", "SCHOOLS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "CHU", "CHURCHES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "MOS", "MOSQUES", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "LIB", "LIBRARY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "PUB", "PUBLIC INSTITUTIONS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "CLI", "CLINICS & HOSPITALS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "GOC", "GOLF COURSE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "PLG", "PLAYGROUND", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "HOR", "HORTICULTURE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "Locality",
                columns: new[] { "LocalityId", "CreatedBy", "CreatedOn", "CustomerCode", "DeletedBy", "DeletedOn", "LocalityInitial", "LocalityName", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2A", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C01", "COMMUNITY 1", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2B", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C02", "COMMUNITY 2", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2C", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C03", "COMMUNITY 3", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2D", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C04", "COMMUNITY 4", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2E", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C05", "COMMUNITY 5", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2F", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C06", "COMMUNITY 6", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2G", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C07", "COMMUNITY 7", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2H", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C08", "COMMUNITY 8", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2I", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C09", "COMMUNITY 9", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2J", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C10", "COMMUNITY 10", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2K", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C11", "COMMUNITY 11", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2L", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C12", "COMMUNITY 12", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2M", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C13", "COMMUNITY 13", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2N", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C14", "COMMUNITY 14", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2O", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C15", "COMMUNITY 15", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2P", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C16", "COMMUNITY 16", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2Q", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C17", "COMMUNITY 17", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2R", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C18", "COMMUNITY 18", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2S", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C19", "COMMUNITY 19", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2T", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C20", "COMMUNITY 20", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C21", "COMMUNITY 21", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2VV", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C22", "COMMUNITY 22", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C23", "COMMUNITY 23", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AQ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C24", "COMMUNITY 24", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AP", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C25", "COMMUNITY 25", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AR", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C26", "COMMUNITY 26", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2W", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASH", "ASHIAMAN", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AJ", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AK", "AGYEI KODJO", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ZN", "ZENU", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2V", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SAK", "SAKUMONO", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AH", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KLNG", "KLANGON", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2BT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BT", "BETHLEHEM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2TE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TB", "TSUI BLEOO", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AF", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TM", "TEMA MANHEAN", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HI", "H/INDUSTRIAL MKT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AG", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "KPN", "KPONE", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LASH", "LASHIBI", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TC", "TOWN CENTER", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AC", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VC", "VERTICAL CENTER", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AB", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LI", "LIGHT INDUSTRIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2AA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IND", "HEAVY INDUSTRIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HI/CMKT", "KPONE CAR MKT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2UA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UA", "UNKNOWN AREA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2CT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CH", "CHINA TOWN", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2GC", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GC", "GOLF CITY", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MI", "MOTORWAY INDUSTRIAL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2SK", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SK", "SAKI TOWN", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2BM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "BTM", "BORTEYMAN", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2SB", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SBP", "SEBREPOR", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MTK", "MLITSAKPO", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                schema: "est",
                table: "PropertyType",
                columns: new[] { "PropertyTypeId", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "ModifiedBy", "ModifiedOn", "PropertyTypes" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SERVICED PLOT" },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PARTIALLY SERVICED PLOT" },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UNSERVICED PLOT" },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "H.O.S HOUSE" },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SHOPS/OFFICES" },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RENTAL HOUSE" },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "APARTMENTS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllocationType_AllocationTypeInitial_AllocationTypes",
                schema: "est",
                table: "AllocationType",
                columns: new[] { "AllocationTypeInitial", "AllocationTypes" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentTypes_ApartmentType",
                schema: "est",
                table: "ApartmentTypes",
                column: "ApartmentType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandUse_LandUseInitial",
                schema: "est",
                table: "LandUse",
                column: "LandUseInitial",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandUse_LandUseName",
                schema: "est",
                table: "LandUse",
                column: "LandUseName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LandUseType_LandUseTypeInitial_LandUseTypeName",
                schema: "est",
                table: "LandUseType",
                columns: new[] { "LandUseTypeInitial", "LandUseTypeName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locality_LocalityInitial_LocalityName",
                schema: "est",
                table: "Locality",
                columns: new[] { "LocalityInitial", "LocalityName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PropertyType_PropertyTypes",
                schema: "est",
                table: "PropertyType",
                column: "PropertyTypes",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllocationType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "ApartmentTypes",
                schema: "est");

            migrationBuilder.DropTable(
                name: "BlockNumber",
                schema: "est");

            migrationBuilder.DropTable(
                name: "BlockSides",
                schema: "est");

            migrationBuilder.DropTable(
                name: "BlockStatus",
                schema: "est");

            migrationBuilder.DropTable(
                name: "BlockTypes",
                schema: "est");

            migrationBuilder.DropTable(
                name: "BlockUnit",
                schema: "est");

            migrationBuilder.DropTable(
                name: "CustomerType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "Facilities",
                schema: "est");

            migrationBuilder.DropTable(
                name: "FloorNumbering",
                schema: "est");

            migrationBuilder.DropTable(
                name: "Gender",
                schema: "est");

            migrationBuilder.DropTable(
                name: "IdentificationType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "LandUse",
                schema: "est");

            migrationBuilder.DropTable(
                name: "LandUseType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "Locality",
                schema: "est");

            migrationBuilder.DropTable(
                name: "Nationality",
                schema: "est");

            migrationBuilder.DropTable(
                name: "PlotSize",
                schema: "est");

            migrationBuilder.DropTable(
                name: "PropertyHeight",
                schema: "est");

            migrationBuilder.DropTable(
                name: "PropertyType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "ResidentType",
                schema: "est");

            migrationBuilder.DropTable(
                name: "SocialMedia",
                schema: "est");

            migrationBuilder.DropTable(
                name: "Title",
                schema: "est");
        }
    }
}
