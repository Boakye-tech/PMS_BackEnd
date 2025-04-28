// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


global using System.Threading.RateLimiting;
global using Microsoft.AspNetCore.RateLimiting;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;

global using FluentValidation;
global using FluentValidation.AspNetCore;

global using Serilog;

global using Modules.Users.Application.Interfaces.UserAccounts;
global using Modules.Users.Application.Validations.UserAccounts;
global using Modules.Users.Application.UseCases.UserAccounts;
global using Modules.Users.Application.Dtos.Administration;
global using Modules.Users.Application.Dtos.Entities.Menu;
global using Modules.Users.Application.Validations;
global using Modules.Users.Application.Interfaces;
global using Modules.Users.Application.UseCases;
global using Modules.Users.Application.Dtos.Entities;
global using Modules.Users.Application.Dtos.Entities.Permissions;
global using Modules.Users.Application.Enums;
global using Modules.Users.Application.Dtos.UserAccounts;
global using Modules.Users.Application.Shared;
global using Modules.Users.Application.Services;

global using Modules.Users.Infrastructure;
global using Modules.Users.Infrastructure.Configuration;
global using Modules.Users.Infrastructure.Repositories.Entities;
global using Modules.Users.Infrastructure.Extensions;
global using Modules.Users.Infrastructure.Repositories;

global using Modules.Users.Presentation.Filters;
global using Modules.Users.Presentation;
global using Modules.Users.Presentation.OpenAPI;

global using Modules.Users.Domain.Entities;
global using Modules.Users.Domain.Interfaces;
global using Modules.Users.Domain.Interfaces.Entities;

global using Modules.Common.Infrastructure.Authentication;
