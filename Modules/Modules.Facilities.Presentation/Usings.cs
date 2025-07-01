// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Presentation/Usings.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 11:52 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


global using System.Reflection;

global using Asp.Versioning;
global using Asp.Versioning.ApiExplorer;

global using Microsoft.EntityFrameworkCore;

global using Microsoft.Extensions.Options;

global using Microsoft.OpenApi.Models;
global using Microsoft.OpenApi.Any;
global using Microsoft.OpenApi.Interfaces;

global using Microsoft.AspNetCore.Mvc;

global using Serilog;

global using Swashbuckle.AspNetCore.SwaggerGen;

global using Modules.Facilities.Domain.Interfaces;

global using Modules.Facilities.Infrastructure.Extensions;
global using Modules.Facilities.Infrastructure.UnitOfWork;
global using Modules.Facilities.Infrastructure.Data;

global using Modules.Facilities.Application.Interfaces.Setup;
global using Modules.Facilities.Application.UseCases.Setup;
global using Modules.Facilities.Application.Dto.Setup;

global using Modules.Facilities.Presentation;
global using Modules.Facilities.Presentation.Filters;
global using Modules.Facilities.Presentation.OpenAPI;