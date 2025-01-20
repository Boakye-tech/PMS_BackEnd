using Microsoft.EntityFrameworkCore;
using Modules.Customers.Infrastructure.Persistence;
using Modules.Customers.Presentation;
using Modules.Customers.Presentation.Filters;
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
            //builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            Console.WriteLine(builder.Configuration.GetConnectionString("MsSQLConnection"));
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

builder.Services.AddCustomerModule(builder.Configuration);


//register global exception handler
builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
builder.Services.AddProblemDetails();


builder.Services.AddControllers();
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

