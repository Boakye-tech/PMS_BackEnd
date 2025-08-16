// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.LandUse.cs
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
        /// Returns a list of land uses and their associated land use types
        /// </summary>
        [HttpGet]
        [Route("GetLandUsesAndLandUseTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<LandUseAndLandUseTypeReadDto>))]
        public async Task<ActionResult<List<LandUseAndLandUseTypeReadDto>>> GetLandUseAndLandUseType([FromQuery] string? searchTerm,[FromServices] ILandUseService _landUseService)
        {
            return Ok(await _landUseService.GetLandUseAndLandUseTypeAsync(searchTerm));
        }

        /// <summary>
        /// Returns a list of land uses
        /// </summary>
        [HttpGet]
        [Route("GetLandUses")]
        public async Task<ActionResult<IEnumerable<LandUseReadDto>>> GetLandUses([FromServices] ILandUseService _landUseService)
        {
            return Ok(await _landUseService.GetLandUseAsync());
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
        public async Task<ActionResult> CreateLandUse([FromBody] LandUseCreateDto values, [FromServices] ILandUseService _landUseService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _landUseService.CreateLandUseAsync(values);

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
        public async Task<ActionResult<LandUseReadDto>> UpdateLandUse([FromBody] LandUseUpdateDto values, [FromServices] ILandUseService _landUseService)
        {
            var userId = _userContextService.GetUserId();

            //if (!string.Equals(userId, values.ModifiedBy))
            //{
            //    return Unauthorized();
            //}

            var result = await _landUseService.UpdateLandUseAsync(values);

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
        public async Task<ActionResult> DeleteLandUse(int landUseId, [FromServices] ILandUseService _landUseService)
        {
            try
            {
                var result = await _landUseService.DeleteLandUse(landUseId);

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
        public async Task<ActionResult<IEnumerable<LandUseTypeReadDto>>> GetLandUseTypes([FromQuery] int landuseId, [FromServices] ILandUseTypeService _landUseTypeService)
        {
            if(landuseId != 0)
                return Ok(await _landUseTypeService.GetLandUseTypeByLandUseAsync(landuseId));

            return Ok(await _landUseTypeService.GetLandUseTypeAsync());
        }


        ///// <summary>
        ///// Returns a list of land use types based on specific land use
        ///// </summary>
        //[HttpGet]
        //[Route("GetLandUseTypes/{landuseId}")]
        //public async Task<ActionResult<IEnumerable<LandUseTypeReadDto>>> GetLandUseTypes(int landuseId, [FromServices] ILandUseTypeService _landUseTypeService)
        //{
        //    return Ok(await _landUseTypeService.GetLandUseTypeByLandUseAsync(landuseId));
        //}

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
        public async Task<ActionResult> CreateLandUseType([FromBody] LandUseTypeCreateDto values, [FromServices] ILandUseTypeService _landUseTypeService)
        {
            try
            {
                var result = await _landUseTypeService.CreateLandUseTypeAsync(values);

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
        public async Task<ActionResult<LandUseTypeReadDto>> UpdateLandUseType([FromBody] LandUseTypeUpdateDto values, [FromServices] ILandUseTypeService _landUseTypeService)
        {
            var result = await _landUseTypeService.UpdateLandUseTypeAsync(values);

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
        public async Task<ActionResult> DeleteLandUseType(int landUseTypeId, [FromServices] ILandUseTypeService _landUseTypeService)
        {
            try
            {
                var result = await _landUseTypeService.DeleteLandUseType(landUseTypeId);

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

