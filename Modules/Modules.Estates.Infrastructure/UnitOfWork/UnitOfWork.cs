// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Infrastructure.UnitOfWork;

public class UnitOfWork: IUnitOfWork
{
    private bool disposedValue;
    private readonly ApplicationDbContext _dbContext;

    public UnitOfWork(ApplicationDbContext dbContext)
	{
        _dbContext = dbContext;

        AllocationType = new AllocationTypeRepository(_dbContext);

        LandUse = new LandUseRepository(_dbContext);

        LandUseType = new LandUseTypeRepository(_dbContext);

        Locality = new LocalityRepository(_dbContext);

        PlotType = new PlotTypeRepository(_dbContext);

        PlotDimension = new PlotDimensionRepository(_dbContext);

        CustomerType = new CustomerTypeRepository(_dbContext);

        Gender = new GenderRepository(_dbContext);

        IdentificationType = new IdentificationTypeRepository(_dbContext);

        Nationality = new NationalityRepository(_dbContext);

        ResidentType = new ResidentTypeRepository(_dbContext);

        SocialMedia = new SocialMediaRepository(_dbContext);

        Title = new TitleRepository(_dbContext);

        ApartmentTypes = new ApartmentTypesRepository(_dbContext);

        ApartmentFeatures = new ApartmentFeaturesRepository(_dbContext);

        Features = new FeaturesRepository(_dbContext);

        BlockNumber = new BlockNumberRepository(_dbContext);

        BlockSides = new BlockSidesRepository(_dbContext);

        BlockType = new BlockTypeRepository(_dbContext);

        BlockUnit = new BlockUnitRepository(_dbContext);

        FloorArea = new FloorAreaRepository(_dbContext);

        FloorNumbering = new FloorNumberingRepository(_dbContext);

        PropertyHeight = new PropertyHeightRepository(_dbContext);

        CustomerMaster = new CustomerMasterRepository(_dbContext);

        PropertyMaster = new PropertyMasterRepository(_dbContext);

        Activity = new ActivityRepository(_dbContext);

        ActivityType = new ActivityTypeRepository(_dbContext);

        OwnershipType = new OwnershipTypeRepository(_dbContext);

        StopDebit = new StopDebitRepository(_dbContext);

        InterestExpressed = new InterestExpressedRepository(_dbContext);

        Complaint = new ComplaintRepository(_dbContext);

        ComplaintType = new ComplaintTypeRepository(_dbContext);

        NatureOfComplaint = new NatureOfComplaintRepository(_dbContext);

        ComplaintStatuses = new ComplaintStatusesRepository(_dbContext);

        ComplaintHistory = new ComplaintHistoryRepository(_dbContext);

        LeaseTypeAndPeriod = new LeaseTypeAndPeriodRepository(_dbContext);

        ShopOfficeTypes = new ShopOfficeTypesRepository(_dbContext);

        PropertyStatus = new PropertyStatusRepository(_dbContext);

        CurrencyExchangeRate = new CurrencyExchangeRateRepository(_dbContext);

        RentalCategory = new RentalCategoryRepository(_dbContext);
        RentalType = new RentalTypeRepository(_dbContext);
        HouseTypes = new HouseTypesRepository(_dbContext);

        Sites = new SitesRepository(_dbContext);

        Types = new TypesRepository(_dbContext);
        SchemeTypes = new SchemeTypeRepository(_dbContext);

        ApartmentCategory = new ApartmentCategoryRepository(_dbContext);

}


public IAllocationTypeRepository AllocationType { get; private set; }

    public ILandUseRepository LandUse { get; private set; }

    public ILandUseTypeRepository LandUseType { get; private set; }

    public ILocalityRepository Locality { get; private set; }

    public IPlotTypeRepository PlotType { get; private set; }

    public IPlotDimensionRepository PlotDimension { get; private set; }

    public ICustomerTypeRepository CustomerType { get; private set; }

    public IGenderRepository Gender { get; private set; }

    public IIdentificationTypeRepository IdentificationType { get; private set; }

    public INationalityRepository Nationality { get; private set; }

    public IResidentTypeRepository ResidentType { get; private set; }

    public ISocialMediaRepository SocialMedia { get; private set; }

    public ITitleRepository Title { get; private set; }

    public IApartmentTypesRepository ApartmentTypes { get; private set; }

    public IApartmentFeaturesRepository ApartmentFeatures { get; private set; }

    public IFeaturesRepository Features { get; private set; }

    public IBlockNumberRepository BlockNumber { get; private set; }

    public IBlockSidesRepository BlockSides { get; private set; }

    public IBlockTypeRepository BlockType { get; private set; }

    public IBlockUnitRepository BlockUnit { get; private set; }

    public IFloorAreaRepository FloorArea { get; private set; }

    public IFloorNumberingRepository FloorNumbering { get; private set; }

    public IPropertyHeightRepository PropertyHeight { get; private set; }

    public ICustomerMasterRepository CustomerMaster { get; private set; }

    public IPropertyMasterRepository PropertyMaster { get; private set; }

    //jan 2 '25
    public IActivityRepository Activity { get; private set; }

    public IActivityTypeRepository ActivityType { get; private set; }

    public IOwnershipTypeRepository OwnershipType { get; private set; }

    //Mar 20 '25
    public IStopDebitRepository StopDebit { get; private set; }

    //Mar 26 '25
    public IInterestExpressedRepository InterestExpressed { get; private set; }

    //Apr 06 '25
    public IComplaintTypeRepository ComplaintType { get; private set; }

    public INatureOfComplaintRepository NatureOfComplaint { get; private set; }

    public IComplaintRepository Complaint { get; private set; }

    public IComplaintStatusesRepository ComplaintStatuses { get; private set; }

    public IComplaintHistoryRepository ComplaintHistory { get; private set; }

    //May 15 '25
    public ILeaseTypeAndPeriodRepository LeaseTypeAndPeriod { get; private set; }
    public IPropertyStatusRepository PropertyStatus { get; private set; }
    public IShopOfficeTypesRepository ShopOfficeTypes { get; private set; }

    public ICurrencyExchangeRateRepository CurrencyExchangeRate { get; private set; }

    public IRentalCategoryRepository RentalCategory { get; private set; }
    public IRentalTypeRepository RentalType { get; private set; }
    public IHouseTypesRepository HouseTypes { get; private set; }

    //June 4 '25
    public ISitesRepository Sites { get; private set; }

    //June 15 '25
    public ITypesRepository Types { get; private set; }
    public ISchemeTypeRepository SchemeTypes { get; private set; }

    //June 16 25
    public IApartmentCategoryRepository ApartmentCategory { get; private set; }

    public Task<int> Complete()
    {
        return _dbContext.SaveChangesAsync();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                _dbContext.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

