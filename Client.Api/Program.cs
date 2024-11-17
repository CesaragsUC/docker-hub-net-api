using ObterRepositorioDockerHub.Configurations;
using ObterRepositorioDockerHub.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDockerHubService,DockerHubService>();

builder.Services.AddHttpClient();

builder.Services.Configure<DockerHubSettings>(builder.Configuration.GetSection("DockerHubSettings"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
