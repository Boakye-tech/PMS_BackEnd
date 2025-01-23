using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Modules.Estates.Presentation;
using Modules.Estates.Presentation.Filters;
using Serilog;


var builder = WebApplication.CreateBuilder(args);

//Add Serilog Configuration
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));


// Add services to the container.
if (builder.Environment.IsDevelopment())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            break;
    }

}

if (builder.Environment.IsProduction())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            break;
    }
}

builder.Services.AddEstateModule(builder.Configuration);

//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

//builder.Services.AddScoped<IAllocationTypeService, AllocationTypeService>();
//builder.Services.AddScoped<IApartmentTypeService, ApartmentTypeService>();
//builder.Services.AddScoped<IBlockNumberService, BlockNumberService>();
//builder.Services.AddScoped<IBlockSideService, BlockSideService>();
//builder.Services.AddScoped<IBlockTypeService, BlockTypeService>();
//builder.Services.AddScoped<IBlockUnitService, BlockUnitService>();
//builder.Services.AddScoped<IFacilitiesService, FacilitiesService>();
//builder.Services.AddScoped<IFloorNumberingService, FloorNumberingService>();
//builder.Services.AddScoped<ILandUseService, LandUseService>();
//builder.Services.AddScoped<ILandUseTypeService, LandUseTypeService>();
//builder.Services.AddScoped<ILocalityService, LocalityService>();
//builder.Services.AddScoped<IPlotSizeService, PlotSizeService>();
//builder.Services.AddScoped<IPropertyHeightService, PropertyHeightService>();
//builder.Services.AddScoped<IPropertyTypeService, PropertyTypeService>();

//builder.Services.AddScoped<ICustomerTypeService, CustomerTypeService>();
//builder.Services.AddScoped<IGenderService, GenderService>();
//builder.Services.AddScoped<IIdentificationTypeService, IdentificationTypeService>();
//builder.Services.AddScoped<INationalityService, NationalityService>();
//builder.Services.AddScoped<IResidentTypeService, ResidentTypeService>();
//builder.Services.AddScoped<ISocialMediaService, SocialMediaService>();
//builder.Services.AddScoped<ITitleService, TitleService>();


//// Dependency Injection - Register AutoMapper 
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//register global exception handler
builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
builder.Services.AddProblemDetails();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

