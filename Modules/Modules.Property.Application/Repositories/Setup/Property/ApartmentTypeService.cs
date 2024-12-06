namespace Modules.Estates.Application.Repositories.Setup.Property;

public class ApartmentTypeService: IApartmentTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ApartmentTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ApartmentTypeReadDto> AddApartmentTypeAsync(ApartmentTypeCreateDto values)
    {
        ApartmentTypes input_values = new(values.apartmentTypeId, values.apartmentType!, values.sellingPrice, values.currencyId, values.floorArea)
        {
            CreatedBy = values.createdBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.ApartmentTypes.Insert(input_values);
        await _unitOfWork.Complete();

        return new ApartmentTypeReadDto(input_values.ApartmentTypeId, input_values.ApartmentType!, input_values.SellingPrice, input_values.CurrencyId, input_values.FloorArea);
    }

    public async Task<IEnumerable<ApartmentTypeReadDto>> GetApartmentTypeAsync()
    {
        var response = await _unitOfWork.ApartmentTypes.GetAll();
        return _mapper.Map<IEnumerable<ApartmentTypeReadDto>>(response);
    }

    public async Task<ApartmentTypeReadDto> GetApartmentTypeAsync(int value)
    {
        var response = await _unitOfWork.ApartmentTypes.Get(value);
        return _mapper.Map<ApartmentTypeReadDto>(response);
    }

    public async Task<ApartmentTypeReadDto> GetApartmentTypeAsync(string value)
    {
        var response = await _unitOfWork.ApartmentTypes.Get(at => at.ApartmentType == value);
        return _mapper.Map<ApartmentTypeReadDto>(response);
    }

    public async Task<ApartmentTypeReadDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values)
    {
        ApartmentTypes input_values = new(values.apartmentTypeId, values.apartmentType!, values.sellingPrice, values.currencyId, values.floorArea)
        {
            ModifiedBy = values.modifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.ApartmentTypes.Update(input_values);
        await _unitOfWork.Complete();

        return new ApartmentTypeReadDto(input_values.ApartmentTypeId, input_values.ApartmentType!, input_values.SellingPrice, input_values.CurrencyId, input_values.FloorArea);
    }
}

