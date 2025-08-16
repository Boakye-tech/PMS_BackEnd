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

using System.ComponentModel.DataAnnotations.Schema;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Domain.Entities.Registration
{
    public class PropertyMaster : BaseEntity
    {
        private readonly List<DomainEvent> _domainEvents = new();

        [NotMapped]
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        [Key]
        public int PropertyMasterId { get; private set; }

        public PropertyNumber? PropertyNumber { get; private set; } = default;

        public int PropertyTypeId { get; private set; }

        public int LocalityId { get; private set; }

        public int SiteId { get; private set; }

        public int LandUseId { get; private set; }

        public int LandUseTypeId { get; private set; }

        public int AllocationTypeId { get; private set; }

        public int PlotTypeId { get; private set; }

        public PlotSize? PlotSize { get; private set; }

        public int SchemeTypeId { get; private set; }

        public int ApartmentCategoryId { get; private set; }

        public int ApartmentTypeId { get; private set; }

        public int BlockTypeId { get; private set; }

        public int BlockSideId { get; private set; }

        public int BlockUnitId { get; private set; }

        public int BlockNumberId { get; private set; }

        [StringLength(5)]
        public string? Number { get; private set; } //(string? PlotNumber and or string RoomNumber)

        public PropertyCoordinates? Coordinates { get; private set; }

        public LeasePeriod? Lease { get; private set; }

        public int PropertyStatusId { get; private set; }

        public string[]? Images { get; private set; }

        public string? CustomerCode { get; private set; }

        // Navigation property for CustomerMaster
        //public virtual CustomerMaster? CustomerMaster { get; private set; }

        public double CostPrice { get; private set; }

        public double SellingPrice { get; private set; }

        public int CurrencyId { get; private set; }

        public int RentalCategoryId { get; private set; }

        public int RentalTypeId { get; private set; }

        public int TypeId { get; private set; }

        public int TotalNumberOfRooms { get; private set; }

        public int RoomsOccupied { get; private set; }

        public string? RoomSize { get; private set; }

        public int PropertyHeightId { get; private set; }

        public int FloorNumberId { get; private set; }

        public DateTime RightOfEntry { get; private set; }

        public DateTime DateOfTenancy { get; private set; }

        public DateTime DateOfConstruction { get; private set; }

        public DateTime DateTransferedToHos { get; private set; }

        public int DebtorType { get; private set; }

        public int GroupNumber { get; private set; }

        [StringLength(75)]
        public string? MotherPropertyNumber { get; private set; }

        public string? Comments { get; private set; }

        [StringLength(30)]
        public string? SitePlanNumber { get; private set; }

        [StringLength(30)]
        public string? CadastralPlanNumber { get; private set; }

        [StringLength(75)]
        public string? OldPropertyNumber { get; private set; }

        public bool IsDeleted { get; private set; }


        // For EF Core
        private PropertyMaster() { }

        public static Result<PropertyMaster> Create(int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial,
            int allocationTypeId,
            string allocationTypeInitial,
            string blockNumber,
            int NumberFrom,
            int NumberTo,
            int plotDimensionId,
            string plotDimension,
            PropertyCoordinates coordinates, bool isApartment = false, string blockUnit = null!)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                NumberFrom.ToString(),
                isApartment,
                blockUnit);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);

            var plotSizeResult = PlotSize.Create(plotDimensionId,plotDimension);
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
                //IsLargeScale = isLargeScale,
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }


        public static Result<PropertyMaster> CreateApartment(int schemeTypeId, string schemeType, int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial,
                                                             int siteId,int allocationTypeId,string allocationTypeInitial,int apartmentCategoryId,int apartmentTypeId,int blockTypeId,int blockSideId,int blockUnitId,
                                                             string blockUnit,int blockNumberId,string blockNumber,int floorNumberId,string roomNumber, PropertyCoordinates coordinates,
                                                             int propertyStatusId,List<string> images, bool isApartment = true)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                roomNumber,
                isApartment,
                blockUnit);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);


            if (schemeType != landUseTypeInitial)
                return Result<PropertyMaster>.Failure("The scheme type does not correspond to the land use type.");

            // Create the entity
            var property = new PropertyMaster
            {
                PropertyNumber = propertyNumberResult.Value,

                SchemeTypeId = schemeTypeId,
                PropertyTypeId = propertyTypeId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                LocalityId = localityId,
                SiteId = siteId,
                AllocationTypeId = allocationTypeId,
                ApartmentCategoryId = apartmentCategoryId,
                ApartmentTypeId = apartmentTypeId,
                BlockNumberId = blockNumberId,
                Number = roomNumber,
                BlockTypeId = blockTypeId,
                BlockSideId = blockSideId,
                BlockUnitId = blockUnitId,
                FloorNumberId = floorNumberId,
                Coordinates = coordinates,
                PropertyStatusId = propertyStatusId,
                Images = images.ToArray(),
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }


        public static Result<PropertyMaster> CreatePlot(int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial,int siteId,
                                                        int allocationTypeId,string allocationTypeInitial,int blockNumberId, string blockNumber,string plotNumber,
                                                        int plotDimensionId,string plotDimension,int plotTypeId,int propertyHeightId,PropertyCoordinates coordinates,
                                                        string sitePlanNumber,string cadastalPlanNumber,int propertyStatusId,List<string> images,bool isApartment = false)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                plotNumber,
                isApartment,
                null!);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);

            var plotSizeResult = PlotSize.Create(plotDimensionId,plotDimension);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            // Create the entity
            var property = new PropertyMaster
            {
                PropertyNumber = propertyNumberResult.Value,
                PropertyTypeId = propertyTypeId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                LocalityId = localityId,
                SiteId = siteId,
                AllocationTypeId = allocationTypeId,
                BlockNumberId = blockNumberId,
                Number = plotNumber,
                PlotSize = plotSizeResult.Value,
                PlotTypeId = plotTypeId,
                PropertyHeightId = propertyHeightId,
                Coordinates = coordinates,
                SitePlanNumber = sitePlanNumber,
                CadastralPlanNumber = cadastalPlanNumber,
                Images = images.ToArray(),
                PropertyStatusId = propertyStatusId,
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }

        public static Result<PropertyMaster> CreateShopsOffices(int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial, int siteId,
                                                int allocationTypeId, string allocationTypeInitial, int blockNumberId, string blockNumber, string shopofficeNumber,
                                                int rentalCategoryId, int rentalTypeId,int shopOfficeTypeId, PropertyCoordinates coordinates,
                                                int propertyStatusId, List<string> images, bool isApartment = false)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                shopofficeNumber,
                isApartment,
                null!);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);

           

            // Create the entity
            var property = new PropertyMaster
            {
                PropertyNumber = propertyNumberResult.Value,
                PropertyTypeId = propertyTypeId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                LocalityId = localityId,
                SiteId = siteId,
                AllocationTypeId = allocationTypeId,
                BlockNumberId = blockNumberId,
                Number = shopofficeNumber,
                RentalCategoryId = rentalCategoryId,
                RentalTypeId = rentalTypeId,
                TypeId = shopOfficeTypeId,
                Coordinates = coordinates,
                Images = images.ToArray(),
                PropertyStatusId = propertyStatusId,
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }

        public static Result<PropertyMaster> CreateHouses(int propertyTypeId, int SchemeTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial, int siteId,
                                                          int allocationTypeId, string allocationTypeInitial, int blockNumberId, string blockNumber, string houseNumber, int houseCategoryId, int houseCategoryTypeId,
                                                          int houseTypeId, int plotDimensionId, string plotDimension, int plotTypeId, PropertyCoordinates coordinates,int propertyStatusId, List<string> images, bool isApartment = false)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                houseNumber,
                isApartment,
                null!);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);

            var plotSizeResult = PlotSize.Create(plotDimensionId, plotDimension);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);


            // Create the entity
            var property = new PropertyMaster
            {
                PropertyNumber = propertyNumberResult.Value,
                PropertyTypeId = propertyTypeId,
                SchemeTypeId = SchemeTypeId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                LocalityId = localityId,
                SiteId = siteId,
                AllocationTypeId = allocationTypeId,
                BlockNumberId = blockNumberId,
                Number = houseNumber,
                RentalCategoryId = houseCategoryId,
                RentalTypeId = houseCategoryTypeId,
                TypeId = houseTypeId,
                PlotSize = plotSizeResult.Value,
                PlotTypeId = plotTypeId,
                Coordinates = coordinates,
                Images = images.ToArray(),
                PropertyStatusId = propertyStatusId,
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }


        public static Result<PropertyMaster> CreateRentalHouses(int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial, int siteId,
                                                                int allocationTypeId, string allocationTypeInitial, int blockNumberId, string blockNumber, string houseNumber, int houseCategoryId,
                                                                int houseCategoryTypeId, int houseTypeId,  PropertyCoordinates coordinates, int propertyStatusId, List<string> images, bool isApartment = false)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                houseNumber,
                isApartment,
                null!);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);


            // Create the entity
            var property = new PropertyMaster
            {
                PropertyNumber = propertyNumberResult.Value,
                PropertyTypeId = propertyTypeId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                LocalityId = localityId,
                SiteId = siteId,
                AllocationTypeId = allocationTypeId,
                BlockNumberId = blockNumberId,
                Number = houseNumber,
                RentalCategoryId = houseCategoryId,
                RentalTypeId = houseCategoryTypeId,
                TypeId = houseTypeId,
                Coordinates = coordinates,
                Images = images.ToArray(),
                PropertyStatusId = propertyStatusId,
                IsDeleted = false
            };

            return Result<PropertyMaster>.Success(property);
        }

        public static Result<PropertyMaster> CreateLargeScale(string motherPropertyNumber, int propertyTypeId, int landUseId, string landUseInitial, int landUseTypeId, string landUseTypeInitial, int localityId, string localityInitial, int siteId,
                                                int allocationTypeId, string allocationTypeInitial, int blockNumberId, string blockNumber, string plotNumber,
                                                int plotDimensionId, string plotDimension, int plotTypeId, int propertyHeightId, PropertyCoordinates coordinates,
                                                string sitePlanNumber, string cadastalPlanNumber, int propertyStatusId, List<string> images, bool isApartment = false)
        {
            // Create value objects
            var propertyNumberResult = PropertyNumber.Create(
                landUseInitial,
                landUseTypeInitial,
                localityInitial,
                allocationTypeInitial,
                blockNumber,
                plotNumber,
                isApartment,
                null!);

            if (!propertyNumberResult.IsSuccess)
                return Result<PropertyMaster>.Failure(propertyNumberResult.Error);

            var plotSizeResult = PlotSize.Create(plotDimensionId, plotDimension);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            // Create the entity
            var property = new PropertyMaster
            {
                PropertyNumber = propertyNumberResult.Value,
                PropertyTypeId = propertyTypeId,
                LandUseId = landUseId,
                LandUseTypeId = landUseTypeId,
                LocalityId = localityId,
                SiteId = siteId,
                AllocationTypeId = allocationTypeId,
                BlockNumberId = blockNumberId,
                Number = plotNumber,
                PlotSize = plotSizeResult.Value,
                PlotTypeId = plotTypeId,
                PropertyHeightId = propertyHeightId,
                Coordinates = coordinates,
                SitePlanNumber = sitePlanNumber,
                CadastralPlanNumber = cadastalPlanNumber,
                Images = images.ToArray(),
                PropertyStatusId = propertyStatusId,
                IsDeleted = false,
                MotherPropertyNumber = motherPropertyNumber
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


        public Result<PropertyMaster> StopDebit()
        {
            if (GroupNumber == 90)
                return Result<PropertyMaster>.Failure("Property already has a stop debit.");

            GroupNumber = 90;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> StartDebit(int groupNumber)
        {
            if (GroupNumber != 90)
                return Result<PropertyMaster>.Failure("Property doesnt have a stop debit.");

            GroupNumber = groupNumber;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> MarkAsDeleted()
        {
            if (IsDeleted)
                return Result<PropertyMaster>.Failure("Property is already deleted");

            IsDeleted = true;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> AssignToCustomer(string customerCode)
        {
            if (string.IsNullOrWhiteSpace(customerCode))
                return Result<PropertyMaster>.Failure("Customer code cannot be null or empty.");

            CustomerCode = customerCode;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> UpdatePlotSize(int plotDimensionId, string newDimension)
        {
            var plotSizeResult = PlotSize.Create(plotDimensionId,newDimension);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            PlotSize = plotSizeResult.Value;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> UpdateAcreage(int plotDimensionId, decimal acreage)
        {
            var plotSizeResult = PlotSize.UpdateAcreage(plotDimensionId, acreage);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            PlotSize = plotSizeResult.Value;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> AddAcreageTwo(int plotDimensionId, decimal acreage1, decimal acreage2)
        {
            var plotSizeResult = PlotSize.AddSecondAcreage(plotDimensionId, acreage1, acreage2);
            if (!plotSizeResult.IsSuccess)
                return Result<PropertyMaster>.Failure(plotSizeResult.Error);

            PlotSize = plotSizeResult.Value;
            return Result<PropertyMaster>.Success(this);
        }

        public Result<PropertyMaster> UpdateDebtorTypeAndGroupNumber(int debtorType, int groupNumber)
        {
            if (debtorType <= 0)
                return Result<PropertyMaster>.Failure("");

            if (debtorType <= 0)
                return Result<PropertyMaster>.Failure("");

            DebtorType = debtorType;
            GroupNumber = groupNumber;

            return Result<PropertyMaster>.Success(this);
        }



    }
}

