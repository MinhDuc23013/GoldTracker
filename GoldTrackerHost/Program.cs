var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddControllers();

var app = builder.Build();

app.MapHealthChecks("/health");
app.MapControllers();

app.Run();
