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

public class PropertyTypeService: IPropertyTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PropertyTypeService(IUnitOfWork unitOfWork, IMapper mapper)
	{
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<PropertyTypeReadDto> AddPropertyTypeAsync(PropertyTypeCreateDto values)
    {
        PropertyType propertyType = new(values.PropertyTypeId, values.PropertyTypes!)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.PropertyType.Insert(propertyType);
        await _unitOfWork.Complete();

        return new PropertyTypeReadDto(propertyType.PropertyTypeId, propertyType.PropertyTypes!);
    }

    public async Task<IEnumerable<PropertyTypeReadDto>> GetPropertyTypeAsync()
    {
        var propertyType = await _unitOfWork.PropertyType.GetAll();
        return _mapper.Map<IEnumerable<PropertyTypeReadDto>>(propertyType);
    }

    public async Task<PropertyTypeReadDto> GetPropertyTypeAsync(int value)
    {
        var propertyType = await _unitOfWork.PropertyType.Get(value);
        return _mapper.Map<PropertyTypeReadDto>(propertyType);
    }

    public async Task<PropertyTypeReadDto> GetPropertyTypeAsync(string value)
    {
        var propertyType = await _unitOfWork.PropertyType.Get(p => p.PropertyTypes == value);
        return _mapper.Map<PropertyTypeReadDto>(propertyType);
    }

    public async Task<PropertyTypeReadDto> UpdatePropertyTypeAsync(PropertyTypeUpdateDto values)
    {
        //throw new NotImplementedException();
        PropertyType propertyType = new(values.PropertyTypeId, values.PropertyTypes!)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.PropertyType.Update(propertyType);
        await _unitOfWork.Complete();

        return new PropertyTypeReadDto(propertyType.PropertyTypeId, propertyType.PropertyTypes!);
    }


}

