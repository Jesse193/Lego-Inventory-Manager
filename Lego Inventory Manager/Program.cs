using LegoInventoryManager.Controllers;
using LegoInventoryManager.DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ILegoApiService, LegoApiService>();
builder.Services.AddHttpClient();
var apiKey = builder.Configuration["API_KEY"];

builder.Services.AddDbContext<LegoInventoryManagerContext>(options =>
    options.UseNpgsql(builder.Configuration["DB_password"] ?? throw new InvalidOperationException("Connection string 'LegoInventoryManagerDB' not found.")).UseSnakeCaseNamingConvention());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
