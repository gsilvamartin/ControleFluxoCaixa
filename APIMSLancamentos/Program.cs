using APIMSLancamentos.Repository;
using APIMSLancamentos.Repository.Context;
using APIMSLancamentos.Repository.Interfaces;
using APIMSLancamentos.Services;
using APIMSLancamentos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LancamentosContext>(
    options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("PostgreDB")
    ));

builder.Services.AddTransient<ILancamentoService, LancamentoService>();
builder.Services.AddTransient<ILancamentoRepository, LancamentoRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();

