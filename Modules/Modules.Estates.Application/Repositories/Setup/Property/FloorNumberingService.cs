namespace Modules.Estates.Application.Repositories.Setup.Property;

public class FloorNumberingService: IFloorNumberingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FloorNumberingService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<FloorNumberingReadDto> AddFloorNumberingAsync(FloorNumberingCreateDto values)
    {
        FloorNumbering input_values = new(values.floorNumberId, values.floorNumber!)
        {
            CreatedBy = values.createdby,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.FloorNumbering.Insert(input_values);
        await _unitOfWork.Complete();

        return new FloorNumberingReadDto(input_values.FloorNumberId, input_values.FloorNumber!);
    }

    public async Task<IEnumerable<FloorNumberingReadDto>> GetFloorNumberingAsync()
    {
        var response = await _unitOfWork.FloorNumbering.GetAll();
        return _mapper.Map<IEnumerable<FloorNumberingReadDto>>(response);
    }

    public async Task<FloorNumberingReadDto> GetFloorNumberingAsync(int value)
    {
        var response = await _unitOfWork.FloorNumbering.Get(value);
        return _mapper.Map<FloorNumberingReadDto>(response);
    }

    public async Task<FloorNumberingReadDto> GetFloorNumberingAsync(string value)
    {
        var response = await _unitOfWork.FloorNumbering.Get(fn => fn.FloorNumber == value);
        return _mapper.Map<FloorNumberingReadDto>(response);
    }

    public async Task<FloorNumberingReadDto> UpdateFloorNumberingAsync(FloorNumberingUpdateDto values)
    {
        FloorNumbering input_values = new(values.floorNumberId, values.floorNumber!)
        {
            ModifiedBy = values.modified,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.FloorNumbering.Update(input_values);
        await _unitOfWork.Complete();

        return new FloorNumberingReadDto(input_values.FloorNumberId, input_values.FloorNumber!);
    }
}

