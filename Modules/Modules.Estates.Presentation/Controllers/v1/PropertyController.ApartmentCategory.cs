using Microsoft.AspNetCore.Mvc;

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of apartment categories and their associated types
        /// </summary>
        [HttpGet]
        [Route("GetApartmentCategoriesAndTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ApartmentCategoryAndTypesReadDto>))]
        public async Task<ActionResult<List<ApartmentCategoryAndTypesReadDto>>> GetApartmentCategoryAndTypes()
        {
            return Ok(await _propertySetupServices.GetApartmentCategoryAndTypesAsync());
        }

        /// <summary>
        /// Returns a list of apartment categories
        /// </summary>
        [HttpGet]
        [Route("GetApartmentCategories")]
        public async Task<ActionResult<IEnumerable<ApartmentCategoryReadDto>>> GetApartmentCategories()
        {
            return Ok(await _propertySetupServices.GetApartmentCategoryAsync());
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
        public async Task<ActionResult> CreateApartmentCategory([FromBody] ApartmentCategoryCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateApartmentCategoryAsync(values);

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
        public async Task<ActionResult<ApartmentCategoryReadDto>> UpdateApartmentCategory([FromBody] ApartmentCategoryUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateApartmentCategoryAsync(values);

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
        public async Task<ActionResult> DeleteApartmentCategory(int apartmentCategoryId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteApartmentCategory(apartmentCategoryId);

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