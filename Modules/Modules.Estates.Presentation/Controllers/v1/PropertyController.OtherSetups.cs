using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    public partial class PropertyController
    {
        /// <summary>
        /// Returns a list of plot dimensions
        /// </summary>
        [HttpGet]
        [Route("GetPlotDimensions")]
        public async Task<ActionResult<IEnumerable<PlotDimensionReadDto>>> GetPlotDimensions()
        {
            return Ok(await _propertyFeatureServices.GetPlotDimensionAsync());
        }

        /// <summary>
        /// Returns a plot dimension by its value
        /// </summary>
        /// <param name="value">The value of the plot dimension to retrieve</param>
        [HttpGet]
        [Route("GetPlotDimension/{value}")]
        public async Task<ActionResult<PlotDimensionReadDto>> GetPlotDimension(string value)
        {
            return Ok(await _propertyFeatureServices.GetPlotDimensionAsync(value));
        }

        /// <summary>
        /// Returns a plot dimension by its ID
        /// </summary>
        /// <param name="plotDimensionId">The ID of the plot dimension to retrieve</param>
        [HttpGet]
        [Route("GetPlotDimensionById/{plotDimensionId}")]
        public async Task<ActionResult<PlotDimensionReadDto>> GetPlotDimensionById(int plotDimensionId)
        {
            return Ok(await _propertyFeatureServices.GetPlotDimensionAsync(plotDimensionId));
        }

        /// <summary>
        /// Creates a new plot dimension
        /// </summary>
        /// <remarks>
        /// Creates a new plot dimension in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePlotDimension
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "plotDimensionId": 0,
        ///         "plotDimension": "100x100",
        ///         "plotDimensionDescription": "100 meters by 100 meters",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Plot dimension created successfully.",
        ///         "data": {
        ///             "plotDimensionId": 1,
        ///             "plotDimension": "100x100",
        ///             "plotDimensionDescription": "100 meters by 100 meters"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreatePlotDimension")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePlotDimension([FromBody] PlotDimensionCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreatePlotDimensionAsync(values);

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
        /// Updates the details of an existing plot dimension
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing plot dimension based on the plot dimension id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePlotDimension
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "plotDimensionId": 1,
        ///         "plotDimension": "100x100",
        ///         "plotDimensionDescription": "Updated 100 meters by 100 meters",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Plot dimension details modified successfully.",
        ///         "data": {
        ///             "plotDimensionId": 1,
        ///             "plotDimension": "100x100",
        ///             "plotDimensionDescription": "Updated 100 meters by 100 meters"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdatePlotDimension")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PlotDimensionReadDto>> UpdatePlotDimension([FromBody] PlotDimensionUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdatePlotDimensionAsync(values);

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
        /// Deletes a plot dimension by its ID
        /// </summary>
        /// <param name="plotDimensionId">The ID of the plot dimension to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePlotDimension/{plotDimensionId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePlotDimension(int plotDimensionId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeletePlotDimension(plotDimensionId);

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
        /// Returns a list of apartment types
        /// </summary>
        [HttpGet]
        [Route("GetApartmentTypes")]
        public async Task<ActionResult<IEnumerable<ApartmentTypesReadDto>>> GetApartmentTypes()
        {
            return Ok(await _propertyFeatureServices.GetApartmentTypeAsync());
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
        public async Task<ActionResult> CreateApartmentType([FromBody] ApartmentTypeCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreateApartmentTypeAsync(values);

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
        public async Task<ActionResult<ApartmentTypeReadDto>> UpdateApartmentType([FromBody] ApartmentTypeUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdateApartmentTypeAsync(values);

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
        public async Task<ActionResult> DeleteApartmentType(int apartmentTypeId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeleteApartmentType(apartmentTypeId);

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
        /// Returns a list of plot types
        /// </summary>
        [HttpGet]
        [Route("GetPlotTypes")]
        public async Task<ActionResult<IEnumerable<PlotTypeReadDto>>> GetPlotTypes()
        {
            return Ok(await _propertyFeatureServices.GetPlotTypeAsync());
        }

        /// <summary>
        /// Creates a new plot type
        /// </summary>
        /// <remarks>
        /// Creates a new property type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreatePlotType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PlotTypeId": 0,
        ///         "PlotType": "SERVICED PLOT",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Plot type created successfully."
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreatePlotType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreatePlotType([FromBody] PlotTypeCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreatePlotTypeAsync(values);

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
        /// Updates the details of an existing plot type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing plot type based on the plot type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdatePlotType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "PlotTypeId": 1,
        ///         "PlotType": "SEMI-SERVICED PLOT",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Plot type details modified successfully."
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdatePlotType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<PlotTypeReadDto>> UpdatePlotType([FromBody] PlotTypeUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdatePlotTypeAsync(values);

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
        /// Deletes a property type by its ID
        /// </summary>
        /// <param name="PlotTypeId">The ID of the property type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeletePlotType/{plotTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeletePlotType(int plotTypeId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeletePlotType(plotTypeId);

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
        /// Returns a list of property heights
        /// </summary>
        [HttpGet]
        [Route("GetPropertyHeight")]
        public async Task<ActionResult<IEnumerable<PropertyHeightReadDto>>> GetPropertyHeight()
        {
            return Ok(await _propertyFeatureServices.GetPropertyHeightAsync());
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
        public async Task<ActionResult> CreatePropertyHeight([FromBody] PropertyHeightCreateDto values)
        {
            try
            {
                var result = await _propertyFeatureServices.CreatePropertyHeightAsync(values);

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
        public async Task<ActionResult<PropertyHeightReadDto>> UpdatePropertyHeight([FromBody] PropertyHeightUpdateDto values)
        {
            var result = await _propertyFeatureServices.UpdatePropertyHeightAsync(values);

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
        public async Task<ActionResult> DeletePropertyHeight(int propertyHeightId)
        {
            try
            {
                var result = await _propertyFeatureServices.DeletePropertyHeight(propertyHeightId);

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
        /// Returns a list of localities and their associated sites
        /// </summary>
        [HttpGet]
        [Route("GetLocalityAndSites")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<LocalityAndSitesReadDto>))]
        public async Task<ActionResult<List<LocalityAndSitesReadDto>>> LocalityAndSites()
        {
            return Ok(await _propertySetupServices.GetLocalityAndSitesAsync());
        }


        /// <summary>
        /// Returns a list of all localities
        /// </summary>
        [HttpGet]
        [Route("GetLocalities")]
        public async Task<ActionResult<IEnumerable<LocalityReadDto>>> GetLocalities()
        {
            return Ok(await _propertySetupServices.GetLocalityAsync());
        }

        /// <summary>
        /// Returns a locality by its value
        /// </summary>
        /// <param name="value">The value of the locality to retrieve</param>
        [HttpGet]
        [Route("GetLocality/{value}")]
        public async Task<ActionResult<LocalityReadDto>> GetLocality(string value)
        {
            return Ok(await _propertySetupServices.GetLocalityAsync(value));
        }

        /// <summary>
        /// Returns a locality by its ID
        /// </summary>
        /// <param name="localityId">The ID of the locality to retrieve</param>
        [HttpGet]
        [Route("GetLocalityById/{localityId}")]
        public async Task<ActionResult<LocalityReadDto>> GetLocalityById(int localityId)
        {
            return Ok(await _propertySetupServices.GetLocalityAsync(localityId));
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
        public async Task<ActionResult> CreateLocality([FromBody] LocalityCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateLocalityAsync(values);

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
        public async Task<ActionResult<LocalityReadDto>> UpdateLocality([FromBody] LocalityUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateLocalityAsync(values);

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
        public async Task<ActionResult> DeleteLocality(int localityId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteLocality(localityId);

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
        public async Task<ActionResult<IEnumerable<SitesReadDto>>> GetSites()
        {
            return Ok(await _propertySetupServices.GetSitesAsync());
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
        public async Task<ActionResult> CreateSite([FromBody] SitesCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateSiteAsync(values);

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
        public async Task<ActionResult<LocalityReadDto>> UpdateSite([FromBody] SitesUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateSiteAsync(values);

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
        public async Task<ActionResult> DeleteSite(int siteId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteSite(siteId);

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
        /// Returns a list of all allocation types
        /// </summary>
        [HttpGet]
        [Route("GetAllocationTypes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AllocationTypeReadDto))]
        public async Task<ActionResult<IEnumerable<AllocationTypeReadDto>>> GetAllocationTypes()
        {
            return Ok(await _propertySetupServices.GetAllocationTypeAsync());
        }

        ///// <summary>
        ///// Returns an allocation type by its value
        ///// </summary>
        ///// <param name="allocationType">The value of the allocation type to retrieve</param>
        //[HttpGet]
        //[Route("GetAllocationType/{allocationType}")]
        //public async Task<ActionResult<AllocationTypeReadDto>> GetAllocationType(string allocationType)
        //{
        //    return Ok(await _propertySetupServices.GetAllocationTypeAsync(allocationType));
        //}

        ///// <summary>
        ///// Returns an allocation type by its ID
        ///// </summary>
        ///// <param name="allocationTypeId">The ID of the allocation type to retrieve</param>
        //[HttpGet]
        //[Route("GetAllocationTypeById/{allocationTypeId}")]
        //public async Task<ActionResult<AllocationTypeReadDto>> GetAllocationTypeById(int allocationTypeId)
        //{
        //    return Ok(await _propertySetupServices.GetAllocationTypeAsync(allocationTypeId));
        //}

        /// <summary>
        /// Creates a new allocation type
        /// </summary>
        /// <remarks>
        /// Creates a new allocation type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateAllocationType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "allocationTypeId": 0,
        ///         "allocationType": "RENTAL",
        ///         "allocationTypeDescription": "Rental allocation",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Allocation type created successfully.",
        ///         "data": {
        ///             "allocationTypeId": 1,
        ///             "allocationType": "RENTAL",
        ///             "allocationTypeDescription": "Rental allocation"
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateAllocationType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateAllocationType([FromBody] AllocationTypeCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateAllocationTypeAsync(values);

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
        /// Updates the details of an existing allocation type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing allocation type based on the allocation type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateAllocationType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "allocationTypeId": 1,
        ///         "allocationType": "RENTAL",
        ///         "allocationTypeDescription": "Updated rental allocation",
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Allocation type details modified successfully.",
        ///         "data": {
        ///             "allocationTypeId": 1,
        ///             "allocationType": "RENTAL",
        ///             "allocationTypeDescription": "Updated rental allocation"
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateAllocationType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<AllocationTypeReadDto>> UpdateAllocationType([FromBody] AllocationTypeUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateAllocationTypeAsync(values);

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
        /// Deletes an allocation type by its ID
        /// </summary>
        /// <param name="allocationTypeId">The ID of the allocation type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteAllocationType/{allocationTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteAllocationType(int allocationTypeId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteAllocationType(allocationTypeId);

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
        /// Returns a list of all currency exchange rates
        /// </summary>
        [HttpGet]
        [Route("GetCurrencyExchangeRates")]
        public async Task<ActionResult<IEnumerable<CurrencyExchangeRateReadDto>>> GetCurrencyExchangeRates()
        {
            return Ok(await _activityServices.GetCurrencyExchangeRateAsync());
        }

        /// <summary>
        /// Creates a new currency exchange rate
        /// </summary>
        /// <remarks>
        /// Creates a new currency exchange rate in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateCurrencyExchangeRate
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 0,
        ///         "currency": "USD",
        ///         "exchangeRate": 1.0,
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Currency exchange rate created successfully.",
        ///         "data": {
        ///             "currencyId": 1,
        ///             "currency": "USD",
        ///             "exchangeRate": 1.0
        ///         }
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateCurrencyExchangeRate")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateCurrencyExchangeRate([FromBody] CurrencyExchangeRateCreateDto values)
        {
            try
            {
                var result = await _activityServices.CreateCurrencyExchangeRateAsync(values);

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
        /// Updates the details of an existing currency exchange rate
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing currency exchange rate based on the currency id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateCurrencyExchangeRate
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "currencyId": 1,
        ///         "currency": "USD",
        ///         "exchangeRate": 1.1,
        ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 200:**
        /// 
        ///     {
        ///         "code": 200,
        ///         "message": "Currency exchange rate details modified successfully.",
        ///         "data": {
        ///             "currencyId": 1,
        ///             "currency": "USD",
        ///             "exchangeRate": 1.1
        ///         }
        ///     }
        /// </remarks>
        [HttpPut]
        [Route("UpdateCurrencyExchangeRate")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<CurrencyExchangeRateReadDto>> UpdateCurrencyExchangeRate([FromBody] CurrencyExchangeRateUpdateDto values)
        {
            var result = await _activityServices.UpdateCurrencyExchangeRateAsync(values);

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
        /// Deletes a currency exchange rate by its ID
        /// </summary>
        /// <param name="currencyId">The ID of the currency exchange rate to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteCurrencyExchangeRate/{currencyId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteCurrencyExchangeRate(int currencyId)
        {
            try
            {
                var result = await _activityServices.DeleteCurrencyExchangeRateAsync(currencyId);

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
        public async Task<ActionResult<IEnumerable<PropertyStatusReadDto>>> GetPropertyStatuses()
        {
            return Ok(await _activityServices.GetPropertyStatusAsync());
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
        public async Task<ActionResult> CreatePropertyStatus([FromBody] PropertyStatusCreateDto values)
        {
            try
            {
                var result = await _activityServices.CreatePropertyStatusAsync(values);

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
        public async Task<ActionResult<PropertyStatusReadDto>> UpdatePropertyStatus([FromBody] PropertyStatusUpdateDto values)
        {
            var result = await _activityServices.UpdatePropertyStatusAsync(values);

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
        public async Task<ActionResult> DeletePropertyStatus(int propertyStatusId)
        {
            try
            {
                var result = await _activityServices.DeletePropertyStatus(propertyStatusId);

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

        //------scheme types

        /// <summary>
        /// Returns a list of all scheme types
        /// </summary>
        [HttpGet]
        [Route("GetSchemeTypes")]
        public async Task<ActionResult<IEnumerable<SchemeTypeReadDto>>> GetSchemeTypes()
        {
            return Ok(await _propertySetupServices.GetSchemeTypeAsync());
        }

        /// <summary>
        /// Creates a new scheme type
        /// </summary>
        /// <remarks>
        /// Creates a new scheme type in the system
        ///
        /// **Sample Request:**
        ///
        ///     POST /CreateSchemeType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "schemeType": "TDC HOUSE OWNERHISP SCHEME",
        ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
        ///     }
        ///
        /// **Sample Response 201:**
        /// 
        ///     {
        ///         "code": 201,
        ///         "message": "Scheme Type created successfully.",
        ///     }
        /// </remarks>
        [HttpPost]
        [Route("CreateSchemeType")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateSchemeType([FromBody] SchemeTypeCreateDto values)
        {
            try
            {
                var result = await _propertySetupServices.CreateSchemeTypeAsync(values);

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
        /// Updates the details of an existing scheme type
        /// </summary>
        /// <remarks>
        /// Modifies/updates an existing scheme type based on the scheme type id 
        ///
        /// **Sample Request:**
        ///
        ///     PUT /UpdateSchemeType
        ///
        /// **Sample Request Body:**
        /// 
        ///     {
        ///         "schemeTypeId": 1,
        ///         "schemeType": "TDC HOUSE OWNERHISP SCHEME (H.O.S)",
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
        [Route("UpdateSchemeType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult<LocalityReadDto>> UpdateSchemeType([FromBody] SchemeTypeUpdateDto values)
        {
            var result = await _propertySetupServices.UpdateSchemeTypeAsync(values);

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
        /// Deletes a scheme type by its ID
        /// </summary>
        /// <param name="schemeTypeId">The ID of the scheme type to delete</param>
        /// <returns>Success or error response</returns>
        [HttpDelete("DeleteSchemeType/{schemeTypeId}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> DeleteSchemeType(int schemeTypeId)
        {
            try
            {
                var result = await _propertySetupServices.DeleteSchemeType(schemeTypeId);

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

