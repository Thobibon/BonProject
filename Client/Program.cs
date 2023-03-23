using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BonProject.Client;
using BonProject.CQRS.Queries;
using BonProject.CQRS.Commands;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ICommandsBus, CommandsBus>();
builder.Services.AddScoped(typeof(IQueryBus<,>), typeof(QueryBus<,>));

await builder.Build().RunAsync();
