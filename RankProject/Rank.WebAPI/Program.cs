var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! pack_1 modificado pelo codex");

app.Run();
