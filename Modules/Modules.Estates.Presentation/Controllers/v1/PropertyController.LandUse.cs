using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of land uses and their associated land use types
        /// </summary>
        [HttpGet]
        [Route("GetLandUsesAndLandUseTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<LandUseAndLandUseTypeReadDto>))]
        public async Task<ActionResult<List<LandUseAndLandUseTypeReadDto>>> GetLandUseAndLandUseType()
        {
            return Ok(await _propertySetupServices.GetLandUseAndLandUseTypeAsync());
        }

        /// <summary>
        /// Returns a list of land uses
        /// </summary>
        [HttpGet]
        [Route("GetLandUses")]
        public async Task<ActionResult<IEnumerable<LandUseReadDto>>> GetLandUses()
        {
            return Ok(await _propertySetupServices.GetLandUseAsync());
        }

        /// <summary>
        /// Creates a new land use
        /// </summary>
        /// <remarks>
        /// Creates a new land use in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateLandUse
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "landUseId": 0,
        ///         "landUse": "RESIDENTIAL",
        ///         "landUseDescription": "Residential land use",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Land use created successfully.",
        ///         "data": {
        ///             "landUseId": 1,
        ///             "landUse": "RESIDENTIAL",
        ///             "landUseDescription": "Residential land use"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateLandUse")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateLandUse([FromBody] LandUseCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateLandUseAsync(values);

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
        /// Updates the details of an existing land use
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing land use based on the land use id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateLandUse
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "landUseId": 1,
        ///         "landUse": "RESIDENTIAL",
        ///         "landUseDescription": "Updated Residential land use",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Land use details modified successfully.",
        ///         "data": {
        ///             "landUseId": 1,
        ///             "landUse": "RESIDENTIAL",
        ///             "landUseDescription": "Updated Residential land use"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateLandUse")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LandUseReadDto>> UpdateLandUse([FromBody] LandUseUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateLandUseAsync(values);

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
        /// Deletes a land use by its ID
        /// </summary>
        /// <param name="landUseId">The ID of the land use to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteLandUse/{landUseId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteLandUse(int landUseId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteLandUse(landUseId);

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
        /// Returns a list of land use types
        /// </summary>
        [HttpGet]
        [Route("GetLandUseTypes")]
        public async Task<ActionResult<IEnumerable<LandUseTypeReadDto>>> GetLandUseTypes()
        {
            return Ok(await _propertySetupServices.GetLandUseTypeAsync());
        }

        /// <summary>
        /// Creates a new land use type
        /// </summary>
        /// <remarks>
        /// Creates a new land use type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateLandUseType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "landUseTypeId": 0,
        ///         "landUseType": "SINGLE_FAMILY",
        ///         "landUseTypeDescription": "Single family residential",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Land use type created successfully.",
        ///         "data": {
        ///             "landUseTypeId": 1,
        ///             "landUseType": "SINGLE_FAMILY",
        ///             "landUseTypeDescription": "Single family residential"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateLandUseType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateLandUseType([FromBody] LandUseTypeCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateLandUseTypeAsync(values);

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
        /// Updates the details of an existing land use type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing land use type based on the land use type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateLandUseType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "landUseTypeId": 1,
        ///         "landUseType": "SINGLE_FAMILY",
        ///         "landUseTypeDescription": "Updated Single family residential",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Land use type details modified successfully.",
        ///         "data": {
        ///             "landUseTypeId": 1,
        ///             "landUseType": "SINGLE_FAMILY",
        ///             "landUseTypeDescription": "Updated Single family residential"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateLandUseType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LandUseTypeReadDto>> UpdateLandUseType([FromBody] LandUseTypeUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateLandUseTypeAsync(values);

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
        /// Deletes a land use type by its ID
        /// </summary>
        /// <param name="landUseTypeId">The ID of the land use type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteLandUseType/{landUseTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteLandUseType(int landUseTypeId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteLandUseType(landUseTypeId);

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

        // Lease Type and Period endpoints
        /// <summary>
        /// Returns a list of lease types and their associated periods
        /// </summary>
        [HttpGet]
        [Route("GetLeaseTypeAndPeriods")]
        public async Task<ActionResult<IEnumerable<LeaseTypeAndPeriodReadDto>>> GetLeaseTypeAndPeriods()
        {
            return Ok(await _propertyFeatureServices.GetLeaseTypeAndPeriodAsync());
        }

        /// <summary>
        /// Creates a new lease type and period
        /// </summary>
        /// <remarks>
        /// Creates a new lease type and period in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateLeaseTypeAndPeriod
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "leaseTypeAndPeriodId": 0,
        ///         "leaseType": "RESIDENTIAL",
        ///         "leasePeriod": "12",
        ///         "leaseTypeDescription": "12 months residential lease",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Lease type and period created successfully.",
        ///         "data": {
        ///             "leaseTypeAndPeriodId": 1,
        ///             "leaseType": "RESIDENTIAL",
        ///             "leasePeriod": "12",
        ///             "leaseTypeDescription": "12 months residential lease"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateLeaseTypeAndPeriod")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateLeaseTypeAndPeriod([FromBody] LeaseTypeAndPeriodCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreateLeaseTypeAndPeriodAsync(values);

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
        /// Updates the details of an existing lease type and period
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing lease type and period based on the lease type and period id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateLeaseTypeAndPeriod
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "leaseTypeAndPeriodId": 1,
        ///         "leaseType": "RESIDENTIAL",
        ///         "leasePeriod": "12",
        ///         "leaseTypeDescription": "Updated 12 months residential lease",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Lease type and period details modified successfully.",
        ///         "data": {
        ///             "leaseTypeAndPeriodId": 1,
        ///             "leaseType": "RESIDENTIAL",
        ///             "leasePeriod": "12",
        ///             "leaseTypeDescription": "Updated 12 months residential lease"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateLeaseTypeAndPeriod")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LeaseTypeAndPeriodReadDto>> UpdateLeaseTypeAndPeriod([FromBody] LeaseTypeAndPeriodUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdateLeaseTypeAndPeriodAsync(values);

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
        /// Deletes a lease type and period by its ID
        /// </summary>
        /// <param name="leaseTypeAndPeriodId">The ID of the lease type and period to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteLeaseTypeAndPeriod/{leaseTypeAndPeriodId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteLeaseTypeAndPeriod(int leaseTypeAndPeriodId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeleteLeaseTypeAndPeriod(leaseTypeAndPeriodId);

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

