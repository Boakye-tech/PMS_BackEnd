using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class PropertyDetails
	{

        [Key]
        public int PropertyMasterId { get; set; }

        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        [StringLength(50)]
        public string PropertyType { get; set; }

        [Required]
        [StringLength(50)]
        public string Locality { get; set; }

        [Required]
        [StringLength(50)]
        public string LandUse { get; set; }

        [StringLength(50)]
        public string LandUseType { get; set; }

        [Required]
        [StringLength(50)]
        public string AllocationType { get; set; }

        [StringLength(5)]
        public string? BlockNumber { get; set; }

        [StringLength(5)]
        public string? PlotNumber { get; set; }

        public double AcreageOne { get; set; }

        public double AcreageTwo { get; set; }

        [StringLength(50)]
        public string PropertyHeight { get; set; }

        [StringLength(10)]
        public string PlotSize { get; set; }

        public double SellingPrice { get; set; }

        [StringLength(20)]
        public string Currency { get; set; }

        [StringLength(50)]
        public string? RentalType { get; set; }

        public int TotalNumberOfRooms { get; set; }

        public int RoomsOccupied { get; set; }

        [StringLength(50)]
        public string ApartmentType { get; set; }

        [StringLength(50)]
        public string SchemeType { get; set; }

        [StringLength(5)]
        public string ApartmentBlockNumber { get; set; }

        [StringLength(20)]
        public string BlockType { get; set; }

        [StringLength(20)]
        public string FloorNumber { get; set; }

        [StringLength(5)]
        public string BlockUnit { get; set; }

        [StringLength(5)]
        public string BlockSide { get; set; }

        [StringLength(10)]
        public string? FloorArea { get; set; }

        public int RoomNumber { get; set; }

        public DateTime RightOfEntry { get; set; }

        public int LeaseTerm { get; set; }

        public DateTime LeaseExpiryDate { get; set; }

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

        public bool IsLargeScale { get; set; }


        public PropertyDetails()
		{
		}
	}
}

