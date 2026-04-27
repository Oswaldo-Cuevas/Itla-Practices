using CrudBlazorCliente.Models;
using System.Net.Http.Json;

namespace CrudBlazorCliente.Services
{
    public class ProductoService
    {
        private readonly HttpClient _http;

        public ProductoService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Producto>> GetProductos()
            => await _http.GetFromJsonAsync<List<Producto>>("api/productos");

        public async Task<Producto?> GetProducto(int id)
            => await _http.GetFromJsonAsync<Producto>($"api/productos/{id}");

        public async Task CrearProducto(Producto producto)
            => await _http.PostAsJsonAsync("api/productos", producto);

        public async Task ActualizarProducto(Producto producto)
            => await _http.PutAsJsonAsync($"api/productos/{producto.Id}", producto);

        public async Task EliminarProducto(int id)
            => await _http.DeleteAsync($"api/productos/{id}");
    }
}