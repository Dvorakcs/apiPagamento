using Microsoft.EntityFrameworkCore;
using apiPagamento.Models;
using apiPagamento.Context;
using System;
using apiPagamento.Services;
using apiPagamento.Repository;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//carrega o Repositoriy
builder.Services.AddTransient<IUsuarioRespository,UsuarioRepository>();
//carrega as classes que gerencia o repository 
builder.Services.AddSingleton<UsuarioService>();
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
