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

using Asp.Versioning;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Domain.Exceptions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]

/// <summary>
/// Controller for managing property-related operations
/// </summary>
public class PropertyController : ControllerBase
{
    public readonly IAllocationTypeService _allocationTypeService;
    public readonly IApartmentTypeService _apartmentTypeService;

    readonly IBlockNumberService _blockNumberService;
    readonly IBlockSideService _blockSideService;
    readonly IBlockTypeService _blockTypeService;
    readonly IBlockUnitService _blockUnitService;

    readonly IFacilitiesService _facilitiesService;
    readonly IFloorNumberingService _floorNumberingService;
    readonly ILandUseService _landUseService;
    readonly ILandUseTypeService _landUseTypeService;
    readonly ILocalityService _localityService;
    readonly IPlotSizeService _plotSizeService;
    readonly IPropertyHeightService _propertyHeightService;
    readonly IPropertyTypeService _propertyTypeService;

    readonly IActivityService _activityService;
    readonly IActivityTypeService _activityTypeService;

    readonly IPropertyMasterService _propertyMasterService;


    /// <summary>
    /// Presentation controller constructor to handle dependency injection
    /// </summary>
    public PropertyController(IAllocationTypeService allocationTypeService, ILandUseService landUseService, ILandUseTypeService landUseTypeService, ILocalityService localityService, IPlotSizeService plotSizeService,
                              IApartmentTypeService apartmentTypeService, IFacilitiesService facilitiesService, IFloorNumberingService floorNumberingService, IPropertyTypeService propertyTypeService, IPropertyHeightService propertyHeightService,
                              IBlockNumberService blockNumberService, IBlockSideService blockSideService, IBlockTypeService blockTypeService, IBlockUnitService blockUnitService,
                              IActivityService activityService, IActivityTypeService activityTypeService, IPropertyMasterService propertyMasterService)
    {
        _allocationTypeService = allocationTypeService;
        _apartmentTypeService = apartmentTypeService;

        _blockNumberService = blockNumberService;
        _blockSideService = blockSideService;
        _blockTypeService = blockTypeService;
        _blockUnitService = blockUnitService;

        _facilitiesService = facilitiesService;
        _floorNumberingService = floorNumberingService;
        _landUseService = landUseService;
        _landUseTypeService = landUseTypeService;
        _localityService = localityService;
        _plotSizeService = plotSizeService;
        _propertyHeightService = propertyHeightService;
        _propertyTypeService = propertyTypeService;

        _activityService = activityService;
        _activityTypeService = activityTypeService;

        _propertyMasterService = propertyMasterService;
    }

    //--------------------ACTIVITY----------------
    /// <summary>
    /// Returns a list of activities
    /// </summary>
    [HttpGet]
    [Route("Setup/GetActivities")]
    public async Task<ActionResult<IEnumerable<ActivityReadDto>>> GetActivities()
    {
        return Ok(await _activityService.GetActivitiesAsync());
    }

