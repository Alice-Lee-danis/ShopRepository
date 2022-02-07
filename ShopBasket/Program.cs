using Microsoft.EntityFrameworkCore;
using ShopBasket.Context;
using ShopBasket.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContex>(options =>
    options.UseSqlServer("Data Source=(local); Database=Basket; Persist Security Info=False; MultipleActiveResultSets=True; Trusted_Connection=True;"));
builder.Services.AddScoped<BasketRepository>();
builder.Services.AddScoped<ProductRepository>();
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
