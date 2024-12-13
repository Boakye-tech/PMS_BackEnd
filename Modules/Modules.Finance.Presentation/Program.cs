using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Modules.Finance.Application.Validations.Setup;
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
            //builder.Services.AddDbContext<FinanceDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<FinanceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
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
            builder.Services.AddDbContext<FinanceDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            break;
    }
}

builder.Services.AddFinanceModule(builder.Configuration);


//// Dependency Injection - Register AutoMapper 
//builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

//register global exception handler
builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
builder.Services.AddProblemDetails();

builder.Services.AddControllers();
//builder.Services.AddFluentValidation(fv => { fv.RegisterValidatorsFromAssemblyContaining<BankValidator>(); });

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<BankDtoValidator>();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

