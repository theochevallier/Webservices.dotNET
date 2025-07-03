// using Microsoft.EntityFrameworkCore;
using APIWebServices.Data;
using APIWebServices.Repository;
using APIWebServices.Service;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Ajout de la connexion à la base de données
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseInMemoryDatabase("UsersDB"));

// Injection des services
// builder.Services.AddScoped<UserRepository>();
// builder.Services.AddScoped<UserService>();

builder.Services.AddSingleton<UserService>();

// Ajout des contrôleurs
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "API WebServices", Version = "v1" });
    var xmlFile = Path.Combine(AppContext.BaseDirectory, "APIWebServices.xml");
    c.IncludeXmlComments(xmlFile);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();
