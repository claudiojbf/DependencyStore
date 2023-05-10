using DependencyStore;
using DependencyStore.Extencions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Configuration>();
var connStr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddSqlConnection(connStr);
builder.Services.AddRepositories();
builder.Services.AddServices();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
