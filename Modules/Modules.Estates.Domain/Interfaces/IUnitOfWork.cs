// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Interfaces/IUnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain;

public interface IUnitOfWork : IDisposable
{
    //----customer
    ICustomerTypeRepository CustomerType { get; }
    IGenderRepository Gender { get; }
    IIdentificationTypeRepository IdentificationType { get; }
    INationalityRepository Nationality { get; }
    IResidentTypeRepository ResidentType { get; }
    ISocialMediaRepository SocialMedia { get; }
    ITitleRepository Title { get; }

    //----property
    IAllocationTypeRepository AllocationType { get; }
    IApartmentTypesRepository ApartmentTypes { get; }
    IApartmentFeaturesRepository ApartmentFeatures { get; }
    IFeaturesRepository Features { get; }
    IBlockNumberRepository BlockNumber { get; }
    IBlockSidesRepository BlockSides { get; }
    IBlockTypeRepository BlockType { get; }
    IBlockUnitRepository BlockUnit { get; }
    IFloorAreaRepository FloorArea { get; }
    IFloorNumberingRepository FloorNumbering { get; }
    ILandUseRepository LandUse { get; }
    ILandUseTypeRepository LandUseType { get; }
    ILocalityRepository Locality { get; }
    IPlotDimensionRepository PlotDimension { get; }
    IPropertyHeightRepository PropertyHeight { get; }
    IPlotTypeRepository PlotType { get; }

    //Jan 1 '25
    ICustomerMasterRepository CustomerMaster { get; }
    IPropertyMasterRepository PropertyMaster { get; }

    //Jan 2 '25
    IActivityRepository Activity { get; }
    IActivityTypeRepository ActivityType { get; }

    IOwnershipTypeRepository OwnershipType { get; }

    //Mar 20 '25
    IStopDebitRepository StopDebit { get; }

    //Mar 26 '25
    IInterestExpressedRepository InterestExpressed { get; }

    //Apr 06 '25
    IComplaintRepository Complaint { get; }
    IComplaintTypeRepository ComplaintType { get; }
    INatureOfComplaintRepository NatureOfComplaint { get; }
    IComplaintStatusesRepository ComplaintStatuses { get; }
    IComplaintHistoryRepository ComplaintHistory { get; }

    //May 15 '25
    ILeaseTypeAndPeriodRepository LeaseTypeAndPeriod { get; }
    IShopOfficeTypesRepository ShopOfficeTypes { get; }
    IPropertyStatusRepository PropertyStatus { get; }

    //May 19 '25
    ICurrencyExchangeRateRepository CurrencyExchangeRate { get; }

    //23 May 2025
    IRentalCategoryRepository RentalCategory  { get;  }
    IRentalTypeRepository RentalType  { get;  }
    IHouseTypesRepository HouseTypes { get;  }

    //June 4, 2025
    ISitesRepository Sites { get; }

    //15 June, 2025
    ITypesRepository Types { get; }
    ISchemeTypeRepository SchemeTypes { get; }

    //16 June, 2025
    IApartmentCategoryRepository ApartmentCategory { get; }

    Task<int> Complete();
}

