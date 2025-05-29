global using System.Linq.Expressions;
global using System.Net;
global using System.Net.Mail;
global using System.Text.Json;

global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Identity.UI.Services;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Hosting;
global using Microsoft.AspNetCore.SignalR;
global using Microsoft.Extensions.Logging;

global using Modules.Common.Infrastructure;

global using Modules.Notification.Domain.Entities;
global using Modules.Notification.Domain.Enums;
global using Modules.Notification.Domain.Interfaces;

global using Modules.Notification.Application.Dtos.Sms;
global using Modules.Notification.Application.Interfaces;
global using Modules.Notification.Application.Dtos;

global using Modules.Notification.Infrastructure.Services;


global using Modules.Notification.Presentation.Hubs;

