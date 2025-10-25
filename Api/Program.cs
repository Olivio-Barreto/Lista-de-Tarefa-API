using Api.ExtensionMethods;
using Application;
using Infra;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Configure Dependencies
builder.Services.MapApplicationServices();
builder.Services.MapInfrastructureService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapEndPoints();

app.UseHttpsRedirection();

app.Run();