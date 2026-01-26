using Ebel.ValidationKit;
using Ebel.ValidationKit.Results;
using Ebel.ValidationKit.Validators;
using Microsoft.OpenApi.Models;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Ebel.ValidationKit Demo API",
        Version = "v1"
    });
});

var app = builder.Build();

// Configura o Swagger no pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Ebel.ValidationKit Demo API v1");
    });
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.MapPost("/cpf/validator", (CpfRequest request) =>
{
    var result = request.Cpf.ValidateCpf();

    if (!result.IsValid)
        return Results.BadRequest(result);

    return Results.Ok(result);
});

app.MapPost("/name/validator", (NameRequest request) =>
{
    var result = request.Name.ValidateName();

    if (!result.IsValid)
        return Results.BadRequest(result);

    return Results.Ok(result);
});

app.Run();