using LearnDotNet.Source.Day4_Dependencies_Injection.Services.Implements;
using LearnDotNet.Source.Day4_Dependencies_Injection.Services.Interface;
using LearnDotNet.Source.Day5_Custom_Exception_Middleware;

var builder = WebApplication.CreateBuilder(args);

// 1. Cors is setup first after create builder:
builder.Services.AddCors(options => {
    options.AddPolicy("AllowReactApp", policy =>
    {
        policy.WithOrigins("http://localhost:5173", "http://192.168.0.69:5137")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddScoped<ICars, ImplCars>();
builder.Services.AddOpenApi();


var app = builder.Build();

// 2. Cor need call again
app.UseCors("AllowReactApp");
app.UseMiddleware<ExceptionHandlingMiddleware>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
