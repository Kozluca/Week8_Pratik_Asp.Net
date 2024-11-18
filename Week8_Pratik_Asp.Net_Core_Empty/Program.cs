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


//      Controllers : Kullan�c�dan gelen istekleri i�ler, uygun model ile etkile�ime ge�er ve gerekli verileri View�a ileterek kullan�c�ya yan�t sa�lar.
// G�revler: �� mant���n� uygular, model ve view aras�nda koordinasyonu sa�lar.

//      Model : Uygulaman�n veri yap�lar� ve i� mant���n� temsil eder. Genellikle veritaban� ile etkile�imde bulunur ve veriyi i�ler.
// G�revler: Veritaban� i�lemleri, i� mant���, veri do�rulama.

//      View: Kullan�c� aray�z�n� (UI) temsil eder ve kullan�c�ya veri sunar. Modelden ald��� verileri kullan�c�ya g�rsel olarak sunar.
// G�revler: HTML, CSS ve JavaScript kullanarak kullan�c� aray�z�n� olu�turur ve veriyi g�rselle�tirir.

//      Razor: Razor S�zdizimi MVC uygulamalar�m�z i�erisinde kolay bir �ekilde HTML �retmemize yard�mc� olur.

//      RazorView : RazorView ile View de g�stermek istedi�imiz action � se�eriz.

//      wwwroot: Projenizdeki t�m statik dosyalar bu klas�re gider. Bunlar, HTML dosyalar�, CSS dosyalar�, resim dosyalar� ve JavaScript dosyalar� dahil olmak �zere
//uygulaman�n do�rudan istemcilere sunaca�� varl�klard�r.
//      builder.Build(): Yap�land�r�lm�� uygulamay� olu�turur
//      app.Run() Uygulamay� ba�lat�r
