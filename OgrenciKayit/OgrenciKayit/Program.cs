using Microsoft.EntityFrameworkCore;
using OgrenciKayit.Models;  // Burada kendi namespace'ini do�ru yaz!

var builder = WebApplication.CreateBuilder(args);

// --- BURASI �NEML� ---
builder.Services.AddDbContext<OgrDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
// ---------------------

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Ogrenciler}/{action=Listele}/{id?}");

app.Run();
