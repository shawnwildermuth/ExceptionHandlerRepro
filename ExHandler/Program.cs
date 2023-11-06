using ExHandler;
using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

var app = builder.Build();

app.UseExceptionHandler();           // Doesn't Work
//app.UseExceptionHandler(o => { }); // Works

app.MapGet("/", () => {
  throw new Exception("Bad things happen to good developers");
});

app.Run();
