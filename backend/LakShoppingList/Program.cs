var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors("AllowFrontend");

var shoppingList = new List<string>();

app.MapGet("/", () => "Lak Shopping List backend is running");

app.MapGet("/items", () => shoppingList);

app.MapPost("/add/{item}", (string item) =>
{
    shoppingList.Add(item);
    return Results.Ok(new { message = $"{item} added", items = shoppingList });
});

app.Run("http://0.0.0.0:5000");