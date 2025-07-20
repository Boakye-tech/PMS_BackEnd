// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/05/2025 10:54 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Management.Property;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Domain.ValueObjects.Property;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1
{
    //[Route("api/[controller]")]
    public partial class PropertyController : ControllerBase
    {

        /// <summary>
        /// Returns the acreage based one either the plot dimension or plot dimension id
        /// </summary>
        [HttpGet]
        //[Authorize(Policy = "Permission:Customers.READ")]
        [Route("GetAcreage")]
        public async Task<ActionResult> GetAcreage([FromQuery] int plotDimensionId, [FromQuery] string? plotDimension = null)
        {

            try
            {
                if(plotDimensionId == 0 && plotDimension is null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new ErrorResponseDto{ Code = 400 , Message = "Kindly provide a value." });
                }


                if (plotDimensionId == 0 && plotDimension is not null)
                {
                    var _result = _propertyMasterService.GetAcreage(plotDimension);
                    if (_result.IsSuccess)
                    {
                        return Ok(new {Acreage = _result.SuccessResponse!.Message });
                    }

                    var _status = _result.ErrorResponse!.Code;
                    return _status switch
                    {
                        204 => StatusCode(StatusCodes.Status204NoContent, _result.ErrorResponse),
                        400 => BadRequest(_result.ErrorResponse),
                        404 => NotFound(_result.ErrorResponse),
                        _ => StatusCode(StatusCodes.Status500InternalServerError, _result.ErrorResponse),
                    };
                }


                var result = await _propertyMasterService.GetAcreage(plotDimensionId);

                if (result.IsSuccess)
                {
                    return Ok(new { Acreage = result.SuccessResponse!.Message });
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

        //----------------------------------
        [HttpPost]
        [Route("CreateProperty")]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
        [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
        public async Task<ActionResult> CreateProperty([FromBody] PropertyMasterCreatePlotDto values)
        {
            try
            {
                var result = await _propertyMasterService.CreateProperty(values);

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
        /// Returns a summary list of exisitng properties and the respective customer
        /// </summary>
        [HttpGet]
        //[Authorize(Policy = "Permission:Customers.READ")]
        [Route("GetListOfProperties")]
        public async Task<ActionResult<List<PropertyListSummaryViewDto>>> GetListOfProperties([FromQuery] string? search = null, [FromQuery] int? landUseId = null, [FromQuery] int? landUseTypeId = null, [FromQuery] int? localityId = null, [FromQuery] int? allocationTypeId = null)
        {

            try
            {
                return Ok(await _propertyMasterService.GetListOfProperties(search, landUseId, landUseTypeId , localityId, allocationTypeId));

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
            }
        }



    }
}

