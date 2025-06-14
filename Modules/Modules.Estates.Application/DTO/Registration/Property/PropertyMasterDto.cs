// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Registration.Property
{
	public record PropertyMasterDto
	{
        [Key]
        public int PropertyMasterId { get; set; }
        [StringLength(25)]
        [Required]
        public string? PropertyNumber { get; set; }
        public int PropertyTypeId { get; set; }
        [Required]
        public int LocalityId { get; set; }
        [Required]
        public int LandUseId { get; set; }
        public int LandUseTypeId { get; set; }
        [Required]
        public int AllocationTypeId { get; set; }
        [StringLength(3)]
        public string? BlockNumber { get; set; }
        [StringLength(3)]
        public string? PlotNumber { get; set; }
        public decimal AcreageOne { get; set; }
        public decimal AcreageTwo { get; set; }
        public int PropertyHeightId { get; set; }
        public int PlotSizeId { get; set; }
        public double SellingPrice { get; set; }
        public int CurrencyId { get; set; }
        [StringLength(50)]
        public string? RentalType { get; set; }
        public int TotalNumberOfRooms { get; set; }
        public int RoomsOccupied { get; set; }
        public int ApartmentTypeId { get; set; }
        public int SchemeTypeId { get; set; }
        public int ApartmentBlockNumberId { get; set; }
        public int BlockTypeId { get; set; }
        public int FloorNumberId { get; set; }
        public int BlockUnitId { get; set; }
        public int BlockSideId { get; set; }
        [StringLength(10)]
        public string? FloorArea { get; set; }
        public int RoomNumber { get; set; }
        public DateTime RightOfEntry { get; set; }
        public int LeaseTerm { get; set; }
        public DateTime LeaseExpiryDate { get; set; }
        public int DebtorType { get; set; }
        public int GroupNumber { get; set; }
        [StringLength(10)]
        public string? CustomerCode { get; set; }
        [StringLength(30)]
        public string? SitePlanNumber { get; set; }
        [StringLength(30)]
        public string? CadastralPlanNumber { get; set; }
        [StringLength(50)]
        public string? CoordinateOne { get; set; }
        [StringLength(50)]
        public string? CoordinateTwo { get; set; }
        [StringLength(50)]
        public string? CoordinateThree { get; set; }
        [StringLength(50)]
        public string? CoordinateFour { get; set; }
        [StringLength(50)]
        public string? CoordinateFive { get; set; }
        [StringLength(50)]
        public string? CoordinateSix { get; set; }
        [StringLength(25)]
        public string? MotherPropertyNumber { get; set; }
        [StringLength(255)]
        public string? Comments { get; set; }
        public bool IsLargeScale { get; set; }
        public bool IsDeleted { get; set; }
    }



    //public record PropertyMasterCreatePlotDto
    //{
    //    [Key]
    //    public int PropertyMasterId { get; set; }

    //    public required int PropertyTypeId { get; set; }
       
    //    public int LocalityId { get; set; }

    //    [StringLength(3)]
    //    public required string LocalityInitial { get; set; }

    //    public required int LandUseId { get; set; }

    //    [StringLength(3)]
    //    public required string LandUseInitial { get; set; }

    //    public required int LandUseTypeId { get; set; }

    //    [StringLength(3)]
    //    public required string LandUseTypeInitial { get; set; }

    //    public required int AllocationTypeId { get; set; }

    //    [StringLength(3)]
    //    public required string AllocationTypeInitial { get; set; }

    //    [StringLength(3)]
    //    public string? BlockNumber { get; set; }

    //    [StringLength(3)]
    //    public required string PlotNumber { get; set; }

    //    public double AcreageOne { get; set; }

    //    public double AcreageTwo { get; set; }

    //    public int PropertyHeightId { get; set; }

    //    public int PlotSizeId { get; set; }

    //    [StringLength(30)]
    //    public string? SitePlanNumber { get; set; }

    //    [StringLength(50)]
    //    public required string CreatedBy { get; set; }
    //}

    public record PropertyMasterUpdateDto
    {
        [Key]
        public int PropertyMasterId { get; set; }
        [StringLength(25)]
        [Required]
        public string? PropertyNumber { get; set; }
    }

    public record PropertyMasterUpdateLeaseDetailsDto
    {
        [Key]
        public int PropertyMasterId { get; set; }
        
        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        public DateTime RightOfEntry { get; set; }

        public int LeaseTerm { get; set; }

        public DateTime LeaseExpiryDate { get; set; }
    }

    public record PropertyMasterDeleteDto { }


    public record AssignPropertyToCustomer
    {
        public string? PropertyNumber { get; set; }
        public string? CustomerCode { get; set; }
        public string? AssignedBy { get; set; }
    }


}

