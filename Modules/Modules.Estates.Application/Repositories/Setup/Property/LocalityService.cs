namespace Modules.Estates.Application.Repositories.Setup.Property;

public class LocalityService : ILocalityService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LocalityService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<LocalityReadDto> AddLocalityAsync(LocalityCreateDto values)
    {
        Locality locality = new(values.LocalityId, values.LocalityInitial!, values.LocalityName!,values.CustomerCode)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.Locality.Insert(locality);
        await _unitOfWork.Complete();

        return new LocalityReadDto(locality.LocalityId, locality.LocalityInitial!, locality.LocalityName!, locality.CustomerCode!);

    }

    public async Task<IEnumerable<LocalityReadDto>> GetLocalityAsync()
    {
        var localities = await _unitOfWork.Locality.GetAll();
        return _mapper.Map<IEnumerable<LocalityReadDto>>(localities);
    }

    public async Task<LocalityReadDto> GetLocalityAsync(int value)
    {
        var localities = await _unitOfWork.Locality.Get(value);
        return _mapper.Map<LocalityReadDto>(localities);
    }

    public async Task<LocalityReadDto> GetLocalityAsync(string value)
    {
        var localities = await _unitOfWork.Locality.Get(l => l.LocalityInitial == value || l.LocalityName == value);
        return _mapper.Map<LocalityReadDto>(localities);
    }

    public async Task<LocalityReadDto> UpdateLocalityAsync(LocalityUpdateDto values)
    {
        Locality locality = new(values.LocalityId, values.LocalityInitial!, values.LocalityName!, values.CustomerCode)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.Locality.Update(locality);
        await _unitOfWork.Complete();

        return new LocalityReadDto(locality.LocalityId, locality.LocalityInitial!, locality.LocalityName!, locality.CustomerCode!);

    }
}

