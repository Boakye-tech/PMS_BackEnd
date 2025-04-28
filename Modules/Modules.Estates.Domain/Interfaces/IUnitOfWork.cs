// /**************************************************
// * Company: MindSprings Company Limited
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
    IBlockNumberRepository BlockNumber { get; }
    IBlockSidesRepository BlockSides { get; }
    IBlockTypeRepository BlockType { get; }
    IBlockUnitRepository BlockUnit { get; }
    IFacilitiesRepository Facilities { get; }
    IFloorNumberingRepository FloorNumbering { get; }
    ILandUseRepository LandUse { get; }
    ILandUseTypeRepository LandUseType { get; }
    ILocalityRepository Locality { get; }
    IPlotSizeRepository PlotSize { get; }
    IPropertyHeightRepository PropertyHeight { get; }
    IPropertyTypeRepository PropertyType { get; }

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

    Task<int> Complete();
}

