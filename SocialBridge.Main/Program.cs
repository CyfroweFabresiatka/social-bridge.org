using SocialBridge.Main.Features.Projects;
using SocialBridge.Main.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

// Add services to the container.
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();
services.AddCors();
    
DiContainerConfig.AddDatabase(builder.Services, builder.Configuration);
DiContainerConfig.AddServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapGet("/", () => "Hello from World");
var api = app.MapGroup("/api/v1");
api.MapProjects();
api.MapCompanies();

app.Run();