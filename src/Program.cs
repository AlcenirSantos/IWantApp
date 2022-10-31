using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IWantAPP.Controllers;
using IWantAPP.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddNpgsql<ApplicationDbContext>(builder.Configuration["ConnectionString:uri"]);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapMethods(CategoryController.Template, CategoryController.Methods, CategoryController.Handle);

app.Run();
