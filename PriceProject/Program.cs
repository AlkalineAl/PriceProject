using PriceProject.DAL.Repositories;
using PriceProject.DAL.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
string connectionString = builder.Configuration.GetSection("DbInfo")["DB"];
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Services
#endregion

#region Repositories
builder.Services.AddTransient<IShopRepository, ShopRepository>(provider => new ShopRepository(connectionString));
#endregion

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