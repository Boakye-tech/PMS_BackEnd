namespace Modules.Estates.Application.Repositories.Setup.Property;

public class LandUseTypeService : ILandUseTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LandUseTypeService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<LandUseTypeReadDto> AddLandUseTypeAsync(LandUseTypeCreateDto values)
    {
        LandUseType landuseType = new(values.LandUseId, values.LandUseTypeId, values.LandUseTypeInitial!, values.LandUseTypeName!)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.LandUseType.Insert(landuseType);
        await _unitOfWork.Complete();

        return new LandUseTypeReadDto(landuseType.LandUseId, landuseType.LandUseTypeId, landuseType.LandUseTypeInitial!, landuseType.LandUseTypeName!);

    }

    public async Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync()
    {
        var landuseType = await _unitOfWork.LandUseType.GetAll();
        return _mapper.Map<IEnumerable<LandUseTypeReadDto>>(landuseType);
    }

    public async Task<LandUseTypeReadDto> GetLandUseTypeAsync(int value)
    {
        var landuseType = await _unitOfWork.LandUseType.Get(value);
        return _mapper.Map<LandUseTypeReadDto>(landuseType);
    }

    public async Task<LandUseTypeReadDto> GetLandUseTypeAsync(string value)
    {
        var landuseType = await _unitOfWork.LandUseType.Get(lt => lt.LandUseTypeInitial == value || lt.LandUseTypeName == value);
        return _mapper.Map<LandUseTypeReadDto>(landuseType);
    }

    public async Task<LandUseTypeReadDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values)
    {
        LandUseType landuseType = new(values.LandUseId, values.LandUseTypeId, values.LandUseTypeInitial!, values.LandUseTypeName!)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.LandUseType.Update(landuseType);
        await _unitOfWork.Complete();

        return new LandUseTypeReadDto(landuseType.LandUseId, landuseType.LandUseTypeId, landuseType.LandUseTypeInitial!, landuseType.LandUseTypeName!);
    }

}

