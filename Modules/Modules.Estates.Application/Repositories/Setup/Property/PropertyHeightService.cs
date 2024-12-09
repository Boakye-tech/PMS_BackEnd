namespace Modules.Estates.Application.Repositories.Setup.Property;

public class PropertyHeightService: IPropertyHeightService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PropertyHeightService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PropertyHeightReadDto> AddPropertyHeightAsync(PropertyHeightCreateDto values)
    {
        PropertyHeight input_values = new(values.propertyHeightId, values.propertyHeights!)
        {
            CreatedBy = values.createdBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.PropertyHeight.Insert(input_values);
        await _unitOfWork.Complete();

        return new PropertyHeightReadDto(input_values.PropertyHeightId, input_values.PropertyHeights!);
    }

    public async Task<IEnumerable<PropertyHeightReadDto>> GetPropertyHeightAsync()
    {
        var response = await _unitOfWork.PropertyHeight.GetAll();
        return _mapper.Map<IEnumerable<PropertyHeightReadDto>>(response);
    }

    public async Task<PropertyHeightReadDto> GetPropertyHeightAsync(int value)
    {
        var response = await _unitOfWork.PropertyHeight.Get(value);
        return _mapper.Map<PropertyHeightReadDto>(response);
    }

    public async Task<PropertyHeightReadDto> GetPropertyHeightAsync(string value)
    {
        var response = await _unitOfWork.PropertyHeight.Get(ph => ph.PropertyHeights == value);
        return _mapper.Map<PropertyHeightReadDto>(response);
    }

    public async Task<PropertyHeightReadDto> UpdatePropertyHeightAsync(PropertyHeightUpdateDto values)
    {
        PropertyHeight input_values = new(values.propertyHeightId, values.propertyHeights!)
        {
            ModifiedBy = values.modifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.PropertyHeight.Update(input_values);
        await _unitOfWork.Complete();

        return new PropertyHeightReadDto(input_values.PropertyHeightId, input_values.PropertyHeights!);
    }
}

