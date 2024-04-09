using Contractors.Site.Configuration;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using RepositoryLayer.SeedData;
using System.Diagnostics.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//Add Service Configuration
builder.Services.AddWebServiceCollection(builder.Configuration);
var app = builder.Build();
//Get Services
var scope = app.Services.CreateScope();
var service = scope.ServiceProvider;

var loggerFactory = app.Services.GetService<ILoggerFactory>();
var context = service.GetRequiredService<ApplicationDBContext>();
// Auto Migration
try
{
    await context.Database.MigrateAsync();
    await GenerateFakeData.SeedDataAsync(context,loggerFactory);
}
catch (Exception ex)
{
    var  logger = loggerFactory.CreateLogger<ApplicationDBContext>();
    logger.LogError(ex, "Error Exception Logger For Migration");

    throw;
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
