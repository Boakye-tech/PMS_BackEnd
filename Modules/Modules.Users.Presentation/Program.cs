﻿using System.Reflection;
using System.Text;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Modules.Users.Infrastructure.Configuration;
using Modules.Users.Presentation.OpenAPI;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);


if (builder.Environment.IsDevelopment())
{
    var currentDirectory = Directory.GetCurrentDirectory();
    var solutionDirectory = Directory.GetParent(currentDirectory)?.Parent?.FullName ?? "";
    var solutionLevelConfigPath = Path.Combine(solutionDirectory, "appsettings.Development.json");

    if (File.Exists(solutionLevelConfigPath))
    {
        builder.Configuration.AddJsonFile(solutionLevelConfigPath, optional: false, reloadOnChange: true);
    }
}

if (builder.Environment.IsProduction())
{
    var currentDirectory = Directory.GetCurrentDirectory();
    var solutionDirectory = Directory.GetParent(currentDirectory)?.Parent?.FullName ?? "";
    var solutionLevelConfigPath = Path.Combine(solutionDirectory, "appsettings.json");

    if (File.Exists(solutionLevelConfigPath))
    {
        builder.Configuration.AddJsonFile(solutionLevelConfigPath, optional: false, reloadOnChange: true);
    }
}

//Add Serilog Configuration
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


// Add services to the container.
if (builder.Environment.IsDevelopment())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<FinanceDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;

        case "MsSQLServer":
            builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")).EnableDetailedErrors().EnableSensitiveDataLogging());
            break;
    }

}

if (builder.Environment.IsProduction())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<FinanceDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            break;
    }
}

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


builder.Services.AddUserModule(builder.Configuration);

builder.Services.AddControllers();

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

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, SwaggerConfigureOptions>();
builder.Services.AddSwaggerGen(options =>
{
    options.OperationFilter<SwaggerDefaultValues>();
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));

});

//register global exception handler
//builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
//builder.Services.AddProblemDetails();

var app = builder.Build();

UserAndRolesConfiguration.SeedUserAndRoles(app.Services).Wait();

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
            options.SwaggerEndpoint($"../swagger/{desc.GroupName}/swagger.json", $"PMS Platform API {desc.ApiVersion.ToString()}");
            options.DefaultModelsExpandDepth(-1);
            options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
        }
    });
}

app.UseRateLimiter();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();

