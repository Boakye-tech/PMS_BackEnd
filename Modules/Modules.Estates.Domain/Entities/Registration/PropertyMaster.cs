using System;
namespace Modules.Estates.Domain.Entities.Registration
{
	public class PropertyMaster
	{
		public int PropertyMasterId { get; set; }
        public string PropertyNumber { get; set; }
        public int PropertyTypeId { get; set; }
        public int LocalityId { get; set; }
        public int LandUseId { get; set; }
        public int LandUseTypeId { get; set; }
        public int AllocationTypeId { get; set; }
        public string BlockNumber { get; set; }
        public string PlotNumber { get; set; }
        public decimal AcreageOne { get; set; }
        public decimal AcreageTwo { get; set; }
        public int PropertyHeightId { get; set; }
        public int PlotSizeId { get; set; }
        public double SellingPrice { get; set; }
        public int CurrencyId { get; set; }
        public string RentalType { get; set; }
        public int TotalNumberOfRooms { get; set; }
        public int RoomsOccupied { get; set; }
        public int ApartmentTypeId { get; set; }
        public int SchemeTypeId { get; set; }
        public int BlockNumberId { get; set; }
        public int BlockTypeId { get; set; }
        public int FloorNumberId { get; set; }
        public int BlockUnitId { get; set; }
        public int BlockSideId { get; set; }
        public string FloorArea { get; set; }
        public int RoomNumber { get; set; }
        public DateTime RightOfEntry { get; set; }
        public int LeaseTerm { get; set; }
        public DateTime LeaseExpiryDate { get; set; }
        public int DebtorType { get; set; }
        public int GroupNumber { get; set; }
        public string CustomerCode { get; set; }
        public string SitePlanNumber { get; set; }
        public string CadastralPlanNumber { get; set; }
        public string CoordinateOne { get; set; }
        public string CoordinateTwo { get; set; }
        public string CoordinateThree { get; set; }
        public string CoordinateFour { get; set; }
        public string CoordinateFive { get; set; }
        public string CoordinateSix { get; set; }
        public string MotherPropertyNumber { get; set; }
        public string Comments { get; set; }
        public bool IsLargeScale { get; set; }
        public bool IsDeleted { get; set; }

        public PropertyMaster()
		{
		}
	}
}

