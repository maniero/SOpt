//console
Write("Hello World!");

//web
var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => "Hello World");
app.Run();

//https://pt.stackoverflow.com/q/534133/101
