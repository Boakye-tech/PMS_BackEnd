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

        PropertyType = new PropertyTypeRepository(_dbContext);

        PlotSize = new PlotSizeRepository(_dbContext);

        CustomerType = new CustomerTypeRepository(_dbContext);

        Gender = new GenderRepository(_dbContext);

        IdentificationType = new IdentificationTypeRepository(_dbContext);

        Nationality = new NationalityRepository(_dbContext);

        ResidentType = new ResidentTypeRepository(_dbContext);

        SocialMedia = new SocialMediaRepository(_dbContext);

        Title = new TitleRepository(_dbContext);

        ApartmentTypes = new ApartmentTypesRepository(_dbContext);

        BlockNumber = new BlockNumberRepository(_dbContext);

        BlockSides = new BlockSidesRepository(_dbContext);

        BlockType = new BlockTypeRepository(_dbContext);

        BlockUnit = new BlockUnitRepository(_dbContext);

        Facilities = new FacilitiesRepository(_dbContext);

        FloorNumbering = new FloorNumberingRepository(_dbContext);

        PropertyHeight = new PropertyHeightRepository(_dbContext);

        CustomerMaster = new CustomerMasterRepository(_dbContext);

        PropertyMaster = new PropertyMasterRepository(_dbContext);

        Activity = new ActivityRepository(_dbContext);
        ActivityType = new ActivityTypeRepository(_dbContext);

    }


    public IAllocationTypeRepository AllocationType { get; private set; }

    public ILandUseRepository LandUse { get; private set; }

    public ILandUseTypeRepository LandUseType { get; private set; }

    public ILocalityRepository Locality { get; private set; }

    public IPropertyTypeRepository PropertyType { get; private set; }

    public IPlotSizeRepository PlotSize { get; private set; }

    public ICustomerTypeRepository CustomerType { get; private set; }

    public IGenderRepository Gender { get; private set; }

    public IIdentificationTypeRepository IdentificationType { get; private set; }

    public INationalityRepository Nationality { get; private set; }

    public IResidentTypeRepository ResidentType { get; private set; }

    public ISocialMediaRepository SocialMedia { get; private set; }

    public ITitleRepository Title { get; private set; }

    public IApartmentTypesRepository ApartmentTypes { get; private set; }

    public IBlockNumberRepository BlockNumber { get; private set; }

    public IBlockSidesRepository BlockSides { get; private set; }

    public IBlockTypeRepository BlockType { get; private set; }

    public IBlockUnitRepository BlockUnit { get; private set; }

    public IFacilitiesRepository Facilities { get; private set; }

    public IFloorNumberingRepository FloorNumbering { get; private set; }

    public IPropertyHeightRepository PropertyHeight { get; private set; }

    public ICustomerMasterRepository CustomerMaster { get; private set; }

    public IPropertyMasterRepository PropertyMaster { get; private set; }

    //jan 2 '25
    public IActivityRepository Activity { get; private set; }
    public IActivityTypeRepository ActivityType { get; private set; }


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

