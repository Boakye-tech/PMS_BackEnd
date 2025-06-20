// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/FeaturesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/05/2025 4:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class FeaturesService : IFeaturesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public FeaturesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateFeaturesAsync(FeaturesCreateDto values)
        {
            int FeaturesId = 0;

            var Type = await _unitOfWork.Features.Get(at => at.Feature == values.Feature);
            if (Type != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Feature already exists." },
                    SuccessResponse = null
                };
            }

            var newFeature = Features.Create(FeaturesId, values.Feature);
            newFeature.CreatedBy = values.CreatedBy;
            newFeature.CreatedOn = DateTime.Now;

            _unitOfWork.Features.Insert(newFeature);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Feature created successfully." },
            };
        }

        public async Task<ReturnResponsesDto> DeleteFeatures(int featureId)
        {
            var feature = await _unitOfWork.Features.Get(featureId);
            if (feature == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Feature with ID {featureId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.Features.Delete(feature);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Feature deleted successfully." },
            };

        }

        public async Task<IEnumerable<FeaturesReadDto>> GetFeaturesAsync()
        {
            var response = await _unitOfWork.Features.GetAll();
            return _mapper.Map<IEnumerable<FeaturesReadDto>>(response);

        }

        public async Task<ReturnResponsesDto> UpdateFeaturesAsync(FeaturesUpdateDto values)
        {
            var TypeFeature = await _unitOfWork.Features.Get(values.FeaturesId);
            if (TypeFeature == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Feature with ID {values.FeaturesId} not found." },
                    SuccessResponse = null
                };
            }

            TypeFeature.Update(values.FeaturesId, values.Feature);
            TypeFeature.ModifiedBy = values.ModifiedBy;
            TypeFeature.ModifiedOn = DateTime.Now;

            _unitOfWork.Features.Update(TypeFeature);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Feature modified successfully." },
            };
        }
    }
}

