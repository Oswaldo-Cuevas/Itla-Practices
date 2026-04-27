using CrudBlazorCliente;
using CrudBlazorCliente.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Componente raíz
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient apuntando al API (ajusta el puerto al que usa tu API)
// Usa el mismo puerto que aparece en la salida de tu API: 7098 (HTTPS) o 5080 (HTTP)
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7098/") // si HTTPS falla, cambia a "http://localhost:5080/"
});

// Registrar el servicio de productos
builder.Services.AddScoped<ProductoService>();

await builder.Build().RunAsync();