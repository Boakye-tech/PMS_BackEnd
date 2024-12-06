namespace Modules.Estates.Application.Repositories.Setup.Property;

public class AllocationTypeService : IAllocationTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AllocationTypeService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AllocationTypeReadDto> AddAllocationTypeAsync(AllocationTypeCreateDto values)
    {
        AllocationType allocationType = new(values.AllocationTypeId, values.AllocationTypeInitial!, values.AllocationTypes!)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.AllocationType.Insert(allocationType);
        await _unitOfWork.Complete();

        return new AllocationTypeReadDto(allocationType.AllocationTypeId, allocationType.AllocationTypeInitial!, allocationType.AllocationTypes!);
    }

    public async Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync()
    {
        var allocationTypes = await _unitOfWork.AllocationType.GetAll();
        return _mapper.Map<IEnumerable<AllocationTypeReadDto>>(allocationTypes);
    }

    public async Task<AllocationTypeReadDto> GetAllocationTypeAsync(int value)
    {
        var allocationTypes = await _unitOfWork.AllocationType.Get(value);
        return _mapper.Map<AllocationTypeReadDto>(allocationTypes);
    }

    public async Task<AllocationTypeReadDto> GetAllocationTypeAsync(string value)
    {
        var allocationTypes = await _unitOfWork.AllocationType.Get(at => at.AllocationTypeInitial == value || at.AllocationTypes == value);
        return _mapper.Map<AllocationTypeReadDto>(allocationTypes);
    }

    public async Task<AllocationTypeReadDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values)
    {
        AllocationType allocationType = new(values.AllocationTypeId, values.AllocationTypeInitial!, values.AllocationTypes!)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.AllocationType.Update(allocationType);
        await _unitOfWork.Complete();

        return new AllocationTypeReadDto(allocationType.AllocationTypeId, allocationType.AllocationTypeInitial!, allocationType.AllocationTypes!);
    }

}

