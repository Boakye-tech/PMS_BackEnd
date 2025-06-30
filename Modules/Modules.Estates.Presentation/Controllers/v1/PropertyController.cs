// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Presentation/Controllers/v1/PropertyController.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/05/202 01:0 AM 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel;
using System.Reflection;
using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;


namespace Modules.Estates.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]

/// <summary>
/// Controller for managing property-related operations
/// </summary>
public partial class PropertyController : ControllerBase
{
    private readonly IActivityServices _activityServices;
    private readonly IPropertySetupServices _propertySetupServices;
    private readonly IBlockServices _blockServices;
    private readonly IPropertyFeatureServices _propertyFeatureServices;
    private readonly IRentalsServices _rentalsService;

    private readonly IPropertyMasterService _propertyMasterService;
    

    public PropertyController(IActivityServices activityServices, IPropertySetupServices propertySetupServices, IBlockServices blockServices, IPropertyFeatureServices propertyFeatureServices,
                             IPropertyMasterService propertyMasterService, IRentalsServices rentalsService) 
    {
        _activityServices = activityServices;
        _propertySetupServices = propertySetupServices;
        _blockServices = blockServices;
        _propertyFeatureServices = propertyFeatureServices;
        _propertyMasterService = propertyMasterService;
        _rentalsService = rentalsService;
    }



    /// <summary>
    /// Returns a list of plot types and their features
    /// </summary>
    /// <remarks>
    /// **Sample Response 200:**
    /// 
    ///     [
    ///         {
    ///             "plotTypeId": 1,
    ///             "plotTypeName": "SERVICED PLOT",
    ///             "features": [
    ///                             {
    ///                                 "featureId": 29,
    ///                                 "featureName": "FIRST CLASS ROADS"
    ///                             },
    ///                             {
    ///                                 "featureId": 30,
    ///                                 "featureName": "PORTABLE WATER - POLYTANK"
    ///                             },
    ///                         ]
    ///         }
    ///     ]
    ///
    /// </remarks>
    [HttpGet]
    [Route("GetPlotFeatures")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<PlotFeaturesReadDto>))]
    public async Task<ActionResult<IEnumerable<PlotFeaturesReadDto>>> GetPlotFeatures([FromServices] IPlotFeaturesService _plotFeaturesService)
    {
        return Ok(await _plotFeaturesService.GetPlotFeaturesAsync());
    }


    /// <summary>
    /// Creates a new plot feature
    /// </summary>
    /// <remarks>
    /// Creates a new plot feature in the system
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreatePlotFeature
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "plotTypeId": 1,
    ///         "features": [,
    ///         29,30
    ///         ],
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Plot features created successfully."
    ///     }
    /// </remarks>
    [HttpPost]
    [Route("CreatePlotFeature")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreatePlotFeature([FromBody] PlotFeaturesCreateDto values, [FromServices] IPlotFeaturesService _plotFeaturesService)
    {
        try
        {
            var result = await _plotFeaturesService.CreatePlotFeaturesAsync(values);

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


    [HttpPut]
    [Route("UpdatePlotFeature")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<PlotFeaturesReadDto>> UpdatePlotFeature([FromBody] PlotFeaturesUpdateDto values, [FromServices] IPlotFeaturesService _plotFeaturesService)
    {
        var result = await _plotFeaturesService.UpdatePlotFeaturesAsync(values);

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
    /// Deletes a plot feature by using a combination of the plot type id and feature id
    /// </summary>
    /// <param name="plotTypeId">The ID of the plot type</param>
    /// <param name="featureId">The ID of the plot type feature to be deleted</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeletePlotFeature/{plotTypeId}/{featureId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeletePlotFeature(int plotTypeId, int featureId, [FromServices] IPlotFeaturesService _plotFeaturesService)
    {
        try
        {
            var result = await _plotFeaturesService.DeletePlotFeatures(plotTypeId, featureId);

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

