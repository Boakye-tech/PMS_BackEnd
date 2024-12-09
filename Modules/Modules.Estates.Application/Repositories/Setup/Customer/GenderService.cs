namespace Modules.Estates.Application.Repositories.Setup.Customer;

public class GenderService : IGenderService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GenderService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<GenderReadDto> AddGenderAsync(GenderCreateDto values)
    {
        Gender gender = new(values.genderId, values.genderType!)
        {
            CreatedBy = values.createdBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.Gender.Insert(gender);
        await _unitOfWork.Complete();

        return new GenderReadDto(gender.GenderId, gender.GenderType!);
    }

    public async Task<IEnumerable<GenderReadDto>> GetGenderAsync()
    {
        var response = await _unitOfWork.Gender.GetAll();
        return _mapper.Map<IEnumerable<GenderReadDto>>(response);
    }

    public async Task<GenderReadDto> GetGenderAsync(int value)
    {
        var response = await _unitOfWork.Gender.Get(value);
        return _mapper.Map<GenderReadDto>(response);
    }

    public async Task<GenderReadDto> GetGenderAsync(string value)
    {
        var response = await _unitOfWork.Gender.Get(g => g.GenderType == value);
        return _mapper.Map<GenderReadDto>(response);
    }

    public async Task<GenderReadDto> UpdateGenderAsync(GenderUpdateDto values)
    {
        Gender gender = new(values.genderId, values.genderType!)
        {
            ModifiedBy = values.modifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.Gender.Update(gender);
        await _unitOfWork.Complete();

        return new GenderReadDto(gender.GenderId, gender.GenderType!);
    }
}

