// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Registration/ViewModels/PropertyMasterView.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/08/2025 12:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Estates.Domain.Entities.Registration.ViewModels
{
    [NotMapped]
    public class PropertyMasterView
    {
        [Key]
        public int PropertyMasterId { get; set; }
        public string? PropertyNumber { get; set; }

        public int? PropertyTypeId { get; set; }
        public string? PropertyTypeName { get; set; }

        public int? LocalityId { get; set; }
        public string? LocalityName { get; set; }

        public int? SiteId { get; set; }
        public string? SiteName { get; set; }

        public int? LandUseId { get; set; }
        public string? LandUseName { get; set; }

        public int? LandUseTypeId { get; set; }
        public string? LandUseTypeName { get; set; }

        public int? AllocationTypeId { get; set; }
        public string? AllocationTypes { get; set; }

        public int? BlockNumberId { get; set; }
        public string? BlockNumbers { get; set; }

        public decimal? PlotAcreage { get; set; }
        public decimal? PlotAcreage2 { get; set; }
        public int? PlotDimensionId { get; set; }
        public string? PlotDimensions { get; set; }

        public int? LeaseTermInYears { get; set; }
        public string? RoomSize { get; set; }

        public int? PropertyStatusId { get; set; }
        public string? PropertyStatusName { get; set; }

        public int? ApartmentCategoryId { get; set; }
        public string? ApartmentCategoryName { get; set; }

        public int? ApartmentTypeId { get; set; }
        public string? ApartmentType { get; set; }

        public int? SchemeTypeId { get; set; }
        public string? SchemeTypeName { get; set; }

        public int? BlockTypeId { get; set; }
        public string? BlockType { get; set; }

        public int? BlockUnitId { get; set; }
        public string? Unit { get; set; }

        public int? BlockSideId { get; set; }
        public string? Side { get; set; }

        public DateTime? CommencementDate { get; set; }
        public DateTime? LeaseExpiryDate { get; set; }

        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }

        public string? CoordinateOne { get; set; }
        public string? CoordinateTwo { get; set; }
        public string? CoordinateThree { get; set; }
        public string? CoordinateFour { get; set; }
        public string? CoordinateFive { get; set; }
        public string? CoordinateSix { get; set; }

        public string[]? Images { get; set; }
        public string? Number { get; set; }

        public int? RentalCategoryId { get; set; }
        public string? RentalCategories { get; set; }

        public int? RentalTypeId { get; set; }
        public string? RentalTypes { get; set; }

        public int? TypeId { get; set; }
        public string? Code { get; set; }
        public string? TypeName { get; set; }

        public string? CadastralPlanNumber { get; set; }
        public string? Comments { get; set; }

        public double? CostPrice { get; set; }
        public int? CurrencyId { get; set; }
        public string? CurrencyInitial { get; set; }
        public string? CurrencyName { get; set; }

        public int? DebtorType { get; set; }

        public int? FloorNumberId { get; set; }
        public int? GroupNumber { get; set; }
        public string? MotherPropertyNumber { get; set; }
        public DateTime? RightOfEntry { get; set; }
        public int? RoomsOccupied { get; set; }

        public double? SellingPrice { get; set; }
        public double? RentalFee { get; set; }
        public string? SitePlanNumber { get; set; }
        public int? TotalNumberOfRooms { get; set; }
        public string? OldPropertyNumber { get; set; }

        public int? PlotTypeId { get; set; }
        public string? PlotTypes { get; set; }

        public int? PropertyHeightId { get; set; }
        public string? PropertyHeights { get; set; }

        public DateTime? DateOfConstruction { get; set; }
        public DateTime? DateOfTenancy { get; set; }
        public DateTime? DateTransferedToHos { get; set; }

        public bool? StopDebit { get; set; }

        //public bool? IsDeleted { get; set; }

        //public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        //public DateTime? ModifiedOn { get; set; }
        //public string? ModifiedBy { get; set; }
        //public DateTime? DeletedOn { get; set; }
        //public string? DeletedBy { get; set; }
        //public DateTime? ApprovedOn { get; set; }
        public string? ApprovedBy { get; set; }

    }

}

