using Microsoft.AspNetCore.ResponseCompression;
using BonProject.Server.Contexte;
using Microsoft.EntityFrameworkCore;
using BonProject.CQRS.Commands;
using BonProject.CQRS.Queries;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

builder.Services.AddScoped<ICommandsBus, CommandsBus>();
builder.Services.AddScoped(typeof(IQueryBus<,>), typeof(QueryBus<,>));

// Init Database

builder.Services.AddDbContext<BonProjectDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("MyDatabase")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
