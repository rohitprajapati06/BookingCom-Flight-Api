
using Microsoft.OpenApi.Models;
using TourNest.Services.Flights.Book_Flights;
using System.Text;
using TourNest.Models;
using TourNest.Services.Flights.Search_Flights_Locations;
using TourNest.Services.Flights.Search_Flights;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSingleton<Random>();

builder.Services.AddHttpClient<SearchFlightService>();
builder.Services.AddScoped<FlightBookingService>();
builder.Services.AddScoped<FlightService>();
builder.Services.AddHttpContextAccessor();


builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCors("AllowAll");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
