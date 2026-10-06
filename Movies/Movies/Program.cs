var builder = WebApplication.CreateBuilder(args);

// Servisleri ekle
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // .NET 9 standartları için app.MapStaticAssets yerine bu daha güvenlidir

app.UseRouting();

app.UseAuthorization();

// 1. Özel Rotalar (En üstte olmalı)
app.MapControllerRoute(
    name: "anasayfa",
    pattern: "anasayfa",
    defaults: new { controller = "Home", action = "anasayfa" });

app.MapControllerRoute(
    name: "hakkimizda",
    pattern: "about",
    defaults: new { controller = "Home", action = "about" });

app.MapControllerRoute(
    name: "film",
    pattern: "film",
    defaults: new { controller = "Home", action = "film" });

app.MapControllerRoute(
    name: "movieList",
    pattern: "movies/list",
    defaults: new { controller = "Home", action = "List" });

app.MapControllerRoute(
    name: "movieDetails",
    pattern: "movies/detay",
    defaults: new { controller = "Home", action = "Details" });

// 2. Varsayılan Rota (En altta olmalı)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();