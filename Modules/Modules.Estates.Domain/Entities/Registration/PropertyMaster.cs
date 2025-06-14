// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



//Employ Builder or Factory Pattern.
//This pattern is used because we want to use our domain entity directly to encapsulate the
//necessary logic. E.g. the logic for 1. Generating property numbers and 2. Creating and updating property details

using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Domain.Entities.Registration
{
    public class PropertyMaster : BaseEntity
    {
        [Key]
        public int PropertyMasterId { get; private set; }
        public int PropertyTypeId { get; private set; }
        public PropertyNumber PropertyNumber { get; private set; }
        public int LocalityId { get; private set; }
        public int SiteId { get; private set; }
        public int LandUseId { get; private set; }
        public int LandUseTypeId { get; private set; }
        public int AllocationTypeId { get; private set; }
        public PlotSize PlotSize { get; private set; }
        public int SchemeTypeId { get; private set; }
        public int ApartmentTypeId { get; private set; }
        public int BlockTypeId { get; private set; }
        public int BlockSideId { get; private set; }
        public int BlockUnitId { get; private set; }

        [StringLength(5)]
        public string BlockNumber { get; private set; }

        [StringLength(5)]
        public string PlotNumber { get; set; }

        public int RoomNumber { get; private set; }
        public PropertyCoordinates Coordinates { get; private set; }
        public LeasePeriod Lease { get; private set; }
        public int PropertyStatusId { get; private set; }
        public List<string> Images { get; private set; }
        public bool IsLargeScale { get; private set; }
        public string CustomerCode { get; set; }
        public bool IsDeleted { get; private set; }

        public double CostPrice { get; set; }
        public double SellingPrice { get; set; }
        public int CurrencyId { get; set; }

        [StringLength(50)]
        public string? RentalType { get; set; }
        public int TotalNumberOfRooms { get; set; }
        public int RoomsOccupied { get; set; }

        public int ApartmentBlockNumberId { get; set; }
        public int FloorNumberId { get; set; }

        [StringLength(10)]
        public string? FloorArea { get; set; }

        public DateTime RightOfEntry { get; set; }

        public int DebtorType { get; set; }

        public int GroupNumber { get; set; }

        [StringLength(25)]
        public string? MotherPropertyNumber { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

        [StringLength(30)]
        public string? SitePlanNumber { get; set; }

        [StringLength(30)]
        public string? CadastralPlanNumber { get; set; }





        // For EF Core
        private PropertyMaster() { }

        public static Result<PropertyMaster> Create(int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial,
            int allocationTypeId,
            string allocationTypeInitial,
            string blockNumber,
            int NumberFrom,
            int NumberTo,
            double plotDimension,
            PropertyCoordinates coordinates, bool isApartment = false, string blockUnit = null, bool isLargeScale = false)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                NumberFrom,
                NumberTo,
                isApartment,
                blockUnit);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);

            var plotSizeResult = PlotSize.Create(plotDimension);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            //var leaseResult = LeasePeriod.Create(leaseCommencementDate, leaseTerm);
            //if (!leaseResult.IsSuccess)
            //    return Result<PropertyMaster>.Failure(leaseResult.Error);

            // Create the entity
            var property = new PropertyMaster
            {
                PropertyTypeId = propertyTypeId,
                LocalityId = localityId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                AllocationTypeId = allocationTypeId,
                PropertyNumber = propertyNumberResult.Value,
                PlotSize = plotSizeResult.Value,
                Coordinates = coordinates,
                //Lease = leaseResult.Value,
                IsLargeScale = isLargeScale,
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }

        // Domain methods
        public Result<PropertyMaster> UpdateLease(DateTime newCommencementDate, int newTerm)
        {
            var leaseResult = LeasePeriod.Create(newCommencementDate, newTerm);
            if (!leaseResult.IsSuccess)
                return Result<PropertyMaster>.Failure(leaseResult.Error);

            Lease = leaseResult.Value;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> MarkAsDeleted()
        {
            if (IsDeleted)
                return Result<PropertyMaster>.Failure("Property is already deleted");

            IsDeleted = true;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> UpdatePlotSize(double newDimension)
        {
            var plotSizeResult = PlotSize.Create(newDimension);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            PlotSize = plotSizeResult.Value;
            return Result<PropertyMaster>.Success(this);
        }
    }
}

