using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers com views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Usa arquivos est�ticos (se voc� quiser CSS, JS etc.)
app.UseStaticFiles();

// Usa roteamento
app.UseRouting();

// Define rota padr�o para MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
