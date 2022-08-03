using Microsoft.EntityFrameworkCore;
using SoteriaProjectWebApi.Data;
using SoteriaProjectWebApi.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<SoteriaContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SoteriaConnectionString")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<ISoteriaDbRepository, SoteriaDbRepository>();

// Addss DbInitialiser to DI Container
builder.Services.AddTransient<DbInitialiser>();


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

using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;

var initialiser = services.GetRequiredService<DbInitialiser>();

initialiser.Run();


app.Run();
