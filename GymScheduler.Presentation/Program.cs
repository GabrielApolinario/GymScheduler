using GymScheduler.Infrastructure;
using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;
using GymScheduler.Application.Services;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureInfrastructureApp(builder.Configuration);
builder.Services.ConfigureApplicationApp();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRateLimiter(options =>
{
    options.AddFixedWindowLimiter("fixed", opt =>
    {
        opt.PermitLimit = 100;
        opt.Window = TimeSpan.FromMinutes(1);
        opt.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
        opt.QueueLimit = 10;
    });
});

var path = "/etc/secrets";

if (Directory.Exists(path))
{
    foreach (var file in Directory.GetFiles(path))
    {
        Console.WriteLine($"Secret file encontrado: {file}");
    }
}
else
{
    Console.WriteLine("/etc/secrets não existe");
}

if (File.Exists("/etc/secrets/.env"))
{
    Env.Load("/etc/secrets/.env");
}
else
{
    Env.Load();
}

Console.WriteLine(builder.Configuration["ApiPwd"]);

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers().RequireRateLimiting("fixed");

app.UseRateLimiter();

app.Run();