    // POST: api/CreateActivity
    /// <summary>
    ///  Creates a new activity
    /// </summary>
    ///     
    /// <remarks>
    /// The various activities undertaken during the aquisition process
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateActivity
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityId": 0,
    ///         "activityName": "LETTERS",
    ///         "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Activity created successfully.",
    ///         "data": {
    ///             "activityId": 1,
    ///             "activityName": "LETTERS",
    ///             "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateActivity")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateActivity([FromBody] ActivityCreateDto values)
    {
        try
        {
            var result = await _activityService.CreateActivityAsync(values);

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
    ///  Updates the details of an existing activity
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing activity based on the activity id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateActivity
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityId": 1,
    ///         "activityName": "LETTERS",
    ///         "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Activity details modified successfully.",
    ///         "data": {
    ///             "activityId": 1,
    ///             "activityName": "LETTERS",
    ///             "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateActivity")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<ActivityReadDto>> UpdateActivity([FromBody] ActivityUpdateDto values)
    {
        var result = await _activityService.UpdateActivityAsync(values);

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
    /// Deletes an activity by its ID
    /// </summary>
    /// <param name="activityId">The ID of the activity to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteActivity/{activityId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteActivity(int activityId)
    {
        try
        {
            var result = await _activityService.DeleteActivity(activityId);

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

    //--------------------ACTIVITY TYPES----------------
    /// <summary>
    /// Returns a list of activity types types
    /// </summary>
    [HttpGet]
    [Route("GetActivityTypes")]
    public async Task<ActionResult<IEnumerable<ActivityTypeReadDto>>> GetActivityTypes()
    {
        return Ok(await _activityTypeService.GetActivityTypeAsync());
    }

    // POST: api/CreateActivity
    /// <summary>
    ///  Creates a new activity type
    /// </summary>
    ///     
    /// <remarks>
    /// The various activities types undertaken during the aquisition process
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateActivityType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityId": 1,
    ///         "activityTypeId": 0,
    ///         "activityTypeName": "OFFER LETTER",
    ///         "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS, SHOWING THE OFFER MADE TO THE APPLICANT",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Activity Type created successfully.",
    ///         "data": {
    ///             "activityTypeId": 1,
    ///             "activityTypeName": "OFFER LETTER",
    ///             "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateActivityType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateActivityType([FromBody] ActivityTypeCreateDto values)
    {
        try
        {
            var result = await _activityTypeService.CreateActivityTypeAsync(values);

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
    ///  Updates the details of an existing activity type
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing activity type based on the activity type id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateActivityType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "activityTypeId": 1,
    ///         "activityTypeName": "OFFER LETTER",
    ///         "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Activity Type details modified successfully.",
    ///         "data": {
    ///             "activityTypeId": 1,
    ///             "activityTypeName": "OFFER LETTER",
    ///             "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateActivityType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<ActivityTypeReadDto>> UpdateActivityType([FromBody] ActivityTypeUpdateDto values)
    {
        var result = await _activityTypeService.UpdateActivityTypeAsync(values);

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
    /// Deletes an activity type by its ID
    /// </summary>
    /// <param name="activityTypeId">The ID of the activity type to delete</param>
    /// <returns>Success or error response</returns>
    [HttpDelete("DeleteActivityType/{activityTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteActivityType(int activityTypeId)
    {
        try
        {
            var result = await _activityTypeService.DeleteActivityType(activityTypeId);

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


    //-------------------ALLOCATION TYPE-----------------
    // GET: api/Setup/GetAllocationType
    /// <summary>
    /// Returns a list of land allocation types
    /// </summary>
    ///
    /// <remarks>
    /// The allocation type indicates whether the property is a TDC direct allocation or a release to the traditional councils, large scale allocations and regularizations.
    /// </remarks>
    /// <returns></returns>
    [HttpGet]
    [Route("Setup/GetAllocationType")]
    public async Task<ActionResult<IEnumerable<AllocationTypeReadDto>>> GetAllocationType()
    {
        return Ok(await _allocationTypeService.GetAllocationTypeAsync());
    }

    [HttpGet]
    [Route("Setup/GetAllocationType/{allocationType}")]
    public async Task<ActionResult<AllocationTypeReadDto>> GetAllocationType(string allocationType)
    {
        return Ok(await _allocationTypeService.GetAllocationTypeAsync(allocationType));
    }

    [HttpGet]
    [Route("Setup/GetAllocationTypeById/{allocationTypeId}")]
    public async Task<ActionResult<AllocationTypeReadDto>> GetAllocationTypeById(int allocationTypeId)
    {
        return Ok(await _allocationTypeService.GetAllocationTypeAsync(allocationTypeId));
    }

    // POST: api/CreateAllocationType
    /// <summary>
    ///  Creates a new allocation type
    /// </summary>
    ///     
    /// <remarks>
    /// The allocation type indicates whether the property is a TDC direct allocation or a release to the traditional councils, large scale allocations and regularizations.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateAllocationType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "allocationTypeId": 0,
    ///         "allocationTypeInitial": "KTC",
    ///         "allocationTypes": "KPONE TRADTIONAL COUNCIL",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Allocation Type created successfully.",
    ///         "data": {
    ///             "allocationTypeId": 1,
    ///             "allocationTypeInitial": "KTC",
    ///             "allocationTypes": "KPONE TRADTIONAL COUNCIL"
    ///         }
    ///     }
    /// 
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
            var result = await _allocationTypeService.CreateAllocationTypeAsync(values);

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
    ///  Updates the details of an existing allocation type
    /// </summary>
    ///
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
    ///         "allocationTypeInitial": "KTC",
    ///         "allocationTypes": "KPONE TRADTIONAL COUNCIL",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Allocation Type details modified successfully.",
    ///         "data": {
    ///             "allocationTypeId": 1,
    ///             "allocationTypeInitial": "KTC",
    ///             "allocationTypes": "KPONE TRADTIONAL COUNCIL"
    ///         }
    ///     }
    /// 
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
        var result = await _allocationTypeService.UpdateAllocationTypeAsync(values);

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
            var result = await _allocationTypeService.DeleteAllocationType(allocationTypeId);

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

    //-------------------APARTMENT TYPE-----------------
    /// <summary>
    /// Returns a list of apartment types
    /// </summary>
    [HttpGet]
    [Route("Setup/GetApartmentType")]
    public async Task<ActionResult<IEnumerable<ApartmentTypeReadDto>>> GetApartmentType()
    {
        return Ok(await _apartmentTypeService.GetApartmentTypeAsync());
    }

    [HttpGet]
    [Route("Setup/GetApartmentType/{apartmentType}")]
    public async Task<ActionResult<AllocationTypeReadDto>> GetApartmentType(string apartmentType)
    {
        return Ok(await _apartmentTypeService.GetApartmentTypeAsync(apartmentType));
    }

    [HttpGet]
    [Route("Setup/GetApartmentTypeById/{apartmentTypeId}")]
    public async Task<ActionResult<AllocationTypeReadDto>> GetApartmentTypeById(int apartmentTypeId)
    {
        return Ok(await _apartmentTypeService.GetApartmentTypeAsync(apartmentTypeId));
    }

    // POST: api/CreateApartmentType
    /// <summary>
    ///  Creates a new apartment type
    /// </summary>
    ///     
    /// <remarks>
    /// Indicates the various types of apartments on sale.
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
    ///         "sellingPrice": 8000,
    ///         "currencyId": 1,
    ///         "floorArea": 48.21,
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Apartment Type created successfully.",
    ///         "data": {
    ///             "apartmentTypeId": 1,
    ///             "apartmentType": "STUDIO",
    ///             "sellingPrice": 8000,
    ///             "currencyId": 1,
    ///             "floorArea": 48.21
    ///         }
    ///     }
    /// 
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an existing apartment type
    /// </summary>
    ///
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
    ///         "sellingPrice": 8000,
    ///         "currencyId": 1,
    ///         "floorArea": 48.21,
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Apartment Type details modified successfully.",
    ///         "data": {
    ///             "apartmentTypeId": 1,
    ///             "apartmentType": "STUDIO",
    ///             "sellingPrice": 8000,
    ///             "currencyId": 1,
    ///             "floorArea": 48.21
    ///         }
    ///     }
    /// 
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
    public async Task<ActionResult> DeleteApartmentType(int apartmentTypeId)
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    //--------------------BLOCK NUMBER----------------
    /// <summary>
    /// Returns a list of exisiting block numbers
    /// </summary>
    [HttpGet]
    [Route("Setup/GetBlockNumber")]
    public async Task<ActionResult<IEnumerable<BlockNumberReadDto>>> GetBlockNumber()
    {
        return Ok(await _blockNumberService.GetBlockNumberAsync());
    }

    // POST: api/CreateBlockNumber
    /// <summary>
    ///  Creates a new block
    /// </summary>
    ///     
    /// <remarks>
    /// Alpha numeric indicating the block number of the property/plot
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockNumberId": 0,
    ///         "blockNumbers": "A",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block Number created successfully.",
    ///         "data": {
    ///             "blockNumberId": 1,
    ///             "blockNumbers": "A"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockNumber")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockNumber([FromBody] BlockNumberCreateDto values)
    {
        try
        {
            var result = await _blockNumberService.CreateBlockNumberAsync(values);

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
    ///  Updates the details of an existing block number
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing block number based on the block number id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockNumberId": 1,
    ///         "blockNumbers": "A",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block Number details modified successfully.",
    ///         "data": {
    ///             "blockNumberId": 1,
    ///             "blockNumbers": "A"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockNumber")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockNumberReadDto>> UpdateBlockNumber([FromBody] BlockNumberUpdateDto values)
    {
        var result = await _blockNumberService.UpdateBlockNumberAsync(values);

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
    // DELETE api/values/5
    [HttpDelete("DeleteBlockNumber/{blockNumberId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockNumber(int blockNumberId)
    {
        try
        {
            var result = await _blockNumberService.DeleteBlockNumber(blockNumberId);

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

    //--------------------BLOCK SIDE----------------
    /// <summary>
    /// Returns a list of exisiting block sides
    /// </summary>
    [HttpGet]
    [Route("Setup/GetBlockSides")]
    public async Task<ActionResult<IEnumerable<BlockSideReadDto>>> GetBlockSides()
    {
        return Ok(await _blockSideService.GetBlockSideAsync());
    }

    // POST: api/CreateBlockSide
    /// <summary>
    ///  Creates a new block
    /// </summary>
    ///     
    /// <remarks>
    /// Indicating the side on the block where the property/plot can be located.
    /// Either the left side or right side.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockSide
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "sideId": 0,
    ///         "side": "LEFT",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block Side created successfully.",
    ///         "data": {
    ///             "sideId": 1,
    ///             "side": "LEFT"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockSide")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockSide([FromBody] BlockSideCreateDto values)
    {
        try
        {
            var result = await _blockSideService.CreateBlockSideAsync(values);

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
    ///  Updates the details of an existing block side
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing block side based on the block side id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockSide
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "sideId": 1,
    ///         "side": "LEFT",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block Side details modified successfully.",
    ///         "data": {
    ///             "sideId": 1,
    ///             "side": "LEFT"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockSide")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockSideReadDto>> UpdateBlockSide([FromBody] BlockSideUpdateDto values)
    {
        var result = await _blockSideService.UpdateBlockSideAsync(values);

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
    // DELETE api/values/5
    [HttpDelete("DeleteBlockSide/{blockSideId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockSide(int blockSideId)
    {
        try
        {
            var result = await _blockSideService.DeleteBlockSide(blockSideId);

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


    //--------------------BLOCK TYPE----------------
    /// <summary>
    /// Returns a list of exisiting block types
    /// </summary>
    [HttpGet]
    [Route("Setup/GetBlockTypes")]
    public async Task<ActionResult<IEnumerable<BlockTypeReadDto>>> GetBlockTypes()
    {
        return Ok(await _blockTypeService.GetBlockTypeAsync());
    }

    // POST: api/CreateBlockType
    /// <summary>
    ///  Creates a new block type
    /// </summary>
    ///     
    /// <remarks>
    /// Indicating the block type, be it a single or twin block.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockTypeId": 0,
    ///         "blockType": "SINGLE",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block Type created successfully.",
    ///         "data": {
    ///             "blockTypeId": 1,
    ///             "blockType": "SINGLE"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockType([FromBody] BlockTypeCreateDto values)
    {
        try
        {
            var result = await _blockTypeService.CreateBlockTypeAsync(values);

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
    ///  Updates the details of an existing block type
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing block type based on the block type id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "blockTypeId": 1,
    ///         "blockType": "SINGLE",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block Type details modified successfully.",
    ///         "data": {
    ///             "blockTypeId": 1,
    ///             "blockType": "SINGLE"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockTypeReadDto>> UpdateBlockType([FromBody] BlockTypeUpdateDto values)
    {
        var result = await _blockTypeService.UpdateBlockTypeAsync(values);

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
    // DELETE api/values/5
    [HttpDelete("DeleteBlockType/{blockTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockType(int blockTypeId)
    {
        try
        {
            var result = await _blockTypeService.DeleteBlockType(blockTypeId);

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

    //--------------------BLOCK UNIT----------------
    /// <summary>
    /// Returns a list of exisiting block units
    /// </summary>
    [HttpGet]
    [Route("Setup/GetBlockUnits")]
    public async Task<ActionResult<IEnumerable<BlockUnitReadDto>>> GetBlockUnits()
    {
        return Ok(await _blockUnitService.GetBlockUnitAsync());
    }

    // POST: api/CreateBlockUnit
    /// <summary>
    ///  Creates a new block unit
    /// </summary>
    ///     
    /// <remarks>
    /// Indicating the block unit.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateBlockUnit
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "unitId": 0,
    ///         "unit": "A1",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Block Unit created successfully.",
    ///         "data": {
    ///             "unitId": 1,
    ///             "unit": "A1"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockUnit")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateBlockUnit([FromBody] BlockUnitCreateDto values)
    {
        try
        {
            var result = await _blockUnitService.CreateBlockUnitAsync(values);

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
    ///  Updates the details of an existing block unit
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing block unit based on the block unit id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateBlockUnit
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "unitId": 1,
    ///         "unit": "A1",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Block Unit details modified successfully.",
    ///         "data": {
    ///             "unitId": 1,
    ///             "unit": "A1"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateBlockUnit")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<BlockUnitReadDto>> UpdateBlockUnit([FromBody] BlockUnitUpdateDto values)
    {
        var result = await _blockUnitService.UpdateBlockUnitAsync(values);

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
    // DELETE api/values/5
    [HttpDelete("DeleteBlockUnit/{blockUnitId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteBlockUnit(int blockUnitId)
    {
        try
        {
            var result = await _blockUnitService.DeleteBlockUnit(blockUnitId);

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

    //--------------------FACILITIES----------------
    /// <summary>
    /// Returns a list of facilities under management
    /// </summary>
    [HttpGet]
    [Route("Setup/GetFacilities")]
    public async Task<ActionResult<IEnumerable<FacilitiesReadDto>>> GetFacilities()
    {
        return Ok(await _facilitiesService.GetFacilitiesAsync());
    }

    // POST: api/CreateFacility
    /// <summary>
    ///  Creates a new facility
    /// </summary>
    ///     
    /// <remarks>
    /// Indicating the facilities under management.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateFacility
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "facilityId": 0,
    ///         "facility": "SWIMMING POOL",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Facility created successfully.",
    ///         "data": {
    ///             "facilityId": 1,
    ///             "facility": "SWIMMING POOL"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateFacility")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateFacility([FromBody] FacilitiesCreateDto values)
    {
        try
        {
            var result = await _facilitiesService.CreateFacilitiesAsync(values);

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
    ///  Updates the details of an existing facility
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing facility based on the facility id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateFacility
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "facilityId": 1,
    ///         "facility": "SWIMMING POOL",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Facility details modified successfully.",
    ///         "data": {
    ///             "facilityId": 1,
    ///             "facility": "SWIMMING POOL"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateFacility")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<FacilitiesReadDto>> UpdateFacility([FromBody] FacilitiesUpdateDto values)
    {
        var result = await _facilitiesService.UpdateFacilitiesAsync(values);

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
    // DELETE api/values/5
    [HttpDelete("DeleteFacility/{facilityId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteFacility(int facilityId)
    {
        try
        {
            var result = await _facilitiesService.DeleteFacilities(facilityId);

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

    //--------------------FLOOR NUMBERING----------------
    /// <summary>
    /// Returns a list of exisiting floor numbers
    /// </summary>
    [HttpGet]
    [Route("Setup/GetFloorNumbering")]
    public async Task<ActionResult<IEnumerable<FloorNumberingReadDto>>> GetFloorNumbering()
    {
        return Ok(await _floorNumberingService.GetFloorNumberingAsync());
    }

    // POST: api/CreateFloorNumber
    /// <summary>
    ///  Creates a new floor number
    /// </summary>
    ///     
    /// <remarks>
    /// Indicating the various floors available in a block.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateFloorNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "floorNumberId": 0,
    ///         "floorNumber": "GROUND FLOOR",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Floor Number created successfully.",
    ///         "data": {
    ///             "floorNumberId": 1,
    ///             "floorNumber": "GROUND FLOOR"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreateFloorNumber")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreateFloorNumber([FromBody] FloorNumberingCreateDto values)
    {
        try
        {
            var result = await _floorNumberingService.CreateFloorNumberingAsync(values);

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
    ///  Updates the details of an existing floor number
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing floor number based on the floor number id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateFloorNumber
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "floorNumberId": 1,
    ///         "floorNumber": "GROUND FLOOR",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Floor Number details modified successfully.",
    ///         "data": {
    ///             "floorNumberId": 1,
    ///             "floorNumber": "GROUND FLOOR"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdateFloorNumber")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<FloorNumberingReadDto>> UpdateFloorNumber([FromBody] FloorNumberingUpdateDto values)
    {
        var result = await _floorNumberingService.UpdateFloorNumberingAsync(values);

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
    // DELETE api/values/5
    [HttpDelete("DeleteFloorNumber/{floorNumberId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteFloorNumber(int floorNumberId)
    {
        try
        {
            var result = await _floorNumberingService.DeleteFloorNumbering(floorNumberId);

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

    //--------------------LANDUSE----------------
    /// <summary>
    /// Returns a list of exisiting land uses
    /// </summary>
    [HttpGet]
    [Route("Setup/GetLandUse")]
    public async Task<ActionResult<IEnumerable<LandUseReadDto>>> GetLandUse()
    {
        return Ok(await _landUseService.GetLandUseAsync());
    }

    [HttpGet]
    [Route("Setup/GetLandUse/{landUse}")]
    public async Task<ActionResult<LandUseReadDto>> GetLandUse(string landUse)
    {
        return Ok(await _landUseService.GetLandUseAsync(landUse));
    }

    [HttpGet]
    [Route("Setup/GetLandUseById/{landUseId}")]
    public async Task<ActionResult<LandUseReadDto>> GetLandUseById(int landUseId)
    {
        return Ok(await _landUseService.GetLandUseAsync(landUseId));
    }

    // POST: api/CreateLandUse
    /// <summary>
    ///  Creates a new land use
    /// </summary>
    ///     
    /// <remarks>
    /// The landuse indicates what the plot/property would be used for.
    /// Maximum of three characters to represent initials of the land use
    ///
    /// **Sample Request:**
    ///
    ///     POST /UpdateLandUse
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "landUseInitial": "RPL",
    ///         "landUseName": "RESIDENTIAL",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Land Use details created successfully.",
    ///         "data": {
    ///                     "landUseId": 14,
    ///                     "landUseInitial": "RPL",
    ///                     "landUseName": "RESIDENTIAL"
    ///                 }
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The land use details to be added or created</param>
    /// <returns></returns>
    [HttpPost]
    [Route("CreateLandUse")]
    //[Authorize(Policy = "Permission:Customers.CREATE")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]

    public async Task<ActionResult> CreateLandUse([FromBody] LandUseCreateDto values)
    {
        try
        {
            //var userId = _userContextService.GetUserId();
            //if (!string.Equals(userId, values.CreatedBy))
            //{
            //    return Unauthorized();
            //}

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
    ///  Updates the details of an exsiting land use
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing landuse based on the landuse id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdateLandUse
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "landUseId": 14,
    ///         "landUseInitial": "PPL",
    ///         "landUseName": "RESIDENTIALS",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Land Use details modified successfully.",
    ///         "data": {
    ///                     "landUseId": 14,
    ///                     "landUseInitial": "PPL",
    ///                     "landUseName": "RESIDENTIALS"
    ///                 }
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The land use details to be added or created</param>
    /// <returns></returns>
    [HttpPut]
    [Route("UpdateLandUse")]
    //[Authorize(Policy = "Permission:Customers.UPDATE")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<LandUseReadDto>> UpdateLandUse([FromBody] LandUseUpdateDto values)
    {
        //var userId = _userContextService.GetUserId();
        //if (!string.Equals(userId, values.CreatedBy))
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

    // DELETE api/values/5
    [HttpDelete("DeleteLandUse/{landUseId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteLandUse(int landUseId)
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

    //-------------------LANDUSE TYPE-----------------
    /// <summary>
    /// Returns a list of exisiting land use types
    /// </summary>
    [HttpGet]
    [Route("Setup/GetLandUseType")]
    public async Task<ActionResult<IEnumerable<LandUseTypeReadDto>>> GetLandUseType()
    {
        return Ok(await _landUseTypeService.GetLandUseTypeAsync());
    }

    [HttpGet]
    [Route("Setup/GetLandUseType/{landUse}")]
    public async Task<ActionResult<LandUseTypeReadDto>> GetLandUseType(string landUse)
    {
        return Ok(await _landUseTypeService.GetLandUseTypeAsync(landUse));
    }

    [HttpGet]
    [Route("Setup/GetLandUseTypeById/{landUseTypeId}")]
    public async Task<ActionResult<LandUseReadDto>> GetLandUseTypeById(int landUseId)
    {
        return Ok(await _landUseTypeService.GetLandUseTypeAsync(landUseId));
    }

    // POST: api/CreateLandUseType
    /// <summary>
    ///  Creates a new land use type
    /// </summary>
    ///     
    /// <remarks>
    /// The land use type indicates the sub category the plot/property use falls under.
    /// Maximum of three characters to represent names of the land use type.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateLandUseType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "landUseId": 1,
    ///         "landUseTypeId": 0,
    ///         "landUseTypeInitial": "HOS",
    ///         "landUseTypeName": "TDC Built Houses(HOS)",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Land Use Type created successfully.",
    ///         "data": {
    ///             "landUseTypeId": 1,
    ///             "landUseTypeInitial": "HOS",
    ///             "landUseTypeName": "TDC Built Houses(HOS)"
    ///         }
    ///     }
    /// 
    /// </remarks>
    /// 
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
    ///  Updates the details of an existing land use type
    /// </summary>
    ///
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
    ///         "landUseTypeInitial": "HOS",
    ///         "landUseTypeName": "TDC Built Houses(HOS)",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Land Use Type details modified successfully.",
    ///         "data": {
    ///             "landUseTypeId": 1,
    ///             "landUseTypeInitial": "HOS",
    ///             "landUseTypeName": "TDC Built Houses(HOS)"
    ///         }
    ///     }
    /// 
    /// </remarks>
    /// <param name="values">The land use details to be added or created</param>
    /// <returns></returns>
    [HttpPut]
    [Route("UpdateLandUseType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<LandUseReadDto>> UpdateLandUseType([FromBody] LandUseTypeUpdateDto values)
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

    [HttpDelete("DeleteLandUseType/{landUseTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteLandUseType(int landUseTypeId)
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

    //----------------------LOCALITY------------
    /// <summary>
    /// Returns a list of exisiting localities
    /// </summary>
    [HttpGet]
    [Route("Setup/GetLocality")]
    public async Task<ActionResult<IEnumerable<LocalityReadDto>>> GeLocality()
    {
        return Ok(await _localityService.GetLocalityAsync());
    }

    [HttpGet]
    [Route("Setup/GetLocality/{value}")]
    public async Task<ActionResult<LocalityReadDto>> GetLocality(string value)
    {
        return Ok(await _localityService.GetLocalityAsync(value));
    }

    [HttpGet]
    [Route("Setup/GetLocalityById/{localityId}")]
    public async Task<ActionResult<LocalityReadDto>> GetLocalityById(int localityId)
    {
        return Ok(await _localityService.GetLocalityAsync(localityId));
    }

    // POST: api/CreateLocality
    /// <summary>
    ///  Creates a new locality or community
    /// </summary>
    ///     
    /// <remarks>
    /// The locality or community indicates the area where the property/plot can be located.
    /// An abbreviation of the locality. Maximum of three characters to represent the name of the area.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreateLocality
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "localityId": 1,
    ///         "localityInitial": "ASH",
    ///         "localityName": "ASHIAMAN",
    ///         "customerCode": "2W",
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
    ///             "localityInitial": "ASH",
    ///             "localityName": "ASHIAMAN",
    ///             "customerCode": "2W"
    ///         }
    ///     }
    /// 
    /// </remarks>
    /// 
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an existing locality
    /// </summary>
    ///
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
    ///         "localityInitial": "ASH",
    ///         "localityName": "ASHIAMAN",
    ///         "customerCode": "2W",
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
    ///             "localityInitial": "ASH",
    ///             "localityName": "ASHIAMAN",
    ///             "customerCode": "2W"
    ///         }
    ///     }
    /// 
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

    [HttpDelete("DeleteLocality/{localityId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeleteLocality(int localityId)
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    //----------------------PLOT SIZE------------
    /// <summary>
    /// Returns a list of exisiting plot sizes
    /// </summary>
    [HttpGet]
    [Route("Setup/GetPlotSize")]
    public async Task<ActionResult<IEnumerable<PlotSizeReadDto>>> GetPlotSize()
    {
        return Ok(await _plotSizeService.GetPlotSizeAsync());
    }

    [HttpGet]
    [Route("Setup/GetPlotSize/{value}")]
    public async Task<ActionResult<PlotSizeReadDto>> GetPlotSize(string value)
    {
        return Ok(await _plotSizeService.GetPlotSizeAsync(value));
    }

    [HttpGet]
    [Route("Setup/GetPlotSizeById/{plotSizeId}")]
    public async Task<ActionResult<PlotSizeReadDto>> GetPlotSizeById(int plotSizeId)
    {
        return Ok(await _plotSizeService.GetPlotSizeAsync(plotSizeId));
    }

    // POST: api/CreatePlotSize
    /// <summary>
    ///  Creates a new plot size
    /// </summary>
    ///     
    /// <remarks>
    /// The plot size indicates the length and breadth of the property/plot.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreatePlotSize
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "plotSizeId": 0,
    ///         "plotSizes": "70x100",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Plot Size created successfully.",
    ///         "data": {
    ///             "plotSizeId": 1,
    ///             "plotSizes": "70x100"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreatePlotSize")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreatePlotSize([FromBody] PlotSizeCreateDto values)
    {
        try
        {
            var result = await _plotSizeService.CreatePlotSizeAsync(values);

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
    ///  Updates the details of an existing plot size
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing plot size based on the plot size id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdatePlotSize
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "plotSizeId": 1,
    ///         "plotSizes": "70x100",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Plot Size details modified successfully.",
    ///         "data": {
    ///             "plotSizeId": 1,
    ///             "plotSizes": "70x100"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdatePlotSize")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<PlotSizeReadDto>> UpdatePlotSize([FromBody] PlotSizeUpdateDto values)
    {
        var result = await _plotSizeService.UpdatePlotSizeAsync(values);

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

    [HttpDelete("DeletePlotSize/{plotSizeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeletePlotSize(int plotSizeId)
    {
        try
        {
            var result = await _plotSizeService.DeletePlotSize(plotSizeId);

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

    //----------------------PROPERTY HEIGHT------------
    /// <summary>
    /// Returns a list of exisiting property heights
    /// </summary>
    [HttpGet]
    [Route("Setup/GetPropertyHeight")]
    public async Task<ActionResult<IEnumerable<PropertyHeightReadDto>>> GetPropertyHeight()
    {
        return Ok(await _propertyHeightService.GetPropertyHeightAsync());
    }

    // POST: api/CreatePropertyHeight
    /// <summary>
    ///  Creates a new property height
    /// </summary>
    ///     
    /// <remarks>
    /// The property height indicates the acceptable zoning height of the property/plot for a locality.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreatePropertyHeight
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "propertyHeightId": 0,
    ///         "propertyHeights": "SINGLE STOREY",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Property Height created successfully.",
    ///         "data": {
    ///             "propertyHeightId": 1,
    ///             "propertyHeights": "SINGLE STOREY"
    ///         }
    ///     }
    /// 
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an existing property height
    /// </summary>
    ///
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
    ///         "propertyHeights": "SINGLE STOREY",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Property Height details modified successfully.",
    ///         "data": {
    ///             "propertyHeightId": 1,
    ///             "propertyHeights": "SINGLE STOREY"
    ///         }
    ///     }
    /// 
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

    [HttpDelete("DeletePropertyHeight/{propertyHeightId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeletePropertyHeight(int propertyHeightId)
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
            return StatusCode(StatusCodes.Status500InternalServerError, ex.InnerException!.Message);
        }
    }

    //----------------------PROPERTY TYPE------------
    /// <summary>
    /// Returns a list of exisiting property types
    /// </summary>
    [HttpGet]
    [Route("Setup/GetPropertyType")]
    public async Task<ActionResult<IEnumerable<PropertyTypeReadDto>>> GetPropertyType()
    {
        return Ok(await _propertyTypeService.GetPropertyTypeAsync());
    }

    [HttpGet]
    [Route("Setup/GetPropertyType/{value}")]
    public async Task<ActionResult<PropertyTypeReadDto>> GetPropertyType(string value)
    {
        return Ok(await _propertyTypeService.GetPropertyTypeAsync(value));
    }

    [HttpGet]
    [Route("Setup/GetPropertyTypeById/{propertyTypeId}")]
    public async Task<ActionResult<PropertyTypeReadDto>> GetPropertyTypeById(int propertyTypeId)
    {
        return Ok(await _propertyTypeService.GetPropertyTypeAsync(propertyTypeId));
    }

    // POST: api/CreatePropertyType
    /// <summary>
    ///  Creates a new property type
    /// </summary>
    ///     
    /// <remarks>
    /// The property types indicates whether the property/plot is a serviced plot or a rental house.
    ///
    /// **Sample Request:**
    ///
    ///     POST /CreatePropertyType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "propertyTypeId": 0,
    ///         "propertyTypes": "PARTIALLY-SERVICES PLOTS",
    ///         "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 201:**
    /// 
    ///     {
    ///         "code": 201,
    ///         "message": "Property Type created successfully.",
    ///         "data": {
    ///             "propertyTypeId": 1,
    ///             "propertyTypes": "PARTIALLY-SERVICES PLOTS"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPost]
    [Route("CreatePropertyType")]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> CreatePropertyType([FromBody] PropertyTypeCreateDto values)
    {
        try
        {
            var result = await _propertyTypeService.CreatePropertyTypeAsync(values);

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
    ///  Updates the details of an existing property type
    /// </summary>
    ///
    /// <remarks>
    /// Modifies/updates an existing property type based on the property type id 
    ///
    /// **Sample Request:**
    ///
    ///     PUT /UpdatePropertyType
    ///
    /// **Sample Request Body:**
    /// 
    ///     {
    ///         "propertyTypeId": 1,
    ///         "propertyTypes": "PARTIALLY-SERVICES PLOTS",
    ///         "modifiedBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    ///     }
    ///
    /// **Sample Response 200:**
    /// 
    ///     {
    ///         "code": 200,
    ///         "message": "Property Type details modified successfully.",
    ///         "data": {
    ///             "propertyTypeId": 1,
    ///             "propertyTypes": "PARTIALLY-SERVICES PLOTS"
    ///         }
    ///     }
    /// 
    /// </remarks>
    [HttpPut]
    [Route("UpdatePropertyType")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status204NoContent, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult<PropertyTypeReadDto>> UpdatePropertyType([FromBody] PropertyTypeUpdateDto values)
    {
        var result = await _propertyTypeService.UpdatePropertyTypeAsync(values);

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

    [HttpDelete("DeletePropertyType/{propertyTypeId}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SuccessResponseDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorResponseDto))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorResponseDto))]
    public async Task<ActionResult> DeletePropertyType(int propertyTypeId)
    {
        try
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

}

