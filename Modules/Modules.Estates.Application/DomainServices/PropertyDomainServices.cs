// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DomainServices/PropertyDomainServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 10:32 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DomainServices
{
	public class PropertyDomainServices : IPropertyDomainService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PropertyDomainServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //public async Task<bool> ActivityExists(int activityId)
        //{
        //    var result = await _unitOfWork.Activity.Get(activityId);
        //    if (result is null)
        //    {
        //        return false;
        //    }

        //    return true;

        //}

        public async Task<bool> ActivityExists(int activityId)
        {
            return await _unitOfWork.Activity.Get(activityId) is not null;
        }

        public async Task<bool> ActivityTypeExists(int activityTypeId)
        {
            return await _unitOfWork.ActivityType.Get(activityTypeId) is not null;
        }

        public async Task<bool> AllocationTypeExists(int allocationTypeId)
        {
            return await _unitOfWork.AllocationType.Get(allocationTypeId) is not null;
        }

        public Task<bool> ApartmentFacilitiesExists(int apartmentFacilitiesId)
        {
            throw new NotImplementedException();
            //return await _unitOfWork.ApartmentFa.Get(apartmentFacilitiesId) is not null;
        }


        public async Task<bool> ApartmentTypesExists(int apartmentTypeId)
        {
            return await _unitOfWork.ApartmentTypes.Get(apartmentTypeId) is not null;
        }

        public async Task<bool> BlockNumberExists(int blockNumberId)
        {
            return await _unitOfWork.BlockNumber.Get(blockNumberId) is not null;
        }

        public Task<bool> BlockPurchaseTypeExists(int blockPurchaseTypeId)
        {
            throw new NotImplementedException();
          //return await _unitOfWork.Block.Get(blockPurchaseTypeId) is not null;
        }

        public async Task<bool> BlockSidesExists(int blockSideId)
        {
            return await _unitOfWork.BlockSides.Get(blockSideId) is not null;
        }

        public Task<bool> BlockStatusExists(int blockStatusId)
        {
            throw new NotImplementedException();
            //return await _unitOfWork.Block.Get() is not null;
        }

        public async Task<bool> BlockTypesExists(int blockTypeId)
        {
            return await _unitOfWork.BlockType.Get(blockTypeId) is not null;
        }

        public async Task<bool> BlockUnitExists(int blockUnitId)
        {
            return await _unitOfWork.BlockUnit.Get(blockUnitId) is not null;
        }

        public async Task<bool> FloorAreaExists(int floorAreaId)
        {
            return await _unitOfWork.FloorArea.Get(floorAreaId) is not null;
        }

        public async Task<bool> FloorNumberingExists(int floorNumberingId)
        {
            return await _unitOfWork.FloorNumbering.Get(floorNumberingId) is not null;
        }

        public Task<bool> HouseTypeAndDescriptionExists(int HouseTypeId)
        {
            throw new NotImplementedException();
            //return await _unitOfWork..Get(HouseTypeId) is not null;
        }

        public async Task<bool> LandUseExists(int landUseId)
        {
            return await _unitOfWork.LandUse.Get(landUseId) is not null;
        }

        public async Task<bool> LandUseInitialExists(string landUseInitial)
        {
            return await _unitOfWork.LandUse.Get(l => l.LandUseInitial == landUseInitial) is not null;
        }

        public async Task<bool> LandUseExists(string landUse)
        {
            return await _unitOfWork.LandUse.Get(l => l.LandUseName == landUse) is not null;
        }

        public async Task<bool> LandUseTypeExists(int landUseTypeId)
        {
            return await _unitOfWork.LandUseType.Get(landUseTypeId) is not null;
        }

        public Task<bool> LeaseTypeAndPeriodExists(int leaseTypeId)
        {
            throw new NotImplementedException();
            //return await _unitOfWork..Get(leaseTypeId) is not null;
        }

        public async Task<bool> LocalityExists(int localityId)
        {
            return await _unitOfWork.Locality.Get(localityId) is not null;
        }

        public async Task<bool> PlotDimensionExists(int plotDimensionId)
        {
            return await _unitOfWork.PlotDimension.Get(plotDimensionId) is not null;
        }

        public async Task<bool> PropertyHeightExists(int propertyHeightId)
        {
            return await _unitOfWork.PropertyHeight.Get(propertyHeightId) is not null;
        }

        public async Task<bool> PlotTypeExists(int plotTypeId)
        {
            return await _unitOfWork.PlotType.Get(plotTypeId) is not null;
        }

        public Task<bool> ShopOfficeTypeAndDescriptionExists(int shopOfficeTypeId)
        {
            throw new NotImplementedException();
            //return await _unitOfWork.Shops.Get(shopOfficeTypeId) is not null;
        }

    }
}

