using Microsoft.AspNetCore.RateLimiting;
using Microsoft.Extensions.Primitives;
using System.Diagnostics;
using System.Threading.RateLimiting;
using WiredBrainCoffee.MinApi.Services;
using WiredBrainCoffee.MinApi.Services.Interfaces;
using WiredBrainCoffee.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IMenuService, MenuService>();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

var mobileAPI = app.MapGroup("/api").AddEndpointFilter(async (context, next) =>
{
    StringValues deviceType;
    context.HttpContext.Request.Headers.TryGetValue("x-device-type", out deviceType);
    if (deviceType != "mobile")
    {
        return Results.BadRequest();
    }

    var result = await next(context);

    Debug.WriteLine("after");

    return result;
});

app.MapGet("/orders", (IOrderService orderService) =>
{
    return Results.Ok(orderService.GetOrders());
});

app.MapGet("/orderById", (IOrderService orderService, int id) =>
{
    return Results.Ok(orderService.GetOrderById(id));
})
.WithOpenApi();

app.MapPost("/contact", (Contact contact) =>
{
    // save contact to database
});

app.MapGet("/menu", (IMenuService menuService) =>
{
    return menuService.GetMenuItems();
});

app.MapPost("/upload", async (IFormFile file) =>
{
    using var stream = File.OpenWrite("upload.jpg");
    await file.CopyToAsync(stream);
});

mobileAPI.MapPost("/survey", ([AsParameters]SurveyResults results) =>
{
    // Todo: save to db
    return "Thank you!";
});

mobileAPI.MapGet("/rewards", () =>
{
    return "SecretDiscount!";
});

app.Run();
