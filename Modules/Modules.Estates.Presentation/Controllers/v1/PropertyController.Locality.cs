// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.Locality.cs
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
        /// Returns a list of localities and their associated sites
        /// </summary>
        [HttpGet]
        [Route("GetLocalityAndSites")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<LocalityAndSitesReadDto>))]
        public async Task<ActionResult<List<LocalityAndSitesReadDto>>> LocalityAndSites([FromServices] ILocalityService _localityService)
        {
            return Ok(await _localityService.GetLocalityAndSitesAsync());
        }


        /// <summary>
        /// Returns a list of all localities
        /// </summary>
        [HttpGet]
        [Route("GetLocalities")]
        public async Task<ActionResult<IEnumerable<LocalityReadDto>>> GetLocalities([FromServices] ILocalityService _localityService)
        {
            return Ok(await _localityService.GetLocalityAsync());
        }

        /// <summary>
        /// Returns a locality by its value
        /// </summary>
        /// <param name="value">The value of the locality to retrieve</param>
        [HttpGet]
        [Route("GetLocality/{value}")]
        [Obsolete]
        public async Task<ActionResult<LocalityReadDto>> GetLocality(string value, [FromServices] ILocalityService _localityService)
        {
            return Ok(await _localityService.GetLocalityAsync(value));
        }

        /// <summary>
        /// Returns a locality by its ID
        /// </summary>
        /// <param name="localityId">The ID of the locality to retrieve</param>
        [HttpGet]
        [Route("GetLocalityById/{localityId}")]
        [Obsolete]
        public async Task<ActionResult<LocalityReadDto>> GetLocalityById(int localityId, [FromServices] ILocalityService _localityService)
        {
            return Ok(await _localityService.GetLocalityAsync(localityId));
        }

        /// <summary>
        /// Creates a new locality
        /// </summary>
        /// <remarks>
        /// Creates a new locality in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateLocality
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "localityId": 0,
        ///         "locality": "DOWNTOWN",
        ///         "localityDescription": "Downtown area",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Locality created successfully.",
        ///         "data": {
        ///             "localityId": 1,
        ///             "locality": "DOWNTOWN",
        ///             "localityDescription": "Downtown area"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateLocality")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateLocality([FromBody] LocalityCreateDto values, [FromServices] ILocalityService _localityService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }


                var result = await _localityService.CreateLocalityAsync(values);

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
        /// Updates the details of an existing locality
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing locality based on the locality id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateLocality
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "localityId": 1,
        ///         "locality": "DOWNTOWN",
        ///         "localityDescription": "Updated downtown area",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Locality details modified successfully.",
        ///         "data": {
        ///             "localityId": 1,
        ///             "locality": "DOWNTOWN",
        ///             "localityDescription": "Updated downtown area"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateLocality")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LocalityReadDto>> UpdateLocality([FromBody] LocalityUpdateDto values, [FromServices] ILocalityService _localityService)
        {
            var userId = _userContextService.GetUserId();

            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _localityService.UpdateLocalityAsync(values);

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
        /// Deletes a locality by its ID
        /// </summary>
        /// <param name="localityId">The ID of the locality to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteLocality/{localityId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteLocality(int localityId, [FromServices] ILocalityService _localityService)
        {
            try
            {
                var result = await _localityService.DeleteLocality(localityId);

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
        /// Returns a list of all sites
        /// </summary>
        [HttpGet]
        [Route("GetSites")]
        public async Task<ActionResult<IEnumerable<SitesReadDto>>> GetSites([FromQuery] int localityId, [FromServices] ISitesService _siteService)
        {
            if(localityId != 0)
                return Ok(await _siteService.GetSitesAsync(localityId));


            return Ok(await _siteService.GetSitesAsync());
        }

        /// <summary>
        /// Creates a new site
        /// </summary>
        /// <remarks>
        /// Creates a new site in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateSite
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "localityId": 15,
        ///         "siteId": 0,
        ///         "siteName": "Site 3",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Site created successfully.",
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateSite")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateSite([FromBody] SitesCreateDto values, [FromServices] ISitesService _siteService)
        {
            try
            {
                var userId = _userContextService.GetUserId();

                if (!string.Equals(userId, values.CreatedBy))
                {
                    return Unauthorized();
                }

                var result = await _siteService.CreateSitesAsync(values);

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
        /// Updates the details of an existing site
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing site based on the site id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateSite
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "localityId": 15,
        ///         "siteId": 2,
        ///         "siteName": "Site Three(3)",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Site details modified successfully.",
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateSite")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LocalityReadDto>> UpdateSite([FromBody] SitesUpdateDto values, [FromServices] ISitesService _siteService)
        {
            var userId = _userContextService.GetUserId();

            if (!string.Equals(userId, values.ModifiedBy))
            {
                return Unauthorized();
            }

            var result = await _siteService.UpdateSitesAsync(values);

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
        /// Deletes a site by its ID
        /// </summary>
        /// <param name="siteId">The ID of the site to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteSite/{siteId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteSite(int siteId, [FromServices] ISitesService _siteService)
        {
            try
            {
                var result = await _siteService.DeleteSites(siteId);

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

