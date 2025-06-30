// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PlotFeaturesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 1:36 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class PlotFeaturesService : IPlotFeaturesService
    {
        private readonly IUnitOfWork _unitOfWork;


        public PlotFeaturesService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;
       

        public async Task<ReturnResponsesDto> CreatePlotFeaturesAsync(PlotFeaturesCreateDto values)
        {
            int plotfeaturesId = 0;

            foreach (var featureId in values.features)
            {
                var plotfeature = await _unitOfWork.PlotFeatures.Get(pf => pf.PlotTypeId == values.plotTypeId && pf.FeaturesId == featureId);
                if(plotfeature is not null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Plot feature already exists." },
                        SuccessResponse = null
                    };
                }

                var newPlotFeature = PlotFeatures.Create(plotfeaturesId, values.plotTypeId, featureId);
                newPlotFeature.CreatedBy = values.createdBy;
                newPlotFeature.CreatedOn = DateTime.Now;

                _unitOfWork.PlotFeatures.Insert(newPlotFeature);
            }

            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Plot features created successfully." },
            };

        }

        public Task<ReturnResponsesDto> DeletePlotFeatures(int plotTypeId, int featureId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PlotFeaturesReadDto>> GetPlotFeaturesAsync()
        {
            var plotFeatures = await _unitOfWork.PlotFeatures.GetAll(includes: new List<string> { "PlotType", "Features" });

            // Grouping by PlotTypeId so we can collect all features per plot type
            var grouped = plotFeatures
                .GroupBy(pf => new
                {
                    pf.PlotTypeId,
                    pf.PlotType!.PlotTypes,
                })
                .Select(group => new PlotFeaturesReadDto(
                    plotTypeId: group.Key.PlotTypeId,
                    plotTypeName: group.Key.PlotTypes,
                    features: group.Select(f => new PlotFeatureReadDto(
                        featureId: f.FeaturesId,
                        featureName: f.Features?.Feature ?? ""
                    )).ToList()
                ))
                .ToList();

            return grouped;
        }

        public async Task<ReturnResponsesDto> UpdatePlotFeaturesAsync(PlotFeaturesUpdateDto values)
        {
            int plotfeaturesId = 0;

            var plotFeatures = (await _unitOfWork.PlotFeatures.GetAll(pf => pf.PlotTypeId == values.plotTypeId)).AsQueryable();
            if (plotFeatures is null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Plot features not found." },
                    SuccessResponse = null
                };
            }

            var existingFeature = plotFeatures.Select(j => j.FeaturesId).ToList();

            //remove unselected features
            var toRemove = plotFeatures.Where(j => !values.features.Contains(j.FeaturesId));
            _unitOfWork.PlotFeatures.DeleteRange(toRemove);


            //add new ones
            int[] newFeatureIdsToAdd = values.features.Where(id => !existingFeature.Contains(id)).ToArray();

            foreach (var featureId in newFeatureIdsToAdd)
            {

                var apartmentType = await _unitOfWork.PlotFeatures.Get(pf => pf.PlotTypeId == values.plotTypeId && pf.FeaturesId == featureId);
                if (apartmentType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Plot feature already exists." },
                        SuccessResponse = null
                    };
                }
                var newPlotFeature = PlotFeatures.Create(plotfeaturesId, values.plotTypeId, featureId);
                newPlotFeature.ModifiedBy = values.modifiedBy;
                newPlotFeature.ModifiedOn = DateTime.Now;

                _unitOfWork.PlotFeatures.Insert(newPlotFeature);
            }
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Plot features modified successfully." },
            };
        }



    }
}

