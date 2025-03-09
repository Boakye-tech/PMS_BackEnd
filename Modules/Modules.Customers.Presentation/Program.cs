using System.Reflection;
using System.Text;
using Asp.Versioning;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Modules.Customers.Infrastructure.Persistence;
using Modules.Customers.Presentation;
using Modules.Customers.Presentation.Filters;
using Modules.Customers.Presentation.OpenAPI;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.customers.json", optional: false, reloadOnChange: true);

//Add Serilog Configuration
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


// Add services to the container.
if (builder.Environment.IsDevelopment())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            break;
    }

}

if (builder.Environment.IsProduction())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
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

//var key = Encoding.ASCII.GetBytes(builder.Configuration["JwTokenKey:TokenKey"]!);

//builder.Services.AddAuthentication(a =>
//{
//    a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
//    a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//    a.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
//})
//.AddJwtBearer(x =>
//{
//    x.Events = new JwtBearerEvents
//    {
//        OnTokenValidated = UserDbContext =>
//        {
//            //TODO
//            return Task.CompletedTask;
//        }
//    };
//    x.RequireHttpsMetadata = false;
//    x.SaveToken = true;
//    x.TokenValidationParameters = new TokenValidationParameters
//    {
//        ValidateIssuerSigningKey = true,
//        ValidateLifetime = true,
//        IssuerSigningKey = new SymmetricSecurityKey(key),
//        ValidateIssuer = false,
//        ValidateAudience = false
//    };

//});

builder.Services.AddCustomerModule(builder.Configuration);


//register global exception handler
builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
builder.Services.AddProblemDetails();

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

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    //app.UseSwagger();
    //app.UseSwaggerUI();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

