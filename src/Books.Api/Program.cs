
using Microsoft.EntityFrameworkCore;

using Books.Api.Contexts;
using Books.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// connect to MariaDB database

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<BooksContext>(
    options => options.UseMySql(connectionString, serverVersion)
);

builder.Services.AddControllers();

// helps capture database-related exceptions and display them for developer
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// add data access classes to middleware
builder.Services.AddScoped<IBooksRepository, BooksRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// configure Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
