using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Modules.Estates.Infrastructure;
using Modules.Estates.Presentation;
using Modules.Finance.Presentation;
using Modules.Users.Presentation;
using PMS.Presentation.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


// Add services to the container.

builder.Services.AddSharedInfrastructure(builder.Configuration);

builder.Services.AddEstateModule(builder.Configuration);

builder.Services.AddFinanceModule(builder.Configuration);

builder.Services.AddUserModule(builder.Configuration);





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });

    // Use the full type name (namespace + class name) as the schemaId
    c.CustomSchemaIds(type => type.FullName);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

