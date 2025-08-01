// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Apartment.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Mvc;

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of all features
        /// </summary>
        [HttpGet]
        [Route("GetFeatures")]
        public async Task<ActionResult<IEnumerable<FeaturesReadDto>>> GetFeatures([FromServices] IFeaturesService _featuresService)
        {
            return Ok(await _featuresService.GetFeaturesAsync());
        }

        /// <summary>
        /// Creates a new feature
        /// </summary>
        /// <remarks>
        /// Creates a new feature in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateFeature
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "featureId": 0,
        ///         "feature": "PARKING",
        ///         "featureDescription": "Parking space available",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Feature created successfully.",
        ///         "data": {
        ///             "featureId": 1,
        ///             "feature": "PARKING",
        ///             "featureDescription": "Parking space available"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateFeature")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateFeature([FromBody] FeaturesCreateDto values, [FromServices] IFeaturesService _featuresService)
        {
            try
            {
                var result = await _featuresService.CreateFeaturesAsync(values);

                if (result.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing feature
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing feature based on the feature id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateFeature
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "featureId": 1,
        ///         "feature": "PARKING",
        ///         "featureDescription": "Updated parking space available",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Feature details modified successfully.",
        ///         "data": {
        ///             "featureId": 1,
        ///             "feature": "PARKING",
        ///             "featureDescription": "Updated parking space available"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateFeature")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<FeaturesReadDto>> UpdateFeature([FromBody] FeaturesUpdateDto values, [FromServices] IFeaturesService _featuresService)
        {
            var result = await _featuresService.UpdateFeaturesAsync(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes a feature by its ID
        /// </summary>
        /// <param name="featureId">The ID of the feature to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteFeature/{featureId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteFeature(int featureId, [FromServices] IFeaturesService _featuresService)
        {
            try
            {
                var result = await _featuresService.DeleteFeatures(featureId);

                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Returns a list of all apartment features
        /// </summary>
        [HttpGet]
        [Route("GetApartmentFeatures")]
        public async Task<ActionResult<IEnumerable<ApartmentFeaturesReadDto>>> GetApartmentFeatures([FromServices] IApartmentFeaturesService _apartmentFeaturesService)
        {
            return Ok(await _apartmentFeaturesService.GetApartmentFeaturesAsync());
        }

        /// <summary>
        /// Creates a new apartment feature
        /// </summary>
        /// <remarks>
        /// Creates a new apartment feature in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateApartmentFeature
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "apartmentFeatureId": 0,
        ///         "apartmentFeature": "BALCONY",
        ///         "apartmentFeatureDescription": "Private balcony",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Apartment feature created successfully.",
        ///         "data": {
        ///             "apartmentFeatureId": 1,
        ///             "apartmentFeature": "BALCONY",
        ///             "apartmentFeatureDescription": "Private balcony"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateApartmentFeature")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateApartmentFeature([FromBody] ApartmentFeaturesCreateDto values, [FromServices] IApartmentFeaturesService _apartmentFeaturesService)
        {
            try
            {
                var result = await _apartmentFeaturesService.CreateApartmentFeaturesAsync(values);

                if (result.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing apartment feature
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing apartment feature based on the apartment feature id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateApartmentFeature
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "apartmentFeatureId": 1,
        ///         "apartmentFeature": "BALCONY",
        ///         "apartmentFeatureDescription": "Updated private balcony",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Apartment feature details modified successfully.",
        ///         "data": {
        ///             "apartmentFeatureId": 1,
        ///             "apartmentFeature": "BALCONY",
        ///             "apartmentFeatureDescription": "Updated private balcony"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateApartmentFeature")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<ApartmentFeaturesReadDto>> UpdateApartmentFeature([FromBody] ApartmentFeaturesUpdateDto values, [FromServices] IApartmentFeaturesService _apartmentFeaturesService)
        {
            var result = await _apartmentFeaturesService.UpdateApartmentFeaturesAsync(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes an apartment feature by its ID
        /// </summary>
        /// <param name="apartmentFeatureId">The ID of the apartment feature to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteApartmentFeature/{apartmentFeatureId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteApartmentFeature(int apartmentFeatureId, [FromServices] IApartmentFeaturesService _apartmentFeaturesService)
        {
            try
            {
                var result = await _apartmentFeaturesService.DeleteApartmentFeatures(apartmentFeatureId);

                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Returns a list of apartment categories and their associated types
        /// </summary>
        [HttpGet]
        [Route("GetApartmentCategoriesAndTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ApartmentCategoryAndTypesReadDto>))]
        public async Task<ActionResult<List<ApartmentCategoryAndTypesReadDto>>> GetApartmentCategoryAndTypes([FromServices] IApartmentCategoryService _apartmentCategoryService)
        {
            return Ok(await _apartmentCategoryService.GetApartmentCategoryAndTypesAsync());
        }

        /// <summary>
        /// Returns a list of apartment categories
        /// </summary>
        [HttpGet]
        [Route("GetApartmentCategories")]
        public async Task<ActionResult<IEnumerable<ApartmentCategoryReadDto>>> GetApartmentCategories([FromServices] IApartmentCategoryService _apartmentCategoryService)
        {
            return Ok(await _apartmentCategoryService.GetApartmentCategoryAsync());
        }

        /// <summary>
        /// Creates a new apartment category
        /// </summary>
        /// <remarks>
        /// Creates a new apartment category in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateApartmentCategory
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "apartmentCategoryName": "AFFORDABLE",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Apartment category created successfully.",
        ///         "data": {
        ///             "apartmentCategoryId": 1,
        ///             "apartmentCategoryName": "AFFORDABLE"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateApartmentCategory")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateApartmentCategory([FromBody] ApartmentCategoryCreateDto values, [FromServices] IApartmentCategoryService _apartmentCategoryService)
        {
            try
            {
                var result = await _apartmentCategoryService.CreateApartmentCategoryAsync(values);

                if (result.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing apartment category
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing apartment category based on the apartment category id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateApartmentCategory
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "apartmentCategoryId": 1,
        ///         "apartmentCategoryName": "LUXURY",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Apartment category details modified successfully.",
        ///         "data": {
        ///             "apartmentCategoryId": 1,
        ///             "apartmentCategoryName": "LUXURY"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateApartmentCategory")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<ApartmentCategoryReadDto>> UpdateApartmentCategory([FromBody] ApartmentCategoryUpdateDto values, [FromServices] IApartmentCategoryService _apartmentCategoryService)
        {
            var result = await _apartmentCategoryService.UpdateApartmentCategoryAsync(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes an apartment category by its ID
        /// </summary>
        /// <param name="apartmentCategoryId">The ID of the apartment category to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteApartmentCategory/{apartmentCategoryId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteApartmentCategory(int apartmentCategoryId, [FromServices] IApartmentCategoryService _apartmentCategoryService)
        {
            try
            {
                var result = await _apartmentCategoryService.DeleteApartmentCategory(apartmentCategoryId);

                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }

        /// <summary>
        /// Returns a list of apartment types
        /// </summary>
        [HttpGet]
        [Route("GetApartmentTypes")]
        public async Task<ActionResult<IEnumerable<ApartmentTypesReadDto>>> GetApartmentTypes([FromServices] IApartmentTypeService _apartmentTypeService)
        {
            return Ok(await _apartmentTypeService.GetApartmentTypeAsync());
        }

        /// <summary>
        /// Returns a list of apartment types based on a specific apartment category
        /// </summary>
        [HttpGet]
        [Route("GetApartmentTypes/{apartmentCategoryId}")]
        public async Task<ActionResult<IEnumerable<ApartmentTypesReadDto>>> GetApartmentTypes(int apartmentCategoryId, [FromServices] IApartmentTypeService _apartmentTypeService)
        {
            return Ok(await _apartmentTypeService.GetApartmentTypesAsync(apartmentCategoryId));
        }

        /// <summary>
        /// Creates a new apartment type
        /// </summary>
        /// <remarks>
        /// Creates a new apartment type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateApartmentType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "apartmentTypeId": 0,
        ///         "apartmentType": "STUDIO",
        ///         "apartmentTypeDescription": "Studio apartment",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Apartment type created successfully.",
        ///         "data": {
        ///             "apartmentTypeId": 1,
        ///             "apartmentType": "STUDIO",
        ///             "apartmentTypeDescription": "Studio apartment"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateApartmentType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateApartmentType([FromBody] ApartmentTypeCreateDto values, [FromServices] IApartmentTypeService _apartmentTypeService)
        {
            try
            {
                var result = await _apartmentTypeService.CreateApartmentTypeAsync(values);

                if (result.IsSuccess)
                {
                    return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                    400 => BadRequest(result.ErrorResponse),
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Updates the details of an existing apartment type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing apartment type based on the apartment type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateApartmentType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "apartmentTypeId": 1,
        ///         "apartmentType": "STUDIO",
        ///         "apartmentTypeDescription": "Updated Studio apartment",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Apartment type details modified successfully.",
        ///         "data": {
        ///             "apartmentTypeId": 1,
        ///             "apartmentType": "STUDIO",
        ///             "apartmentTypeDescription": "Updated Studio apartment"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateApartmentType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<ApartmentTypeReadDto>> UpdateApartmentType([FromBody] ApartmentTypeUpdateDto values, [FromServices] IApartmentTypeService _apartmentTypeService)
        {
            var result = await _apartmentTypeService.UpdateApartmentTypeAsync(values);

            if (result.IsSuccess)
            {
                return Ok(result.SuccessResponse);
            }

            var status = result.ErrorResponse!.Code;
            return status switch
            {
                204 => StatusCode(StatusCodes.Status204NoContent, result.ErrorResponse),
                400 => BadRequest(result.ErrorResponse),
                404 => NotFound(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        /// <summary>
        /// Deletes an apartment type by its ID
        /// </summary>
        /// <param name="apartmentTypeId">The ID of the apartment type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteApartmentType/{apartmentTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteApartmentType(int apartmentTypeId, [FromServices] IApartmentTypeService _apartmentTypeService)
        {
            try
            {
                var result = await _apartmentTypeService.DeleteApartmentType(apartmentTypeId);

                if (result.IsSuccess)
                {
                    return Ok(result.SuccessResponse);
                }

                var status = result.ErrorResponse!.Code;
                return status switch
                {
                    404 => NotFound(result.ErrorResponse),
                    _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
                };
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }



    }
}

