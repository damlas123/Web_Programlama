var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Kitap}/{action=Listele}/{id?}") // Program ilk çalıştığında hangi controller hangi index gelecek onu belirler eğer id parametresi yoksa varsayılan olarak Home controller'ının Index action'ına yönlendirir
    .WithStaticAssets();  //Normalde indexdi ben privacy controller'ına yönlendirdim. Yani uygulama ilk açıldığında Privacy action'ı çalışacak.


app.Run();
