using core.Interfaces;
using Bll_Servises;
using Dal_Repository_Infrastracture.Data_Repository;
using Dal_Repository_Infrastracture;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// רישום DbContext
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// רישום שירותים
builder.Services.AddScoped<IAddressRepository, AddressDal>();
builder.Services.AddScoped<IAddressServise, AdressService>();
builder.Services.AddAutoMapper(typeof(core.Mapping.Mapping));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseStaticFiles(); // זה כבר שם כברירת מחדל ל-wwwroot


app.UseAuthorization();
app.MapControllers();
app.Run();
