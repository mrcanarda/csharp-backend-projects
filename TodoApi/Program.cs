using TodoApi.Middleware;
using TodoApi.Services;
var builder = WebApplication.CreateBuilder(args); 

builder.Services.AddControllers(); 
builder.Services.AddOpenApi(); 

builder.Services.AddScoped<ITodoService, TodoService>();

var app = builder.Build(); 

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
}

app.UseHttpsRedirection(); 
app.UseMiddleware<RequestLoggingMiddleware>(); //add this 
app.MapControllers(); 

app.Run(); 