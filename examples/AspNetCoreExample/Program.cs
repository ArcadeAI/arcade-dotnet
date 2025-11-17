using ArcadeDotnet;
using ArcadeDotnet.Extensions;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddArcadeClient(
    builder.Configuration["Arcade:ApiKey"] ?? throw new InvalidOperationException("Arcade:ApiKey not configured")
);

var app = builder.Build();

app.MapGet("/tools", async (IArcadeClient arcade) =>
{
    var tools = await arcade.Tools.List();
    tools.Validate();
    return Results.Ok(new { count = tools.Items?.Count ?? 0 });
});

app.MapGet("/health", async (IArcadeClient arcade) =>
{
    var health = await arcade.Health.Check();
    health.Validate();
    return Results.Ok(new { healthy = health.Healthy });
});

app.Run();
