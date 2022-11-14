using APIMSConsolidado.Repository;
using APIMSConsolidado.Repository.Context;
using APIMSConsolidado.Repository.Interfaces;
using APIMSConsolidado.Services;
using APIMSConsolidado.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LancamentosContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("PostgreDB")
    ));
builder.Services.AddTransient<IConsolidadoService, ConsolidadoService>();
builder.Services.AddTransient<IConsolidadoRepository, ConsolidadoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();

