// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/DomainServices/IPropertyDomainService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 10:34 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Domain.Interfaces.DomainServices
{
	public interface IPropertyDomainService
	{
        Task<bool> ActivityExists(int activityId);
        Task<bool> ActivityTypeExists(int activityTypeId);

        Task<bool> LocalityExists(int localityId);

        Task<bool> AllocationTypeExists(int allocationTypeId);  
        Task<bool> ApartmentTypesExists(int apartmentTypeId); 
        Task<bool> BlockUnitExists(int blockUnitId); 
        Task<bool> FloorNumberingExists(int floorNumberingId); 
        Task<bool> BlockTypesExists(int blockTypeId); 
        Task<bool> BlockSidesExists(int blockSideId); 
        Task<bool> BlockStatusExists(int blockStatusId); 
        Task<bool> BlockNumberExists(int blockNumberId); 
        //Task<bool> LandUseExists(int landUseId);
        //Task<bool> LandUseExists(string landUse);
        //Task<bool> LandUseInitialExists(string landUseInitial);

        Task<bool> LandUseTypeExists(int landUseTypeId); 
        Task<bool> FloorAreaExists(int floorAreaId); 
        Task<bool> PlotDimensionExists(int plotDimensionId); 
        Task<bool> PropertyHeightExists(int propertyHeightId); 
        Task<bool> PlotTypeExists(int plotTypeId);

        Task<bool> LeaseTypeAndPeriodExists(int leaseTypeId);
        Task<bool> ShopOfficeTypeAndDescriptionExists(int shopOfficeTypeId);
        Task<bool> HouseTypeAndDescriptionExists(int HouseTypeId);
        Task<bool> BlockPurchaseTypeExists(int blockPurchaseTypeId);
        Task<bool> ApartmentFacilitiesExists(int apartmentFacilitiesId);
    }
}

