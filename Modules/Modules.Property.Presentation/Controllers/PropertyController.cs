﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Modules.Estates.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PropertyController : ControllerBase
{
    readonly IAllocationTypeService _allocationTypeService;
    readonly ILandUseService _landUseService;
    readonly ILandUseTypeService _landUseTypeService;
    readonly ILocalityService _localityService;
    readonly IPlotSizeService _plotSizeService;
    readonly IPropertyTypeService _propertyTypeService;
    readonly IApartmentTypeService _apartmentTypeService;

    public PropertyController(IAllocationTypeService allocationTypeService, ILandUseService landUseService, ILandUseTypeService landUseTypeService, ILocalityService localityService, IPlotSizeService plotSizeService,
                              IApartmentTypeService apartmentTypeService, IPropertyTypeService propertyTypeService)
    {
        _allocationTypeService = allocationTypeService;
        _landUseService = landUseService;
        _landUseTypeService = landUseTypeService;
        _localityService = localityService;
        _plotSizeService = plotSizeService;
        _propertyTypeService = propertyTypeService;
        _apartmentTypeService = apartmentTypeService;
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
    [Route("AddAllocationType")]
    public async Task<ActionResult<AllocationTypeReadDto>> AddLandUse([FromBody] AllocationTypeCreateDto values)
    {
        try
        {
            return Ok(await _allocationTypeService.AddAllocationTypeAsync(values));
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.InnerException!.Message);
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
    public async Task<ActionResult<LocalityReadDto>> UpdatePropertyType([FromBody] PropertyTypeUpdateDto values)
    {
        return Ok(await _propertyTypeService.UpdatePropertyTypeAsync(values));
    }

    [HttpDelete("DeletePropertyType/{propertyTypeId}")]
    public void DeletePropertyType(int propertyTypeId)
    { }

    //----------------------------------


}

