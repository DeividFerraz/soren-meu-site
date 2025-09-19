using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a controllers com views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Usa arquivos estáticos (se você quiser CSS, JS etc.)
app.UseStaticFiles();

// Usa roteamento
app.UseRouting();

// Define rota padrão para MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
