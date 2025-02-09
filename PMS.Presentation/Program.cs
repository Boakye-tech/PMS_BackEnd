﻿using System.Reflection;
using System.Text;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Modules.Customers.Presentation;
using Modules.Estates.Presentation;
using Modules.Finance.Presentation;
using Modules.Notification.Presentation;
using Modules.Users.Presentation;
using PMS.Presentation.Extensions;
using PMS.Presentation.OpenAPI;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


// Add services to the container.

builder.Services.AddSharedInfrastructure(builder.Configuration);

builder.Services.AddEstateModule(builder.Configuration);

builder.Services.AddFinanceModule(builder.Configuration);

builder.Services.AddUserModule(builder.Configuration);

builder.Services.AddNotificationModule(builder.Configuration);

builder.Services.AddCustomerModule(builder.Configuration);

var module = "Modules.Estates.Presentation";
var user_module = "Modules.Users.Presentation";
//var finance_module = "Modules.Finance.Presentation";
//var notification_module = "Modules.Notification.Presentation";

//var key = Encoding.ASCII.GetBytes(builder.Configuration["JwTokenKey:TokenKey"]!);

//builder.Services.AddAuthentication(a =>
//{
//    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    a.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//.AddJwtBearer(x =>
//{
//   x.Events = new JwtBearerEvents
//   {
//       OnTokenValidated = ApplicationDbContext =>
//       {
//           //TODO
//           return Task.CompletedTask;
//       }
//   };
//   x.RequireHttpsMetadata = false;
//   x.SaveToken = true;
//   x.TokenValidationParameters = new TokenValidationParameters
//   {
//       ValidateIssuerSigningKey = true,
//       ValidateLifetime = true,
//       IssuerSigningKey = new SymmetricSecurityKey(key),
//       ValidateIssuer = false,
//       ValidateAudience = false
//   };

//});

builder.Services.AddCors(o =>
{
    o.AddDefaultPolicy(
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyHeader()
                   .AllowAnyMethod();
                   //.AllowCredentials();
        });
});

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfigureOptions>();

builder.Services
    .AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        options.AssumeDefaultVersionWhenUnspecified = true;
        options.ReportApiVersions = true;
    })
    .AddApiExplorer(options =>
    {
        options.GroupNameFormat = "'v'VVV";
        options.SubstituteApiVersionInUrl = true;
    });


builder.Services.AddSwaggerGen(options =>
{

    options.OperationFilter<SwaggerDefaultValues>();

    //options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    //{
    //    Name = "Authorization",
    //    Type = SecuritySchemeType.ApiKey,
    //    Scheme = "Bearer",
    //    BearerFormat = "JWT",
    //    In = ParameterLocation.Header,
    //    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 1safsfsdfdfd\"",

    //});

    //options.AddSecurityRequirement(new OpenApiSecurityRequirement
    //{
    //    {
    //        new OpenApiSecurityScheme
    //        {
    //            Reference = new OpenApiReference
    //            {
    //                Type = ReferenceType.SecurityScheme,
    //                Id =  "Bearer"
    //            }
    //        },
    //        Array.Empty<string>()
    //    }
    //});


    // Use the full type name (namespace + class name) as the schemaId
    options.CustomSchemaIds(type => type.FullName);

    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{module}.xml"));
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{user_module}.xml"));
});


var app = builder.Build();

app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.PreSerializeFilters.Add((swagger, req) =>
        {
            swagger.Servers = new List<OpenApiServer>() { new OpenApiServer() { Url = $"https://{req.Host}" } };
        });
    });


    app.UseSwaggerUI(options =>
    {
        var ApiVersionDescriptions = app.DescribeApiVersions();

        foreach (var desc in ApiVersionDescriptions)
        {
            options.SwaggerEndpoint($"../swagger/{desc.GroupName}/swagger.json", $"PMS.Presentation API {desc.ApiVersion.ToString()}");
            options.DefaultModelsExpandDepth(-1);
            options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
        }
    });
}

if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "PMS.Presentation  API V1");
        options.DefaultModelExpandDepth(2);
        options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
    });
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseCors();

app.MapControllers();

app.Run();


/*
  
 */
