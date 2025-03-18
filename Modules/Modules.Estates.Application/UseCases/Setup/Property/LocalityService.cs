namespace Modules.Estates.Application.UseCases.Setup.Property;

public class LocalityService : ILocalityService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LocalityService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<LocalityReadDto> CreateLocalityAsync(LocalityCreateDto values)
    {
        Locality locality = new(values.LocalityId, values.LocalityInitial!, values.LocalityName!,values.CustomerCode, values.CustomerCodeCounter)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.Locality.Insert(locality);
        await _unitOfWork.Complete();

        return new LocalityReadDto(locality.LocalityId, locality.LocalityInitial!, locality.LocalityName!, locality.CustomerCode!, locality.CustomerCodeCounter);

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
        Locality locality = new(values.LocalityId, values.LocalityInitial!, values.LocalityName!, values.CustomerCode, values.CustomerCodeCounter)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.Locality.Update(locality);
        await _unitOfWork.Complete();

        return new LocalityReadDto(locality.LocalityId, locality.LocalityInitial!, locality.LocalityName!, locality.CustomerCode!, locality.CustomerCodeCounter);

    }

    public async Task<string> DeleteLocality(int localityId)
    {
        var locality = await _unitOfWork.Locality.Get(localityId);
        _unitOfWork.Locality.Delete(locality!);
        return "success";
    }

}

