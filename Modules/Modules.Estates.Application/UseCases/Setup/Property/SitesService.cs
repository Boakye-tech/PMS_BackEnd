// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/SitesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 10:30 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class SitesService : ISitesService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SitesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateSitesAsync(SitesCreateDto values)
        {
            try
            {
                var existingSite = await _unitOfWork.Sites.Get(l => l.SiteName == values.SiteName);
                if (existingSite != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Site name already exists." },
                        SuccessResponse = null
                    };
                }

                var Site = Sites.Create(values.LocalityId, 0, values.SiteName!);
                Site.CreatedBy = values.CreatedBy;
                Site.CreatedOn = DateTime.Now;

                _unitOfWork.Sites.Insert(Site);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Site created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }

        }

        public async Task<ReturnResponsesDto> DeleteSites(int siteId)
        {
            try
            {
                var site = await _unitOfWork.Sites.Get(siteId);
                if (site == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Site with ID {siteId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.Sites.Delete(site);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Site with ID {siteId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }

        }

        public async Task<IEnumerable<SitesReadDto>> GetSitesAsync()
        {
            var localities = await _unitOfWork.Sites.GetAll();
            return _mapper.Map<IEnumerable<SitesReadDto>>(localities);

        }

        public async Task<ReturnResponsesDto> UpdateSitesAsync(SitesUpdateDto values)
        {
            try
            {
                var site = await _unitOfWork.Sites.Get(values.SiteId);
                if (site == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Site with ID {values.SiteId} not found." },
                        SuccessResponse = null
                    };
                }

                site.Update(values.LocalityId, values.SiteId!, values.SiteName!);
                site.ModifiedBy = values.ModifiedBy;
                site.ModifiedOn = DateTime.Now;

                _unitOfWork.Sites.Update(site);
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
    }
}

