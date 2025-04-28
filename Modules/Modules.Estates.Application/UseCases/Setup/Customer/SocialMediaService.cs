// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Setup.Customer;

public class SocialMediaService: ISocialMediaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public SocialMediaService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<SocialMediaReadDto> AddSocialMediaAsync(SocialMediaCreateDto values)
    {
        SocialMedia request = new(values.SocialMediaId, values.SocialMediaPlatform!)
        {
            CreatedBy = values.CreatedBy,
            CreatedOn = DateTime.Now
        };

        _unitOfWork.SocialMedia.Insert(request);
        await _unitOfWork.Complete();

        return new SocialMediaReadDto(request.SocialMediaId, request.SocialMediaPlatform!);
    }

    public async Task<string> DeleteSocialMediaAsync(int value)
    {
        var response = await _unitOfWork.SocialMedia.Get(value);

        if (response is null)
        {
            return "400 - BadRequest";
        }

        _unitOfWork.SocialMedia.Delete(response);
        await _unitOfWork.Complete();

        return "success";
    }

    public async Task<IEnumerable<SocialMediaReadDto>> GetSocialMediaAsync()
    {
        var response = await _unitOfWork.SocialMedia.GetAll();
        return _mapper.Map<IEnumerable<SocialMediaReadDto>>(response);
    }

    public async Task<SocialMediaReadDto> GetSocialMediaAsync(int value)
    {
        var response = await _unitOfWork.SocialMedia.Get(value);
        return _mapper.Map<SocialMediaReadDto>(response);
    }

    public async Task<SocialMediaReadDto> GetSocialMediaAsync(string value)
    {
        var response = await _unitOfWork.SocialMedia.Get(sm => sm.SocialMediaPlatform == value);
        return _mapper.Map<SocialMediaReadDto>(response);
    }

    public async Task<SocialMediaReadDto> UpdateSocialMediaAsync(SocialMediaUpdateDto values)
    {
        SocialMedia request = new(values.SocialMediaId, values.SocialMediaPlatform!)
        {
            ModifiedBy = values.ModifiedBy,
            ModifiedOn = DateTime.Now
        };

        _unitOfWork.SocialMedia.Update(request);
        await _unitOfWork.Complete();

        return new SocialMediaReadDto(request.SocialMediaId, request.SocialMediaPlatform!);
    }
}

