
var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("appsettings.notification.json", optional: false, reloadOnChange: true);


//Add Serilog Configuration
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));

// Add db services to the container.
if (builder.Environment.IsDevelopment())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<NotificationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<NotificationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
            break;
    }

}

if (builder.Environment.IsProduction())
{
    switch (builder.Configuration.GetSection("Provider").GetSection("DatabaseProvider").Value)
    {
        case "Sqlite":
            //builder.Services.AddDbContext<NotificationDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));
            break;
        case "MsSQLServer":
            builder.Services.AddDbContext<NotificationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
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

builder.Services.AddNotificationModule(builder.Configuration);

//register global exception handler
builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
builder.Services.AddProblemDetails();

builder.Services.AddControllers();
//builder.Services.AddMediatR(cfg => cfg.AsTransient(), typeof(SendNotificationHandler).Assembly);

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
    //options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));

});

//builder.Services.AddTransient<IEmailSender, EmailSender>(i => new
//        EmailSender(
//            builder.Configuration["O356mailSender:Host"]!,
//            builder.Configuration.GetValue<int>("O356mailSender:Port"),
//            builder.Configuration.GetValue<bool>("O356mailSender:EnableSSL"),
//            builder.Configuration["O356mailSender:UserName"]!,
//            builder.Configuration["O356mailSender:Password"]!
//            )
//    );

var app = builder.Build();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors();

app.MapControllers();

app.Run();

