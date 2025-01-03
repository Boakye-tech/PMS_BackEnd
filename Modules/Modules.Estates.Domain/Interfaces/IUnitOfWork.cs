
using Modules.Estates.Domain.Interfaces.Registration;

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

    Task<int> Complete();
}

