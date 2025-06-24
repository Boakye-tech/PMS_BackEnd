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
using Modules.Estates.Domain.Entities.Setup.Property;


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


            foreach (var item in values.Features)
            {

                var apartmentType = await _unitOfWork.ApartmentFeatures.Get(at => at.ApartmentTypeId == values.ApartmentTypeId && at.FeaturesId == item.FeatureId);
                if (apartmentType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Apartment type feature already exists." },
                        SuccessResponse = null
                    };
                }

                var newApartmentFeature = ApartmentFeatures.Create(values.ApartmentCategory, apartmentFeaturesId, values.ApartmentTypeId!, item.FeatureId, item.FloorArea);
                newApartmentFeature.CreatedBy = values.CreatedBy;
                newApartmentFeature.CreatedOn = DateTime.Now;

                _unitOfWork.ApartmentFeatures.Insert(newApartmentFeature);

            }
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

            var apartmentDetails = await _unitOfWork.ApartmentFeatures.GetAll(includes: new List<string> { "ApartmentType", "Features" });

            // Grouping by ApartmentTypeId so we can collect all features per apartment type
            var grouped = apartmentDetails
                .GroupBy(af => new
                {
                    af.ApartmentFeaturesId,
                    af.ApartmentTypeId,
                    af.ApartmentType!.ApartmentType,
                    af.ApartmentCategory
                })
                .Select(group => new ApartmentFeaturesReadDto(
                    ApartmentFeaturesId: group.Key.ApartmentFeaturesId,
                    ApartmentCategory: group.Key.ApartmentCategory.GetApartmentCategoryEnumDescription(),
                    ApartmentType: group.Key.ApartmentType,
                    Features: group.Select(f => new ApartmentFeatureReadDto(
                        FeatureId: f.FeaturesId,
                        Feature: f.Features?.Feature ?? "",
                        FloorArea: f.FloorArea
                    )).ToList()
                ))
                .ToList();

            return grouped;

            //var apartmentFeatures = (from af in await _unitOfWork.ApartmentFeatures.GetAll()
            //                         join at in await _unitOfWork.ApartmentTypes.GetAll()
            //                         on af.ApartmentTypeId equals at.ApartmentTypeId
            //                         select new ApartmentFeaturesReadDto
            //                         (
            //                             af.ApartmentFeaturesId,
            //                             ApartmentCategoryEnumDescription.GetApartmentCategoryEnumDescription(af.ApartmentCategory),
            //                             at.ApartmentType,
            //                             af.FeaturesId,
            //                             (List<ApartmentFeatureReadDto>)af.,

            //                         )).ToList();

            //return apartmentFeatures;


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

            foreach (var item in values.Features)
            {
                apartmentTypeFeature.Update(values.ApartmentFeaturesId, values.ApartmentTypeId, item.FeatureId, item.FloorArea);
                apartmentTypeFeature.ModifiedBy = values.ModifiedBy;
                apartmentTypeFeature.ModifiedOn = DateTime.Now;

                _unitOfWork.ApartmentFeatures.Update(apartmentTypeFeature);
            }

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