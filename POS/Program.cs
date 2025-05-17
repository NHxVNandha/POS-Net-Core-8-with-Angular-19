using Microsoft.EntityFrameworkCore;
using POS.Infrastructure.Persistence;
using POS.Infrastructure.Repositories.Implementations;
using POS.Infrastructure.Repositories.Interfaces;
using System;

var builder = WebApplication.CreateBuilder(args);

// Tambahkan connection string di appsettings.json dan baca di sini
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Daftarkan DbContext dengan SQL Server
builder.Services.AddDbContext<POSDbContext>(options =>
    options.UseSqlServer(connectionString));

// Tambahkan controller services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


// Tambahkan Swagger/OpenAPI (opsional tapi direkomendasikan)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
