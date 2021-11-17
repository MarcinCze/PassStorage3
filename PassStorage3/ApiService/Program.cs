global using ApiService;
global using ApiService.Handlers;
global using ApiService.Models;

var builder = WebApplication.CreateBuilder(args);
DependencyContainer.Register(builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new()
    {
        Title = builder.Environment.ApplicationName,
        Version = "v1"
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{builder.Environment.ApplicationName} v1"));
}

app.MapGet("/api/passwords", (IPasswordsHandler handler) => "ToDo Passwords");

app.MapPut("/api/password", (PasswordRequest password, IPasswordHandler handler) => $"ToDo Password Create New {password.Title}");

app.MapGet("/api/password/{passId}", (Guid passId, IPasswordHandler handler) => $"ToDo Password Get Details {passId}");

app.MapPost("/api/password/{passId}", (Guid passId, PasswordRequest password, IPasswordHandler handler) => $"ToDo Password Update ID {passId} Title {password.Title}");

app.MapPost("/api/password/{passId}/incrementViewCount", (Guid passId, IPasswordHandler handler) => $"ToDo Password IncrementViewCount ID {passId}");

app.MapDelete("/api/password/{passId}", (Guid passId, IPasswordHandler handler) => $"ToDo Password Delete {passId}");

app.Run();
