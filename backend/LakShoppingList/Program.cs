var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<string> shoppingList = new List<string>();

app.MapGet("/", () => "Lak Shopping List App is running!");

app.MapGet("/items", () => shoppingList);

app.MapPost("/add/{item}", (string item) =>
{
    shoppingList.Add(item);
    return $"Added {item}";
});

app.Run();
