using catsapi.Data;
using catsapi.Data.EFCore;
using catsapi.Models;
using catsapi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IRepository<Cat>, EFCoreCatRepository>();
builder.Services.AddScoped<IService, CatService>();
builder.Services.AddDbContext<CatContext>(opt =>
    opt.UseInMemoryDatabase("CatDatabase"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();
