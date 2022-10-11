using Blazored.Modal;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WiredBrainCoffee.UI;
using WiredBrainCoffee.UI.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddBlazoredModal();
builder.Services.AddBlazorise()
  .AddBootstrapProviders()
  .AddFontAwesomeIcons();

builder.Services.AddHttpClient<IMenuService, MenuService>(client =>
    client.BaseAddress = new Uri("https://localhost:7289/"));
builder.Services.AddHttpClient<IContactService, ContactService>(client =>
    client.BaseAddress = new Uri("https://localhost:7289/"));
builder.Services.AddHttpClient<IOrderService, OrderService>(client =>
    client.BaseAddress = new Uri("https://localhost:7289/"));

await builder.Build().RunAsync();
