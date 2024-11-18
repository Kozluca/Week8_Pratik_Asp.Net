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
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//      Controllers : Kullanýcýdan gelen istekleri iþler, uygun model ile etkileþime geçer ve gerekli verileri View’a ileterek kullanýcýya yanýt saðlar.
// Görevler: Ýþ mantýðýný uygular, model ve view arasýnda koordinasyonu saðlar.

//      Model : Uygulamanýn veri yapýlarý ve iþ mantýðýný temsil eder. Genellikle veritabaný ile etkileþimde bulunur ve veriyi iþler.
// Görevler: Veritabaný iþlemleri, iþ mantýðý, veri doðrulama.

//      View: Kullanýcý arayüzünü (UI) temsil eder ve kullanýcýya veri sunar. Modelden aldýðý verileri kullanýcýya görsel olarak sunar.
// Görevler: HTML, CSS ve JavaScript kullanarak kullanýcý arayüzünü oluþturur ve veriyi görselleþtirir.

//      Razor: Razor Sözdizimi MVC uygulamalarýmýz içerisinde kolay bir þekilde HTML üretmemize yardýmcý olur.

//      RazorView : RazorView ile View de göstermek istediðimiz action ý seçeriz.

//      wwwroot: Projenizdeki tüm statik dosyalar bu klasöre gider. Bunlar, HTML dosyalarý, CSS dosyalarý, resim dosyalarý ve JavaScript dosyalarý dahil olmak üzere
//uygulamanýn doðrudan istemcilere sunacaðý varlýklardýr.
//      builder.Build(): Yapýlandýrýlmýþ uygulamayý oluþturur
//      app.Run() Uygulamayý baþlatýr
