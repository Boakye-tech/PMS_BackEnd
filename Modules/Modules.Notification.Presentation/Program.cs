using Microsoft.AspNetCore.Identity.UI.Services;
using Modules.Notification.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IEmailSender, EmailSender>(i => new
        EmailSender(
            builder.Configuration["EmailSender:Host"]!,
            builder.Configuration.GetValue<int>("EmailSender:Port"),
            builder.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
            builder.Configuration["EmailSender:UserName"]!,
            builder.Configuration["EmailSender:Password"]!
            )
    );

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

