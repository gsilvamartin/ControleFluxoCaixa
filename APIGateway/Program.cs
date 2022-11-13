using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("ocelot.json")
    .Build();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOcelot(configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseOcelot().Wait();
app.MapControllers();
app.Run();


