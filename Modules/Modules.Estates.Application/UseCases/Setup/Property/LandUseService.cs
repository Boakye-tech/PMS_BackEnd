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

public class LandUseService : ILandUseService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LandUseService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<LandUseReadDto> AddLandUseAsync(LandUseCreateDto values)
    {
        LandUse landUse = new(values.LandUseId, values.LandUseInitial!, values.LandUseName!)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.LandUse.Insert(landUse);
        await _unitOfWork.Complete();

        return new LandUseReadDto(landUse.LandUseId, landUse.LandUseInitial!, landUse.LandUseName!);
    }

    public async Task<IEnumerable<LandUseReadDto>> GetLandUseAsync()
    {
        var landuse = await _unitOfWork.LandUse.GetAll();
        return _mapper.Map<IEnumerable<LandUseReadDto>>(landuse);
    }

    public async Task<LandUseReadDto> GetLandUseAsync(int value)
    {
        var landuse = await _unitOfWork.LandUse.Get(value);
        return _mapper.Map<LandUseReadDto>(landuse);
    }

    public async Task<LandUseReadDto> GetLandUseAsync(string value)
    {
        var landuse = await _unitOfWork.LandUse.Get(l => l.LandUseInitial == value || l.LandUseName == value);
        return _mapper.Map<LandUseReadDto>(landuse);
    }

    public async Task<LandUseReadDto> UpdateLandUseAsync(LandUseUpdateDto values)
    {
        LandUse landUse = new(values.LandUseId, values.LandUseInitial!, values.LandUseName!)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.LandUse.Update(landUse);
        await _unitOfWork.Complete();

        return new LandUseReadDto(landUse.LandUseId, landUse.LandUseInitial!, landUse.LandUseName!);

    }


}

