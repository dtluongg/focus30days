using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using TryToLearnNetCore.LearnOn30Days.Day4_Dependencies_Injection.Services.Implements;
using TryToLearnNetCore.LearnOn30Days.Day5_Custom_Exception_Middleware;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Services.Implements;
using TryToLearnNetCore.LearnOn30Days.Day8_ORM.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add Cors (day 6):
builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowTestCors", policy =>
        {
            policy.WithOrigins("http://localhost:5174")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
    });
// Add services to the container.

// Add DBContext (day 8)
builder.Services.AddDbContext<AppDBContextDay8>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


//builder.Services.AddControllers(); (day 2)
builder.Services.AddControllers().
    AddJsonOptions(options =>
    {
        // Tự động bỏ qua không in ra json bất kỳ thuộc tính nào không gán.
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
    });
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddOpenApi();
builder.Services.AddScoped<ImplCars, ImplCars>();
builder.Services.AddScoped<CarInterfaceDay8, CarDay8Implement>(); // day 8

var app = builder.Build();
app.UseCors("AllowTestCors");

app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); // day 8

app.Run();
