using System.Reflection;
using Backend.Api.Middlewares;
using Backend.Domain.Repositories;
using Backend.Infra.Data.EFCore;
using Backend.Infra.Data.EFCore.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var strCon = builder.Configuration.GetConnectionString("DefaultConnection") ?? "";
builder.Services.AddDbContext<EFDbContext>(
    opt => opt.UseSqlServer(strCon)
);

builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<IApartmentRepository, ApartmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware(typeof(ErrorMiddleware));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
