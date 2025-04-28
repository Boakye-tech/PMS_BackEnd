// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class FacilitiesService: IFacilitiesService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FacilitiesService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<FacilitiesReadDto> AddFacilitiesAsync(FacilitiesCreateDto values)
    {
        Facilities input_values = new(values.facilityId, values.facility!)
        {
            CreatedBy = values.createdBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.Facilities.Insert(input_values);
        await _unitOfWork.Complete();

        return new FacilitiesReadDto(input_values.FacilityId, input_values.Facility!);
    }

    public async Task<IEnumerable<FacilitiesReadDto>> GetFacilitiesAsync()
    {
        var response = await _unitOfWork.Facilities.GetAll();
        return _mapper.Map<IEnumerable<FacilitiesReadDto>>(response);
    }

    public async Task<FacilitiesReadDto> GetFacilitiesAsync(int value)
    {
        var response = await _unitOfWork.Facilities.Get(value);
        return _mapper.Map<FacilitiesReadDto>(response);
    }

    public async Task<FacilitiesReadDto> GetFacilitiesAsync(string value)
    {
        var response = await _unitOfWork.Facilities.Get(f => f.Facility == value);
        return _mapper.Map<FacilitiesReadDto>(response);
    }

    public async Task<FacilitiesReadDto> UpdateFacilitiesAsync(FacilitiesUpdateDto values)
    {
        Facilities input_values = new(values.facilityId, values.facility!)
        {
            ModifiedBy = values.modifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.Facilities.Update(input_values);
        await _unitOfWork.Complete();

        return new FacilitiesReadDto(input_values.FacilityId, input_values.Facility!);
    }
}

