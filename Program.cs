using Microsoft.EntityFrameworkCore;
using WebsiteProject.Components;
using WebsiteProject.Data;
using WebsiteProject.Services;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "app.db");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));
builder.Services.AddSingleton<AppState>();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
  
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (db.EnergyDrinks.Any())
    {
        db.EnergyDrinks.RemoveRange(db.EnergyDrinks);
        db.SaveChanges();
    }

    Seeder.Seed(db);
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
