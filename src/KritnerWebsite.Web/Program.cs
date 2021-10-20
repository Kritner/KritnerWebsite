using Kritner.SolarProjection.Interfaces;
using Kritner.SolarProjection.Services;
using Microsoft.AspNetCore.HttpOverrides;
using OwaspHeaders.Core.Extensions;

var builder = WebApplication.CreateBuilder(args);
if (!builder.Environment.IsDevelopment())
{
    builder.WebHost.UseUrls("http://*:5000");
    builder.WebHost.UseKestrel();
}

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IProjectFutureEnergyCostService, ProjectFutureEnergyCostService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseSecureHeadersMiddleware(
        SecureHeadersMiddlewareExtensions.BuildDefaultConfiguration()
    );
}

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
