
global using Microsoft.AspNetCore.Mvc;
global using MediatR;
global using Asp.Versioning;
global using Microsoft.AspNetCore.Identity.UI.Services;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Options;
global using Microsoft.OpenApi.Models;
global using Serilog;
global using Swashbuckle.AspNetCore.SwaggerGen;

global using Modules.Notification.Domain.Interfaces;
global using Modules.Notification.Application.Dtos;
global using Modules.Notification.Application.UseCases;
global using Modules.Notification.Infrastructure.Extensions;
global using Modules.Notification.Infrastructure.Repositories;
global using Modules.Notification.Infrastructure.Services;
global using Modules.Notification.Infrastructure;
global using Modules.Notification.Presentation;
global using Modules.Notification.Presentation.Filters;
global using Modules.Notification.Presentation.OpenAPI;


global using FirebaseAdmin;
global using Google.Apis.Auth.OAuth2;
