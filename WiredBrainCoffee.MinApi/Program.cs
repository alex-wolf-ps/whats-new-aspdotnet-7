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

app.MapGet("/orders", (IOrderService orderService) =>
{
    return Results.Ok(orderService.GetOrders());
});

app.MapGet("/orderById", (IOrderService orderService, int id) =>
{
    return Results.Ok(orderService.GetOrderById(id));
});

app.MapPost("/contact", (Contact contact) =>
{
    // save contact to database
});

app.MapGet("/menu", (IMenuService menuService) =>
{
    return menuService.GetMenuItems();
}); ;

app.Run();
