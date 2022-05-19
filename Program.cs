using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TodolistApp.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<TodolistAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TodolistAppContext") ?? throw new InvalidOperationException("Connection string 'TodolistAppContext' not found.")));

// Add services to the container.
builder.Services.AddCors();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
