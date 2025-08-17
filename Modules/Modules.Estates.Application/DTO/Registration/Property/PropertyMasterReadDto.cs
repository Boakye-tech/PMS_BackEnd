// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Registration/Property/PropertyMasterReadDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/08/2025 9:34 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Registration.Property
{
    public record PropertyMasterReadDto(
    int PropertyMasterId,
    string PropertyNumber,
    int? PropertyTypeId,
    string? PropertyTypeName,
    int? LocalityId,
    string? LocalityName,
    int? SiteId,
    string? SiteName,
    int? LandUseId,
    string? LandUseName,
    int? LandUseTypeId,
    string? LandUseTypeName,
    int? AllocationTypeId,
    string? AllocationTypes,
    int? BlockNumberId,
    string? BlockNumbers,
    decimal? PlotAcreage,
    int? LeaseTermInYears,
    string? RoomSize,
    int? PropertyStatusId,
    string? PropertyStatusName,
    int? ApartmentCategoryId,
    string? ApartmentCategoryName,
    int? ApartmentTypeId,
    string? ApartmentType,
    int? SchemeTypeId,
    string? SchemeTypeName,
    int? BlockTypeId,
    string? BlockType,
    int? BlockUnitId,
    string? Unit,
    int? BlockSideId,
    string? Side,
    DateTime? CommencementDate,
    DateTime? LeaseExpiryDate,
    string? CustomerCode,
    string? CustomerName,
    string? CoordinateOne,
    string? CoordinateTwo,
    string? CoordinateThree,
    string? CoordinateFour,
    string? CoordinateFive,
    string? CoordinateSix,
    bool IsDeleted,
    DateTime CreatedOn,
    string? CreatedBy,
    DateTime? ModifiedOn,
    string? ModifiedBy,
    DateTime? DeletedOn,
    string? DeletedBy,
    DateTime? ApprovedOn,
    string? ApprovedBy,
    string[]? Images,
    string? Number,
    int? RentalCategoryId,
    string? RentalCategories,
    int? RentalTypeId,
    string? RentalTypes,
    int? TypeId,
    string? Code,
    string? TypeName,
    string? CadastralPlanNumber,
    string? Comments,
    double? CostPrice,
    int? CurrencyId,
    int? DebtorType,
    int? FloorNumberId,
    int? GroupNumber,
    string? MotherPropertyNumber,
    DateTime? RightOfEntry,
    int? RoomsOccupied,
    double? SellingPrice,
    string? SitePlanNumber,
    int? TotalNumberOfRooms,
    string? OldPropertyNumber,
    int? PlotTypeId,
    string? PlotTypes,
    int? PropertyHeightId,
    string? PropertyHeights,
    DateTime? DateOfConstruction,
    DateTime? DateOfTenancy,
    DateTime? DateTransferedToHos,
    decimal? PlotAcreage2,
    int? PlotDimensionId,
    string? PlotDimensions
);

}

