using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Prosegur.GAP.Application.Implementation;
using Prosegur.GAP.Application.Interface;
using Prosegur.GAP.Domain.Interface.Repository;
using Prosegur.GAP.Domain.Seedwork;
using Prosegur.GAP.Repository.Context;
using Prosegur.GAP.Repository.ExtensionContext;
using Prosegur.GAP.Repository.Repositories;
using Prosegur.GAP.Repository.UnitofWork;
using Rep.Traserep.Infra.CrossCutting.Adapter;
using Rep.Traserep.Infra.CrossCutting.Net.AutoMapper;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen( c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API GAP", Version = "v1", Description = "APIS utilizados en el sistema GAP" });
    c.EnableAnnotations();
});

builder.Services.AddDbContext<GAPDBContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("WebApiDBGAP")));

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IRolService, RolService>();
builder.Services.AddScoped<IRolRepository, RolRepository>();
builder.Services.AddScoped<ITypeAdapterFactory, AutoMapperTypeAdapterFactory>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var serviceProvider = new ServiceCollection()
         .AddScoped<ITypeAdapterFactory, AutoMapperTypeAdapterFactory>()
         .BuildServiceProvider();
 
var typeAdapterFactory = serviceProvider.GetRequiredService<ITypeAdapterFactory>();
TypeAdapterFactory.SetCurrent(typeAdapterFactory);
 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DocExpansion(DocExpansion.None);
        c.SwaggerEndpoint("v1/swagger.json", "API GAP");
      
    });
}

app.UseAuthorization();

app.MapControllers();
app.MigratedDatabase();
app.Run();