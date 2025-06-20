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


    //-------------------APARTMENT CATEGORIES-----------------
    /// <summary>
    /// Returns a list of apartment categories
    /// </summary>
    [HttpGet]
    //[Authorize(Policy = "Permission:Customers.READ")]
    [Route("ApartmentCategory")]
    [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
    private IActionResult ApartmentCategory()
    {
        var statuses = Enum.GetValues(typeof(ApartmentCategoryEnum))
                               .Cast<ApartmentCategoryEnum>()
                               .Select(e => new
                               {
                                   Id = (int)e,
                                   Name = e.ToString(),
                                   DisplayName = e.GetType()
                                                 .GetField(e.ToString())!
                                                  .GetCustomAttribute<DescriptionAttribute>()?
                                                  .Description

                               });
        return Ok(statuses);
    }





}

