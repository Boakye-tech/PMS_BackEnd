// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LocalityService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class LocalityService : ILocalityService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LocalityService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LocalityReadDto>> GetLocalityAsync()
    {
        var localities = await _unitOfWork.Locality.GetAll();
        return _mapper.Map<IEnumerable<LocalityReadDto>>(localities);
    }

    public async Task<LocalityReadDto> GetLocalityAsync(int value)
    {
        var localities = await _unitOfWork.Locality.Get(value);
        return _mapper.Map<LocalityReadDto>(localities);
    }

    public async Task<LocalityReadDto> GetLocalityAsync(string value)
    {
        var localities = await _unitOfWork.Locality.Get(l => l.LocalityInitial == value || l.LocalityName == value);
        return _mapper.Map<LocalityReadDto>(localities);
    }

    public async Task<ReturnResponsesDto> CreateLocalityAsync(LocalityCreateDto values)
    {
        try
        {
            var existingLocality = await _unitOfWork.Locality.Get(l => l.LocalityInitial == values.LocalityInitial || l.LocalityName == values.LocalityName);
            if (existingLocality != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Locality already exists." },
                    SuccessResponse = null
                };
            }

            var locality = Locality.Create(0, values.LocalityInitial!, values.LocalityName!, values.CustomerCode, values.CustomerCodeCounter);
            locality.CreatedBy = values.CreatedBy;
            locality.CreatedOn = DateTime.Now;

            _unitOfWork.Locality.Insert(locality);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Locality created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateLocalityAsync(LocalityUpdateDto values)
    {
        try
        {
            var locality = await _unitOfWork.Locality.Get(values.LocalityId);
            if (locality == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Locality with ID {values.LocalityId} not found." },
                    SuccessResponse = null
                };
            }

            locality.Update(values.LocalityId, values.LocalityInitial!, values.LocalityName!, values.CustomerCode, values.CustomerCodeCounter);
            locality.ModifiedBy = values.ModifiedBy;
            locality.ModifiedOn = DateTime.Now;

            _unitOfWork.Locality.Update(locality);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Locality modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteLocality(int localityId)
    {
        try
        {
            var locality = await _unitOfWork.Locality.Get(localityId);
            if (locality == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Locality with ID {localityId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.Locality.Delete(locality);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Locality with ID {localityId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<List<LocalityAndSitesReadDto>> GetLocalityAndSitesAsync()
    {
        // Get all localities and sites in a single query using Include
        var localities = await _unitOfWork.Locality.GetAll(includes: new List<string> { "Sites" });

        // Create a dictionary for quick lookup of land use types by land use ID
        var localitiesAndSites = localities.Select(locality =>
        {
            var sites = _mapper.Map<List<SitesReadDto>>(locality.Sites);
            return new LocalityAndSitesReadDto(
                new LocalityReadsDto(
                locality.LocalityId,
                locality.LocalityInitial!,
                locality.LocalityName!,
                locality.CustomerCode,
                locality.CustomerCodeCounter,
                false),
                sites
            );
        }).ToList();

        return localitiesAndSites;
    }
}

