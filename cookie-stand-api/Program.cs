using cookie_stand_api.Data;
using cookie_stand_api.Models.Interfaces;
using cookie_stand_api.Models.Services;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
    {
        Title = "Cookie Salmon API",
        Version = "v1",
    });
});

builder.Services.AddTransient<ICookiestand, CookiestandService>();

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));




var app = builder.Build();
app.UseSwagger(options =>
{
    options.RouteTemplate = "swagger/{documentName}/swagger.json";
});

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "CookieStand API");
    options.RoutePrefix = "swagger";
});

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();

//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
//    });
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
