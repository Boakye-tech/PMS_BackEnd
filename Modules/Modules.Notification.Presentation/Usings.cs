// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Presentation/Usings.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 12/02/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

global using MediatR;

global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;

global using Asp.Versioning;

global using Serilog;

global using Swashbuckle.AspNetCore.SwaggerGen;

global using System.ComponentModel;
global using System.Reflection;

global using Modules.Notification.Domain.Interfaces;
global using Modules.Notification.Domain.Enums;
global using Modules.Notification.Domain.Entities;

global using Modules.Notification.Application.Dtos;
global using Modules.Notification.Application.UseCases;
global using Modules.Notification.Application.Interfaces;

global using Modules.Notification.Infrastructure.Extensions;
global using Modules.Notification.Infrastructure.Services;
global using Modules.Notification.Infrastructure;

global using Modules.Notification.Presentation;
global using Modules.Notification.Presentation.Filters;
global using Modules.Notification.Presentation.OpenAPI;

global using FirebaseAdmin;
global using Google.Apis.Auth.OAuth2;

global using Modules.Notification.Infrastructure.Repositories;
global using Modules.Notification.Presentation.Hubs;