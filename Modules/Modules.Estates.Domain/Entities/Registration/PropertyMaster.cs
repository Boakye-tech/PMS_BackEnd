using System;
using Modules.Estates.Domain.Entities.Setup.Property;

//Employ Builder or Factory Pattern.
//This pattern is used because we want to use our domain entity directly to encapsulate the
//necessary logic. E.g. the logic for 1. Generating property numbers and 2. Creating and updating property details

namespace Modules.Estates.Domain.Entities.Registration
{
    public class PropertyMaster : BaseEntity
    {
        [Key]
        public int PropertyMasterId { get; set; }

        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        public int PropertyTypeId { get; set; }

        [Required]
        public int LocalityId { get; set; }

        [Required]
        public int LandUseId { get; set; }

        public int LandUseTypeId { get; set; }

        [Required]
        public int AllocationTypeId { get; set; }

        [StringLength(5)]
        public string? BlockNumber { get; set; }

        [StringLength(5)]
        public string? PlotNumber { get; set; }

        public double AcreageOne { get; set; }

        public double AcreageTwo { get; set; }

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

        public PropertyMaster()
        {
        }

        public PropertyMaster(int propertyTypeId, int landUseId, int landUseTypeId, int localityId, int allocationTypeId, string blockNumber, string plotNumber, double acreageOne, double acreageTwo, int propertyHeightId, int plotSizeId, string sitePlanNumber, bool isLargeScale = false)
        {

        }


        public static PropertyMaster Create(int propertyMasterId, int propertyTypeId, string landUseInitial, int landUseId, string landUseTypeInitial, int landUseTypeId, string localityInitial, int localityId, string allocationTypeInitial, int allocationTypeId, string blockNumber, string plotNumber, double acreageOne, double acreageTwo, int propertyHeightId, int plotSizeId, string sitePlanNumber, bool isLargeScale = false)
        {
            if (string.IsNullOrWhiteSpace(landUseInitial)  || string.IsNullOrWhiteSpace(localityInitial) || string.IsNullOrWhiteSpace(allocationTypeInitial) ||
                string.IsNullOrWhiteSpace(plotNumber) || landUseId <= 0 || landUseTypeId <= 0 || localityId <= 0 || allocationTypeId <= 0) //string.IsNullOrWhiteSpace(blockNumber) || || string.IsNullOrWhiteSpace(landUseTypeInitial)
            {
                throw new ArgumentException("Invalid property registration data.");
            }

            if (landUseId <= 0)
            {
                throw new ArgumentException("Land use id must be greater than zero.");
            }

            if (landUseTypeId <= 0)
            {
                throw new ArgumentException("Land use type id must be greater than zero.");
            }

            if (localityId <= 0)
            {
                throw new ArgumentException("Locality id must be greater than zero.");
            }

            if (allocationTypeId <= 0)
            {
                throw new ArgumentException("Allocation type id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(landUseInitial) || landUseInitial.Length > 3)
            {
                throw new ArgumentException("Land use initial must not be null or exceed 3 characters.");
            }

            //if (string.IsNullOrWhiteSpace(landUseTypeInitial) || landUseTypeInitial.Length > 3)
            //{
            //    throw new ArgumentException("Land use type initial must not be null or exceed 3 characters.");
            //}

            if (string.IsNullOrWhiteSpace(localityInitial) || localityInitial.Length > 3)
            {
                throw new ArgumentException("Locality initial must not be null or exceed 3 characters.");
            }

            if (string.IsNullOrWhiteSpace(allocationTypeInitial) || allocationTypeInitial.Length > 3)
            {
                throw new ArgumentException("Allocation Type Initial must not be null or exceed 3 characters.");
            }

            if (plotNumber == "0") //blockNumber == "0" ||
            {
                throw new ArgumentException("Plot number cannot be 0 zero.");
            }

            string strPropertyNumber = string.Empty;
            string delimiter = "/";

            if (propertyTypeId == 1 || propertyTypeId == 2 || propertyTypeId == 3)
            {
            }


            switch (isLargeScale)
            {
                case false:
                    //check for commercial shops
                    if(landUseInitial == "SHP" && string.IsNullOrWhiteSpace(blockNumber))
                    {
                        strPropertyNumber = string.Concat(landUseTypeInitial, delimiter, localityInitial, delimiter, allocationTypeInitial, delimiter, plotNumber);

                    }

                    if (landUseInitial == "SHP" && !string.IsNullOrWhiteSpace(blockNumber))
                    {
                        strPropertyNumber = string.Concat(landUseTypeInitial, delimiter, localityInitial, delimiter, allocationTypeInitial, delimiter, blockNumber, delimiter, plotNumber);

                    }

                    if (string.IsNullOrWhiteSpace(blockNumber))
                    {
                        strPropertyNumber = string.Concat(landUseInitial, delimiter, localityInitial, delimiter, allocationTypeInitial, delimiter, plotNumber);
                    }
                    if (!string.IsNullOrWhiteSpace(blockNumber))
                    {
                        strPropertyNumber = string.Concat(landUseInitial, delimiter, localityInitial, delimiter, allocationTypeInitial, delimiter,blockNumber,delimiter, plotNumber);
                    }

                    break;

                case true:
                    break;
            }

            return new PropertyMaster
            {
                PropertyMasterId = propertyMasterId,
                PropertyNumber = strPropertyNumber,
                PropertyTypeId = propertyTypeId,
                LocalityId = localityId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                AllocationTypeId = allocationTypeId,
                BlockNumber = blockNumber,
                PlotNumber = plotNumber,
                AcreageOne = acreageOne,
                AcreageTwo = acreageTwo,
                PropertyHeightId = propertyHeightId,
                PlotSizeId = plotSizeId,
                SitePlanNumber = sitePlanNumber,
                IsLargeScale = isLargeScale,
                IsDeleted = false
            };

        }



    }
}

