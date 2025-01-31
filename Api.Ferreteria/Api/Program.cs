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

builder.Services.AddScoped<ISuppliersDA, SuppliersDA>();
builder.Services.AddScoped<ISuppliersBW, SuppliersBW>();
builder.Services.AddScoped<IFormatTextBC<Suppliers>, FormatTextBC<Suppliers>>();
builder.Services.AddScoped<IFormatTextBC<SuppliersRequest>, FormatTextBC<SuppliersRequest>>();

builder.Services.AddScoped<IServicesDA, ServicesDA>();
builder.Services.AddScoped<IServicesBW, ServicesBW>();
builder.Services.AddScoped<IFormatTextBC<Services>, FormatTextBC<Services>>();
builder.Services.AddScoped<IFormatTextBC<ServicesRequest>, FormatTextBC<ServicesRequest>>();

builder.Services.AddScoped<IProductsDA, ProductsDA>();
builder.Services.AddScoped<IProductsBW, ProductsBW>();
builder.Services.AddScoped<IFormatTextBC<Products>, FormatTextBC<Products>>();
builder.Services.AddScoped<IFormatTextBC<ProductsRequest>, FormatTextBC<ProductsRequest>>();

builder.Services.AddScoped<IProductsCategoriesDA, ProductsCategoriesDA>();
builder.Services.AddScoped<IProductsxCategoriesBW, ProductsCategoriesBW>();

builder.Services.AddScoped<IPeopleDA, PeopleDA>();
builder.Services.AddScoped<IPeopleBW, PeopleBW>();
builder.Services.AddScoped<IFormatTextBC<People>, FormatTextBC<People>>();
builder.Services.AddScoped<IFormatTextBC<PeopleRequest>, FormatTextBC<PeopleRequest>>();

builder.Services.AddScoped<IInventoriesDA, InventoriesDA>();
builder.Services.AddScoped<IInventoriesBW, InventoriesBW>();

builder.Services.AddScoped<ICartsxProductsDA, CartsxProductsDA>();
builder.Services.AddScoped<ICartsxProductsBW, CartsxProductsBW>();

builder.Services.AddScoped<ICartServiceDA, CartServiceDA>();
builder.Services.AddScoped<ICartServiceBW, CartServiceBW>();

builder.Services.AddScoped<ICartsDA, CartsDA>();
builder.Services.AddScoped<ICartsBW, CartsBW>();

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
