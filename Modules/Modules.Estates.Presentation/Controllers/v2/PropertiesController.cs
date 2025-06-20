// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers.v2;

[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[Produces("application/json")]
public class PropertyController : ControllerBase
{
    public readonly IAllocationTypeService _allocationTypeService;
    public readonly IApartmentTypeService _apartmentTypeService;

    readonly IBlockNumberService _blockNumberService;
    readonly IBlockSideService _blockSideService;
    readonly IBlockTypeService _blockTypeService;
    readonly IBlockUnitService _blockUnitService;

    readonly IFloorAreaService _floorAreaService;
    readonly IFloorNumberingService _floorNumberingService;
    readonly ILandUseService _landUseService;
    readonly ILandUseTypeService _landUseTypeService;
    readonly ILocalityService _localityService;
    readonly IPlotDimensionService _plotDimensionService;
    readonly IPropertyHeightService _propertyHeightService;
    readonly IPlotTypeService _plotTypeService;

    readonly IActivityService _activityService;
    readonly IActivityTypeService _activityTypeService;

    readonly IPropertyMasterService _propertyMasterService;



    public PropertyController(IAllocationTypeService allocationTypeService, ILandUseService landUseService, ILandUseTypeService landUseTypeService, ILocalityService localityService, IPlotDimensionService plotDimensionService,
                              IApartmentTypeService apartmentTypeService, IFloorAreaService floorAreaService, IFloorNumberingService floorNumberingService, IPlotTypeService plotTypeService, IPropertyHeightService propertyHeightService,
                              IBlockNumberService blockNumberService, IBlockSideService blockSideService, IBlockTypeService blockTypeService, IBlockUnitService blockUnitService,
                              IActivityService activityService, IActivityTypeService activityTypeService, IPropertyMasterService propertyMasterService)
    {
        _allocationTypeService = allocationTypeService;
        _apartmentTypeService = apartmentTypeService;

        _blockNumberService = blockNumberService;
        _blockSideService = blockSideService;
        _blockTypeService = blockTypeService;
        _blockUnitService = blockUnitService;

        _floorAreaService = floorAreaService;
        _floorNumberingService = floorNumberingService;
        _landUseService = landUseService;
        _landUseTypeService = landUseTypeService;
        _localityService = localityService;
        _plotDimensionService = plotDimensionService;
        _propertyHeightService = propertyHeightService;
        _plotTypeService = plotTypeService;

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
    /// Sample Request:
    ///
    /// POST /CreateActivity
    /// 
    /// {
    ///    "activityId": 0,
    ///    "activityName": "LETTERS",
    ///    "activityDescription": "VARIOUS LETTERS REQUIRED IN THE ACQUISITION PROCESS",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    /// <param name="values"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("CreateActivity")]
    public async Task<ActionResult<ActivityReadDto>> CreateActivity([FromBody] ActivityCreateDto values)
    {
        try
        {
            return Ok(await _activityService.CreateActivityAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting activity
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateActivity")]
    public async Task<ActionResult<ActivityReadDto>> UpdateActivity([FromBody] ActivityUpdateDto values)
    {
        return Ok(await _activityService.UpdateActivityAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteActivity/{activityId}")]
    public void DeleteActivity(int activityId)
    {
    }

    //--------------------ACTIVITY TYPES----------------
    /// <summary>
    /// Returns a list of activity types types
    /// </summary>
    [HttpGet]
    [Route("Setup/GetActivityTypes")]
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
    /// Sample Request:
    ///
    /// POST /CreateActivity
    /// 
    /// {
    ///    "activityId": 1,
    ///    "activityTypeId": 0,
    ///    "activityTypeName": "OFFER LETTER",
    ///    "activityTypeDescription": "A LETTER REQUIRED IN THE ACQUISITION PROCESS, SHOWING THE OFFER MADE TO THE APPLICANT",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    /// <param name="values"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("CreateActivityType")]
    public async Task<ActionResult<ActivityTypeReadDto>> CreateActivityType([FromBody] ActivityTypeCreateDto values)
    {
        try
        {
            return Ok(await _activityTypeService.CreateActivityTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting activity type
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateActivityType")]
    public async Task<ActionResult<ActivityTypeReadDto>> UpdateActivityType([FromBody] ActivityTypeUpdateDto values)
    {
        return Ok(await _activityTypeService.UpdateActivityTypeAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteActivityType/{activityTypeId}")]
    public void DeleteActivityType(int activityTypeId)
    {
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
    /// The allocation type indicates whether the property is a TDC direct allocation or a release to the traditional councils, large scale allocations and regularizations. <br/>
    /// Maximum of three characters to represent names of the traditional councils
    ///
    /// Sample Request:
    ///
    /// POST /CreateAllocationType
    /// 
    /// {
    ///    "allocationTypeId": 0,
    ///    "allocationTypeInitial": "KTC",
    ///    "allocationTypes": "KPONE TRADTIONAL COUNCIL",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    /// <param name="values"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("CreateAllocationType")]
    public async Task<ActionResult<AllocationTypeReadDto>> CreateAllocationType([FromBody] AllocationTypeCreateDto values)
    {
        try
        {
            return Ok(await _allocationTypeService.CreateAllocationTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { detail = ex.Message });
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting allocation type
    /// </summary>
    ///     
    [HttpPut]
    [Route("UpdateAllocationType")]
    public async Task<ActionResult<AllocationTypeReadDto>> UpdateAllocationType([FromBody] AllocationTypeUpdateDto values)
    {
        return Ok(await _allocationTypeService.UpdateAllocationTypeAsync(values));
    }

    [HttpDelete("DeleteAllocationType/{allocationTypeId}")]
    public void DeleteAllocationType(int allocationTypeId)
    {
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
    /// Sample Request:
    ///
    /// POST /CreateApartmentType
    /// 
    /// {
    ///    "apartmentTypeId": 0,
    ///    "apartmentType": "STUDIO",
    ///    "sellingPrice": 8,000,
    ///    "currencyId": 1,
    ///    "floorArea": 48.21,
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    /// <param name="values"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("CreateApartmentType")]
    public async Task<ActionResult<ApartmentTypeReadDto>> AddApartmentType([FromBody] ApartmentTypeCreateDto values)
    {
        try
        {
            var resut = await _apartmentTypeService.CreateApartmentTypeAsync(values);
            if(resut.IsSuccess == true)
            {
                return StatusCode(StatusCodes.Status201Created, new { code = resut.SuccessResponse!.Code, message = resut.SuccessResponse!.Message });
            }

            if(resut.ErrorResponse!.Code == 400)
            {
                return BadRequest(resut.ErrorResponse);
            }
            
            return StatusCode(StatusCodes.Status500InternalServerError, new { code = resut.ErrorResponse!.Code, message = resut.ErrorResponse!.Message });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting apartment type
    /// </summary>
    [HttpPut]
    [Route("UpdateApartmentType")]
    public async Task<ActionResult<ApartmentTypeReadDto>> UpdateApartmentType([FromBody] ApartmentTypeUpdateDto values)
    {
        return Ok(await _apartmentTypeService.UpdateApartmentTypeAsync(values));
    }

    [HttpDelete("DeleteApartmentType/{apartmentTypeId}")]
    public void DeleteApartmentType(int apartmentTypeId)
    {
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
    /// Sample Request:
    ///
    /// POST /CreateBlockNumber
    /// 
    /// {
    ///    "blockNumberId": 0,
    ///    "blockNumbers": "A",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockNumber")]
    public async Task<ActionResult<BlockNumberReadDto>> AddBlockNumber([FromBody] BlockNumberCreateDto values)
    {
        try
        {
            return Ok(await _blockNumberService.CreateBlockNumberAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting block number
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateBlockNumber")]
    public async Task<ActionResult<BlockNumberReadDto>> UpdateBlockNumber([FromBody] BlockNumberUpdateDto values)
    {
        return Ok(await _blockNumberService.UpdateBlockNumberAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteBlockNumber/{facilityId}")]
    public void DeleteBlockNumber(int facilityId)
    {
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
    /// Indicating the side on the block where the property/plot can be located.<br/>
    /// Eithe the left side or right side.
    ///
    /// Sample Request:
    ///
    /// POST /CreateBlockSide
    /// 
    /// {
    ///    "sideId": 0,
    ///    "side": "LEFT",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockSide")]
    public async Task<ActionResult<BlockSideReadDto>> AddBlockSide([FromBody] BlockSideCreateDto values)
    {
        try
        {
            return Ok(await _blockSideService.CreateBlockSideAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting block side
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateBlockSide")]
    public async Task<ActionResult<BlockSideReadDto>> UpdateBlockSide([FromBody] BlockSideUpdateDto values)
    {
        return Ok(await _blockSideService.UpdateBlockSideAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteBlockSide/{blockSideId}")]
    public void DeleteBlockSide(int blockSideId)
    {
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
    /// Indicating the block type,be it a single or twin block.
    ///
    /// Sample Request:
    ///
    /// POST /CreateBlockType
    /// 
    /// {
    ///    "sideId": 0,
    ///    "side": "LEFT",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockType")]
    public async Task<ActionResult<BlockTypeReadDto>> AddBlockType([FromBody] BlockTypeCreateDto values)
    {
        try
        {
            return Ok(await _blockTypeService.CreateBlockTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting block type
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateBlockType")]
    public async Task<ActionResult<BlockTypeReadDto>> UpdateBlockType([FromBody] BlockTypeUpdateDto values)
    {
        return Ok(await _blockTypeService.UpdateBlockTypeAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteBlockType/{blockTypeId}")]
    public void DeleteBlockType(int blockTypeId)
    {
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
    /// Indicating the block unt.
    ///
    /// Sample Request:
    ///
    /// POST /CreateBlockUnit
    /// 
    /// {
    ///    "unitId": 0,
    ///    "unit": "",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreateBlockUnit")]
    public async Task<ActionResult<BlockUnitReadDto>> CreateBlockUnit([FromBody] BlockUnitCreateDto values)
    {
        try
        {
            return Ok(await _blockUnitService.CreateBlockUnitAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting block unit
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateBlockUnit")]
    public async Task<ActionResult<BlockUnitReadDto>> UpdateBlockUnit([FromBody] BlockUnitUpdateDto values)
    {
        return Ok(await _blockUnitService.UpdateBlockUnitAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteBlockUnit/{blockUnitId}")]
    public void DeleteBlockUnit(int blockUnitId)
    {
    }

    //--------------------FLOOR AREA----------------
    /// <summary>
    /// Returns a list of floor areas
    /// </summary>
    [HttpGet]
    [Route("Setup/GetFloorArea")]
    public async Task<ActionResult<IEnumerable<FloorAreaReadDto>>> GetFloorAreas()
    {
        return Ok(await _floorAreaService.GetFloorAreaAsync());
    }

    // POST: api/CreateFloorArea
    /// <summary>
    ///  Creates a new floor area
    /// </summary>
    ///     
    /// <remarks>
    /// Indicating the floor area .
    ///
    /// Sample Request:
    ///
    /// POST /CreateFloorArea
    /// 
    /// {
    ///    "floorAreaId": 0,
    ///    "area": "",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreateFloorArea")]
    public async Task<ActionResult<FloorAreaReadDto>> CreateFloorArea([FromBody] FloorAreaCreateDto values)
    {
        try
        {
            return Ok(await _floorAreaService.CreateFloorAreaAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting floor area
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateFloorArea")]
    public async Task<ActionResult<FloorAreaReadDto>> UpdateFloorArea([FromBody] FloorAreaUpdateDto values)
    {
        return Ok(await _floorAreaService.UpdateFloorAreaAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteFloorArea/{floorAreaId}")]
    public void DeleteFloorArea(int floorAreaId)
    {
        _floorAreaService.DeleteFloorArea(floorAreaId);
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
    /// Sample Request:
    ///
    /// POST /CreateFloorNumber
    /// 
    /// {
    ///    "floorNumberId": 0,
    ///    "floorNumber": "GROUND FLOOR",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreateFloorNumber")]
    public async Task<ActionResult<FloorNumberingReadDto>> CreateFloorNumber([FromBody] FloorNumberingCreateDto values)
    {
        try
        {
            return Ok(await _floorNumberingService.CreateFloorNumberingAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting floor number
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateFloorNumber")]
    public async Task<ActionResult<FloorNumberingReadDto>> UpdateFloorNumber([FromBody] FloorNumberingUpdateDto values)
    {
        return Ok(await _floorNumberingService.UpdateFloorNumberingAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteFloorNumber/{floorNumberId}")]
    public void DeleteFloorNumber(int floorNumberId)
    {
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
    /// The landuse indicates what the plot/property would be used for.<br/>
    /// Maximum of three characters to represent names of the land use
    ///
    /// Sample Request:
    ///
    /// POST /CreateLandUse
    /// 
    /// {
    ///    "landUseId": 0,
    ///    "landUseInitial": "RPL",
    ///    "landUseName": "RESIDENTIAL",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    /// <param name="values"></param>
    /// <returns></returns>


    [HttpPost]
    [Route("CreateLandUse")]
    public async Task<ActionResult<LandUseReadDto>> CreateLandUse([FromBody] LandUseCreateDto values)
    {
        try
        {
            var result = await _landUseService.CreateLandUseAsync(values);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting land use
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateLandUse")]
    public async Task<ActionResult<LandUseReadDto>> UpdateLandUse([FromBody] LandUseUpdateDto values)
    {
        return Ok(await _landUseService.UpdateLandUseAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteLandUse/{landUseId}")]
    public void DeleteLandUse(int landUseId)
    {
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
    /// The land use type indicates the sub category the plot/property use falls under.<br/>
    /// Maximum of three characters to represent names of the land use type
    ///
    /// Sample Request:
    ///
    /// POST /CreateLandUseType
    /// 
    /// {
    ///    "landUseId": 1,
    ///    "landUseTypeId": 0,
    ///    "landUseTypeInitial": "HOS",
    ///    "landUseTypeName": "TDC Built Houses(HOS)",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    [HttpPost]
    [Route("CreateLandUseType")]
    public async Task<ActionResult<LandUseTypeReadDto>> CreateLandUseType([FromBody] LandUseTypeCreateDto values)
    {
        //return Ok(await _landUseService.CreateLandUseAsync(values));
        try
        {
            return Ok(await _landUseTypeService.CreateLandUseTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting land use type
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateLandUseType")]
    public async Task<ActionResult<LandUseReadDto>> UpdateLandUseType([FromBody] LandUseTypeUpdateDto values)
    {
        return Ok(await _landUseTypeService.UpdateLandUseTypeAsync(values));
    }

    [HttpDelete("DeleteLandUseType/{landUseTypeId}")]
    public void DeleteLandUseType(int landUseId)
    {
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
    /// The locality or community indicates the area where the property/plot can be located.<br/>
    /// An abbreviation of the locality. Maximum of three characters to represent the name of the area.
    ///
    /// Sample Request:
    ///
    /// POST /CreateLocality
    /// 
    /// {
    ///    "localityId": 1,
    ///    "localityInitial": "ASH",
    ///    "localityName": "ASHIAMAN",
    ///    "customerCode": "2W",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    /// 
    [HttpPost]
    [Route("CreateLocality")]
    public async Task<ActionResult<LocalityReadDto>> CreateLocality([FromBody] LocalityCreateDto values)
    {
        try
        {
            return Ok(await _localityService.CreateLocalityAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting locality
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdateLocality")]
    public async Task<ActionResult<LocalityReadDto>> UpdateLocality([FromBody] LocalityUpdateDto values)
    {
        return Ok(await _localityService.UpdateLocalityAsync(values));
    }

    [HttpDelete("DeleteLocality/{localityId}")]
    public void DeleteLocality(int localityId)
    {
    }

    //----------------------PLOT DIMENSION------------
    /// <summary>
    /// Returns a list of exisiting plot sizes
    /// </summary>
    [HttpGet]
    [Route("Setup/GetPlotDimensions")]
    public async Task<ActionResult<IEnumerable<PlotDimensionReadDto>>> GetPlotDimension()
    {
        return Ok(await _plotDimensionService.GetPlotDimensionAsync());
    }

    [HttpGet]
    [Route("Setup/GetPlotDimension/{value}")]
    public async Task<ActionResult<PlotDimensionReadDto>> GetPlotDimension(string value)
    {
        return Ok(await _plotDimensionService.GetPlotDimensionAsync(value));
    }

    [HttpGet]
    [Route("Setup/GetPlotDimensionById/{PlotDimensionId}")]
    public async Task<ActionResult<PlotDimensionReadDto>> GetPlotDimensionById(int PlotDimensionId)
    {
        return Ok(await _plotDimensionService.GetPlotDimensionAsync(PlotDimensionId));
    }

    // POST: api/CreatePlotDimension
    /// <summary>
    ///  Creates a new plot dimension
    /// </summary>
    ///     
    /// <remarks>
    /// The plot dimension indicates the lenght and breath of the property/plot.
    ///
    /// Sample Request:
    ///
    /// POST /CreatePlotDimension
    /// 
    /// {
    ///    "PlotDimensionId": 0,
    ///    "PlotDimensions": "70x100",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreatePlotDimension")]
    public async Task<ActionResult<PlotDimensionReadDto>> AddPlotDimension([FromBody] PlotDimensionCreateDto values)
    {
        try
        {
            return Ok(await _plotDimensionService.CreatePlotDimensionAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting plot size
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdatePlotDimension")]
    public async Task<ActionResult<PlotDimensionReadDto>> UpdatePlotDimension([FromBody] PlotDimensionUpdateDto values)
    {
        return Ok(await _plotDimensionService.UpdatePlotDimensionAsync(values));
    }

    [HttpDelete("DeletePlotDimension/{PlotDimensionId}")]
    public void DeletePlotDimension(int localityId)
    {
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
    ///  Creates a new zonning property height
    /// </summary>
    ///     
    /// <remarks>
    /// The property height indicates the acceptable zonning height of the property/plot for a locality.
    ///
    /// Sample Request:
    ///
    /// POST /CreatePropertyHeight
    /// 
    /// {
    ///    "propertyHeightId": 0,
    ///    "propertyHeights": "SINGLE STOREY",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreatePropertyHeight")]
    public async Task<ActionResult<PropertyHeightReadDto>> CreatePropertyHeight([FromBody] PropertyHeightCreateDto values)
    {
        try
        {
            return Ok(await _propertyHeightService.CreatePropertyHeightAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting property height
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdatePropertyHeight")]
    public async Task<ActionResult<PropertyHeightReadDto>> UpdatePropertyHeight([FromBody] PropertyHeightUpdateDto values)
    {
        return Ok(await _propertyHeightService.UpdatePropertyHeightAsync(values));
    }

    [HttpDelete("DeletePropertyHeight/{propertyHeightId}")]
    public void DeletePropertyHeight(int propertyHeightId)
    { }

    //----------------------PLOT TYPE------------
    /// <summary>
    /// Returns a list of exisiting property types
    /// </summary>
    [HttpGet]
    [Route("Setup/GetPlotType")]
    public async Task<ActionResult<IEnumerable<PlotTypeReadDto>>> GetPlotType()
    {
        return Ok(await _plotTypeService.GetPlotTypeAsync());
    }

    
    // POST: api/CreatePlotType
    /// <summary>
    ///  Creates a new property type
    /// </summary>
    ///     
    /// <remarks>
    /// The property types indicates the whether the property/plot is a serviced plot or a rental house.
    ///
    /// Sample Request:
    ///
    /// POST /CreatePlotType
    /// 
    /// {
    ///    "PlotTypeId": 0,
    ///    "PlotTypes": "PARTIALLY-SERVICES PLOTS",
    ///    "createdBy": "32ea339b-75f2-4f57-8153-915f127a9612"
    /// }
    /// </remarks>
    [HttpPost]
    [Route("CreatePlotType")]
    public async Task<ActionResult<PlotTypeReadDto>> CreatePlotType([FromBody] PlotTypeCreateDto values)
    {
        try
        {
            return Ok(await _plotTypeService.CreatePlotTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    /// <summary>
    ///  Updates the details of an exsiting property type
    /// </summary>
    /// 
    [HttpPut]
    [Route("UpdatePlotType")]
    public async Task<ActionResult<PlotTypeReadDto>> UpdatePlotType([FromBody] PlotTypeUpdateDto values)
    {
        return Ok(await _plotTypeService.UpdatePlotTypeAsync(values));
    }

    [HttpDelete("DeletePlotType/{PlotTypeId}")]
    public void DeletePlotType(int PlotTypeId)
    { }

    //----------------------------------
    [HttpPost]
    [Route("CreateProperty")]
    public async Task<ActionResult<PlotTypeReadDto>> CreateProperty([FromBody] PropertyMasterCreatePlotDto values)
    {
        try
        {
            return Ok(await _propertyMasterService.CreateProperty(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

}

