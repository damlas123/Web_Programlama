var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Session ekliyoruz
builder.Services.AddSession(options=>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); //oturum süresi işlem yapılmadığında 30 dakika sonra oturumun kapanması için 
    //options.Cookie.HttpOnly = true; //cookie sadece http üzerinden erişilebilir olacak. Localde yapılan değişiklikler server tarafından algılanmayacak.
    //options.Cookie.IsEssential = true; //Kullanıcı hiçbir şeyi kabul etmese bile oturumun çalışması için gerekli olan cookie.
}
    );

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
//Tanımlanan sessionu kullanmak için ekliyoruz.
app.UseSession();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
