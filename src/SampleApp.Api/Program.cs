using SampleApp.Api.Extensions;
using SampleApp.Infrastructure.Extensions;
using SampleApp.Infrastructure.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureSerilog();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddInfrastructure();
builder.Services.AddPersistence(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.ApplyMigrations();
}

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
