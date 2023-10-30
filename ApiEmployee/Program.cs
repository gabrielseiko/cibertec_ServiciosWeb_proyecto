using ApiEmployee.DbContexts;
using ApiEmployee.Exceptions;
using ApiEmployee.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configurando el DBContexts para usar SQL Server
var connectionString = builder.Configuration.GetConnectionString("EmployeeDB");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Configurando la inyeccion de dependencia
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware(typeof(GlobalExceptionHandler));

app.MapControllers();

app.Run();