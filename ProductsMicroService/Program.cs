using ProductsMicroService.Models;
using ProductsMicroService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IRepository<Product>, ProductRepository>();
builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options =>
    {
        options.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});


var app = builder.Build();
app.UseCors("AllowOrigin");

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
