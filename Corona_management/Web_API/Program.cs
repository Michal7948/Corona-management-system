using AppServices;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");


app.UseCors(options =>
{
    options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
});



app.MapControllers();

app.Run();

