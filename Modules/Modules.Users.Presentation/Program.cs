using System.Reflection;

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
            builder.Services.AddDbContext<UserDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MsSQLConnection")));
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


builder.Services.AddUserModule(builder.Configuration);

//builder.Services.AddIdentity<ApplicationIdentityUser, ApplicationIdentityRole>(options =>
//{
//    options.SignIn.RequireConfirmedAccount = true;
//    options.User.RequireUniqueEmail = true;
//    options.Password.RequiredLength = 8;
//    options.Password.RequireNonAlphanumeric = true;
//    options.Password.RequireUppercase = true;
//}).AddEntityFrameworkStores<UserDbContext>()
//  .AddDefaultTokenProviders();

//builder.Services.AddScoped<ValidationService>();

//builder.Services.AddScoped<IAdministrationService, AdministrationService>();
//builder.Services.AddScoped<IStaffAccountService, StaffAccountService>();
//builder.Services.AddScoped<IPartnerBankAccountService, PartnerBankAccountService>();
//builder.Services.AddScoped<ICustomerAccountService, CustomerAccountService>();
//builder.Services.AddScoped<IMenuService, MenuService>();


////register global exception handler
//builder.Services.AddExceptionHandler<HttpGlobalExceptionFilter>();
//builder.Services.AddProblemDetails();

builder.Services.AddControllers();

//builder.Services.AddFluentValidationAutoValidation();
//builder.Services.AddValidatorsFromAssemblyContaining<DepartmentDtoValidator>();
//builder.Services.AddValidatorsFromAssemblyContaining<DepartmentUnitDtoValidator>();
//builder.Services.AddValidatorsFromAssemblyContaining<TokenStoreDtoValidator>();

//builder.Services.AddValidatorsFromAssemblyContaining<RolesDtoValidator>();
//builder.Services.AddValidatorsFromAssemblyContaining<RolesUpdateDtoValidator>();
//builder.Services.AddValidatorsFromAssemblyContaining<RolesDeleteDtoValidator>();

//builder.Services.AddValidatorsFromAssemblyContaining<RoleMenuActionsDtoValidator>();
//builder.Services.AddValidatorsFromAssemblyContaining<MenusDtoValidator>();


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

