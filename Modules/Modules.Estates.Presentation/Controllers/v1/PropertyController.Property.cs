// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Property.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/2025 01:09 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of property heights
        /// </summary>
        [HttpGet]
        [Route("GetPropertyHeight")]
        public async Task<ActionResult<IEnumerable<PropertyHeightReadDto>>> GetPropertyHeight([FromServices] IPropertyHeightService _propertyHeightService)
        {
            return Ok(await _propertyHeightService.GetPropertyHeightAsync());
        }

        /// <summary>
        /// Creates a new property height
        /// </summary>
        /// <remarks>
        /// Creates a new property height in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePropertyHeight
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "propertyHeightId": 0,
        ///         "propertyHeight": "LOW_RISE",
        ///         "propertyHeightDescription": "Low rise building",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Property height created successfully.",
        ///         "data": {
        ///             "propertyHeightId": 1,
        ///             "propertyHeight": "LOW_RISE",
        ///             "propertyHeightDescription": "Low rise building"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreatePropertyHeight")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePropertyHeight([FromBody] PropertyHeightCreateDto values, [FromServices] IPropertyHeightService _propertyHeightService)
        {
            try
            {
                var result = await _propertyHeightService.CreatePropertyHeightAsync(values);

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
        /// Updates the details of an existing property height
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing property height based on the property height id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePropertyHeight
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "propertyHeightId": 1,
        ///         "propertyHeight": "LOW_RISE",
        ///         "propertyHeightDescription": "Updated low rise building",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Property height details modified successfully.",
        ///         "data": {
        ///             "propertyHeightId": 1,
        ///             "propertyHeight": "LOW_RISE",
        ///             "propertyHeightDescription": "Updated low rise building"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdatePropertyHeight")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PropertyHeightReadDto>> UpdatePropertyHeight([FromBody] PropertyHeightUpdateDto values, [FromServices] IPropertyHeightService _propertyHeightService)
        {
            var result = await _propertyHeightService.UpdatePropertyHeightAsync(values);

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
        /// Deletes a property height by its ID
        /// </summary>
        /// <param name="propertyHeightId">The ID of the property height to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePropertyHeight/{propertyHeightId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePropertyHeight(int propertyHeightId, [FromServices] IPropertyHeightService _propertyHeightService)
        {
            try
            {
                var result = await _propertyHeightService.DeletePropertyHeight(propertyHeightId);

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

        /// <summary>
        /// Returns a list of all property statuses
        /// </summary>
        [HttpGet]
        [Route("GetPropertyStatuses")]
        public async Task<ActionResult<IEnumerable<PropertyStatusReadDto>>> GetPropertyStatuses([FromServices] IPropertyStatusService _propertyStatusService)
        {
            return Ok(await _propertyStatusService.GetPropertyStatusAsync());
        }

        /// <summary>
        /// Creates a new property status
        /// </summary>
        /// <remarks>
        /// Creates a new property status in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePropertyStatus
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "propertyStatusId": 0,
        ///         "propertyStatus": "AVAILABLE",
        ///         "propertyStatusDescription": "Property is available",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Property status created successfully.",
        ///         "data": {
        ///             "propertyStatusId": 1,
        ///             "propertyStatus": "AVAILABLE",
        ///             "propertyStatusDescription": "Property is available"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreatePropertyStatus")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePropertyStatus([FromBody] PropertyStatusCreateDto values, [FromServices] IPropertyStatusService _propertyStatusService)
        {
            try
            {
                var result = await _propertyStatusService.CreatePropertyStatusAsync(values);

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
        /// Updates the details of an existing property status
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing property status based on the property status id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePropertyStatus
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "propertyStatusId": 1,
        ///         "propertyStatus": "AVAILABLE",
        ///         "propertyStatusDescription": "Updated property is available",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Property status details modified successfully.",
        ///         "data": {
        ///             "propertyStatusId": 1,
        ///             "propertyStatus": "AVAILABLE",
        ///             "propertyStatusDescription": "Updated property is available"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdatePropertyStatus")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PropertyStatusReadDto>> UpdatePropertyStatus([FromBody] PropertyStatusUpdateDto values, [FromServices] IPropertyStatusService _propertyStatusService)
        {
            var result = await _propertyStatusService.UpdatePropertyStatusAsync(values);

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
        /// Deletes a property status by its ID
        /// </summary>
        /// <param name="propertyStatusId">The ID of the property status to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePropertyStatus/{propertyStatusId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePropertyStatus(int propertyStatusId, [FromServices] IPropertyStatusService _propertyStatusService)
        {
            try
            {
                var result = await _propertyStatusService.DeletePropertyStatus(propertyStatusId);

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

        
        //-------------------PROPERTY TYPES-----------------
        /// <summary>
        /// Returns a list of property types
        /// </summary>
        [HttpGet]
        [Route("GetPropertyTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<PropertyTypeReadDto>))]
        public IActionResult GetPropertyTypes([FromServices] IPropertyTypeService _propertyTypeService)
        {
            var result = _propertyTypeService.GetPropertyTypesAsync().Result;
            return Ok(result);
        }


        /// <summary>
        /// Creates a new property type
        /// </summary>
        [HttpPost]
        [Route("CreatePropertyType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<IActionResult> CreatePropertyType([FromBody] PropertyTypeCreateDto values, [FromServices] IPropertyTypeService _propertyTypeService)
        {
            var result = await _propertyTypeService.CreatePropertyTypeAsync(values);
            if (result.IsSuccess)
            {
                return StatusCode(StatusCodes.Status201Created, result.SuccessResponse);
            }
            var status = result.ErrorResponse!.Code;
            return status switch
            {
                400 => BadRequest(result.ErrorResponse),
                _ => StatusCode(StatusCodes.Status500InternalServerError, result.ErrorResponse),
            };
        }

        /// <summary>
        /// Updates an existing property type
        /// </summary>
        [HttpPut]
        [Route("UpdatePropertyType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<IActionResult> UpdatePropertyType([FromBody] PropertyTypeUpdateDto values, [FromServices] IPropertyTypeService _propertyTypeService)
        {
            var result = await _propertyTypeService.UpdatePropertyTypeAsync(values);
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

        /// <summary>
        /// Deletes a property type
        /// </summary>
        [HttpDelete]
        [Route("DeletePropertyType/{propertyTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<IActionResult> DeletePropertyType(int propertyTypeId, [FromServices] IPropertyTypeService _propertyTypeService)
        {
            var result = await _propertyTypeService.DeletePropertyType(propertyTypeId);
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


    }
}

