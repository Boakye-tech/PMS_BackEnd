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
        public async Task<ActionResult<IEnumerable<FeaturesReadDto>>> GetFeatures()
        {
            return Ok(await _propertyFeatureServices.GetFeaturesAsync());
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
        public async Task<ActionResult> CreateFeature([FromBody] FeaturesCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreateFeaturesAsync(values);

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
        public async Task<ActionResult<FeaturesReadDto>> UpdateFeature([FromBody] FeaturesUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdateFeaturesAsync(values);

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
        public async Task<ActionResult> DeleteFeature(int featureId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeleteFeatures(featureId);

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
        public async Task<ActionResult<IEnumerable<ApartmentFeaturesReadDto>>> GetApartmentFeatures()
        {
            return Ok(await _propertyFeatureServices.GetApartmentFeaturesAsync());
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
        public async Task<ActionResult> CreateApartmentFeature([FromBody] ApartmentFeaturesCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreateApartmentFeaturesAsync(values);

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
        public async Task<ActionResult<ApartmentFeaturesReadDto>> UpdateApartmentFeature([FromBody] ApartmentFeaturesUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdateApartmentFeaturesAsync(values);

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
        public async Task<ActionResult> DeleteApartmentFeature(int apartmentFeatureId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeleteApartmentFeatures(apartmentFeatureId);

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
    }
}

