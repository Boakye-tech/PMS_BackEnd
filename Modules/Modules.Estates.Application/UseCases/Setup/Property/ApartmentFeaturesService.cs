// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ApartmentFeaturesService.cs
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
    public class ApartmentFeaturesService : IApartmentFeaturesService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IMapper _mapper;


        public ApartmentFeaturesService(IUnitOfWork unitOfWork) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
            //_mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateApartmentFeaturesAsync(ApartmentFeaturesCreateDto values)
        {
            int apartmentFeaturesId = 0;

            var apartmentType = await _unitOfWork.ApartmentFeatures.Get(at => at.ApartmentTypeId == values.ApartmentTypeId && at.Feature == values.Feature);
            if (apartmentType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Apartment type feature already exists." },
                    SuccessResponse = null
                };
            }

            var newApartmentFeature = ApartmentFeatures.Create(values.ApartmentCategory, apartmentFeaturesId, values.ApartmentTypeId!, values.Feature, values.FloorArea);
            newApartmentFeature.CreatedBy = values.CreatedBy;
            newApartmentFeature.CreatedOn = DateTime.Now;

            _unitOfWork.ApartmentFeatures.Insert(newApartmentFeature);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Apartment type feature created successfully." },
            };
        }

        public Task<ReturnResponsesDto> DeleteApartmentFeatures(int ApartmentFeaturesId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ApartmentFeaturesReadDto>> GetApartmentFeaturesAsync()
        {
            var apartmentFeatures = (from af in await _unitOfWork.ApartmentFeatures.GetAll()
                                     join at in await _unitOfWork.ApartmentTypes.GetAll()
                                     on af.ApartmentTypeId equals at.ApartmentTypeId
                                     select new ApartmentFeaturesReadDto
                                     (
                                         af.ApartmentFeaturesId,
                                         ApartmentCategoryEnumDescription.GetApartmentCategoryEnumDescription(af.ApartmentCategory),
                                         at.ApartmentType,
                                         af.Feature,
                                         af.FloorArea
                                     )).ToList();

            return apartmentFeatures;
        }

        public async Task<ReturnResponsesDto> UpdateApartmentFeaturesAsync(ApartmentFeaturesUpdateDto values)
        {
            var apartmentTypeFeature = await _unitOfWork.ApartmentFeatures.Get(values.ApartmentFeaturesId);
            if (apartmentTypeFeature == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Apartment type feature with ID {values.ApartmentFeaturesId} not found." },
                    SuccessResponse = null
                };
            }

            apartmentTypeFeature.Update(values.ApartmentFeaturesId, values.ApartmentTypeId, values.Feature, values.FloorArea);
            apartmentTypeFeature.ModifiedBy = values.ModifiedBy;
            apartmentTypeFeature.ModifiedOn = DateTime.Now;

            _unitOfWork.ApartmentFeatures.Update(apartmentTypeFeature);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Apartment Type modified successfully." },
            };
        }
    }
}