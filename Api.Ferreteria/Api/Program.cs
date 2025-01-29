using Abstractions.Interfaces.BC;
using Abstractions.Interfaces.BW;
using Abstractions.Interfaces.DA;
using Abstractions.Models;
using BC;
using BW;
using DA;
using DA.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IDapperRepositoryDA, DapperRepository>();
builder.Services.AddScoped<ICategoriesDA, CategoriesDA>();
builder.Services.AddScoped<ICategoriesBW, CategoriesBW>();
builder.Services.AddScoped<IFormatTextBC<Categories>, FormatTextBC<Categories>>();
builder.Services.AddScoped<IFormatTextBC<CategoriesRequest>, FormatTextBC<CategoriesRequest>>();

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
