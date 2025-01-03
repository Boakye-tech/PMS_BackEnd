using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Modules.Estates.Application.DTO.Management.Property;
using Modules.Estates.Application.Interfaces.Management.Property;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
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
    [HttpGet]
    [Route("Setup/GetActivities")]
    public async Task<ActionResult<IEnumerable<ActivityReadDto>>> GetActivities()
    {
        return Ok(await _activityService.GetActivitiesAsync());
    }

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
    [HttpGet]
    [Route("Setup/GetActivityTypes")]
    public async Task<ActionResult<IEnumerable<ActivityTypeReadDto>>> GetActivityTypes()
    {
        return Ok(await _activityTypeService.GetActivityTypeAsync());
    }

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

    [HttpPost]
    [Route("CreateAllocationType")]
    public async Task<ActionResult<AllocationTypeReadDto>> CreateAllocationType([FromBody] AllocationTypeCreateDto values)
    {
        try
        {
            return Ok(await _allocationTypeService.AddAllocationTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { detail = ex.Message });
        }
    }

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

    [HttpPost]
    [Route("AddApartmentType")]
    public async Task<ActionResult<ApartmentTypeReadDto>> AddApartmentType([FromBody] ApartmentTypeCreateDto values)
    {
        try
        {
            return Ok(await _apartmentTypeService.AddApartmentTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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
    [HttpGet]
    [Route("Setup/GetBlockNumber")]
    public async Task<ActionResult<IEnumerable<BlockNumberReadDto>>> GetBlockNumber()
    {
        return Ok(await _blockNumberService.GetBlockNumberAsync());
    }

    [HttpPost]
    [Route("AddBlockNumber")]
    public async Task<ActionResult<BlockNumberReadDto>> AddBlockNumber([FromBody] BlockNumberCreateDto values)
    {
        try
        {
            return Ok(await _blockNumberService.AddBlockNumberAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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
    [HttpGet]
    [Route("Setup/GetBlockSides")]
    public async Task<ActionResult<IEnumerable<BlockSideReadDto>>> GetBlockSides()
    {
        return Ok(await _blockSideService.GetBlockSideAsync());
    }

    [HttpPost]
    [Route("AddBlockSide")]
    public async Task<ActionResult<BlockSideReadDto>> AddBlockSide([FromBody] BlockSideCreateDto values)
    {
        try
        {
            return Ok(await _blockSideService.AddBlockSideAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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
    [HttpGet]
    [Route("Setup/GetBlockTypes")]
    public async Task<ActionResult<IEnumerable<BlockTypeReadDto>>> GetBlockTypes()
    {
        return Ok(await _blockTypeService.GetBlockTypeAsync());
    }

    [HttpPost]
    [Route("AddBlockType")]
    public async Task<ActionResult<BlockTypeReadDto>> AddBlockType([FromBody] BlockTypeCreateDto values)
    {
        try
        {
            return Ok(await _blockTypeService.AddBlockTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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
    [HttpGet]
    [Route("Setup/GetBlockUnits")]
    public async Task<ActionResult<IEnumerable<BlockUnitReadDto>>> GetBlockUnits()
    {
        return Ok(await _blockUnitService.GetBlockUnitAsync());
    }

    [HttpPost]
    [Route("AddBlockUnit")]
    public async Task<ActionResult<BlockUnitReadDto>> AddBlockUnit([FromBody] BlockUnitCreateDto values)
    {
        try
        {
            return Ok(await _blockUnitService.AddBlockUnitAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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

    //--------------------FACILITIES----------------
    [HttpGet]
    [Route("Setup/GetFacilities")]
    public async Task<ActionResult<IEnumerable<FacilitiesReadDto>>> GetFacilities()
    {
        return Ok(await _facilitiesService.GetFacilitiesAsync());
    }

    [HttpPost]
    [Route("AddFacility")]
    public async Task<ActionResult<FacilitiesReadDto>> AddFacility([FromBody] FacilitiesCreateDto values)
    {
        try
        {
            return Ok(await _facilitiesService.AddFacilitiesAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdateFacility")]
    public async Task<ActionResult<FacilitiesReadDto>> UpdateFacility([FromBody] FacilitiesUpdateDto values)
    {
        return Ok(await _facilitiesService.UpdateFacilitiesAsync(values));
    }
    // DELETE api/values/5
    [HttpDelete("DeleteFacility/{facilityId}")]
    public void DeleteFacility(int facilityId)
    {
    }

    //--------------------FLOOR NUMBERING----------------
    [HttpGet]
    [Route("Setup/GetFloorNumbering")]
    public async Task<ActionResult<IEnumerable<FloorNumberingReadDto>>> GetFloorNumbering()
    {
        return Ok(await _floorNumberingService.GetFloorNumberingAsync());
    }

    [HttpPost]
    [Route("AddFloorNumber")]
    public async Task<ActionResult<FloorNumberingReadDto>> AddFloorNumber([FromBody] FloorNumberingCreateDto values)
    {
        try
        {
            return Ok(await _floorNumberingService.AddFloorNumberingAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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

    [HttpPost]
    [Route("AddLandUse")]
    public async Task<ActionResult<LandUseReadDto>> AddLandUse([FromBody] LandUseCreateDto values)
    {
        //return Ok(await _landUseService.AddLandUseAsync(values));
        try
        {
            return Ok(await _landUseService.AddLandUseAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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

    [HttpPost]
    [Route("AddLandUseType")]
    public async Task<ActionResult<LandUseTypeReadDto>> AddLandUseType([FromBody] LandUseTypeCreateDto values)
    {
        //return Ok(await _landUseService.AddLandUseAsync(values));
        try
        {
            return Ok(await _landUseTypeService.AddLandUseTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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

    [HttpPost]
    [Route("AddLocality")]
    public async Task<ActionResult<LocalityReadDto>> AddLocality([FromBody] LocalityCreateDto values)
    {
        try
        {
            return Ok(await _localityService.AddLocalityAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

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

    //----------------------PLOT SIZE------------
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

    [HttpPost]
    [Route("AddPlotSize")]
    public async Task<ActionResult<PlotSizeReadDto>> AddPlotSize([FromBody] PlotSizeCreateDto values)
    {
        try
        {
            return Ok(await _plotSizeService.AddPlotSizeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdatePlotSize")]
    public async Task<ActionResult<PlotSizeReadDto>> UpdatePlotSize([FromBody] PlotSizeUpdateDto values)
    {
        return Ok(await _plotSizeService.UpdatePlotSizeAsync(values));
    }

    [HttpDelete("DeletePlotSize/{plotSizeId}")]
    public void DeletePlotSize(int localityId)
    {
    }

    //----------------------PROPERTY HEIGHT------------
    [HttpGet]
    [Route("Setup/GetPropertyHeight")]
    public async Task<ActionResult<IEnumerable<PropertyHeightReadDto>>> GetPropertyHeight()
    {
        return Ok(await _propertyHeightService.GetPropertyHeightAsync());
    }

    [HttpPost]
    [Route("AddPropertyHeight")]
    public async Task<ActionResult<PropertyHeightReadDto>> AddPropertyHeight([FromBody] PropertyHeightCreateDto values)
    {
        try
        {
            return Ok(await _propertyHeightService.AddPropertyHeightAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdatePropertyHeight")]
    public async Task<ActionResult<PropertyHeightReadDto>> UpdatePropertyHeight([FromBody] PropertyHeightUpdateDto values)
    {
        return Ok(await _propertyHeightService.UpdatePropertyHeightAsync(values));
    }

    [HttpDelete("DeletePropertyHeight/{propertyHeightId}")]
    public void DeletePropertyHeight(int propertyHeightId)
    { }

    //----------------------PROPERTY TYPE------------
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

    [HttpPost]
    [Route("AddPropertyType")]
    public async Task<ActionResult<PropertyTypeReadDto>> AddPropertyType([FromBody] PropertyTypeCreateDto values)
    {
        try
        {
            return Ok(await _propertyTypeService.AddPropertyTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
        }
    }

    [HttpPut]
    [Route("UpdatePropertyType")]
    public async Task<ActionResult<PropertyTypeReadDto>> UpdatePropertyType([FromBody] PropertyTypeUpdateDto values)
    {
        return Ok(await _propertyTypeService.UpdatePropertyTypeAsync(values));
    }

    [HttpDelete("DeletePropertyType/{propertyTypeId}")]
    public void DeletePropertyType(int propertyTypeId)
    { }

    //----------------------------------
    [HttpPost]
    [Route("CreateProperty")]
    public async Task<ActionResult<PropertyTypeReadDto>> CreateProperty([FromBody] PropertyMasterCreatePlotDto values)
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

