using CrudApiConInterfaces.Interfaces;
using CrudApiConInterfaces.Models;
using System.Collections.Generic;
using System.Linq;

namespace CrudApiConInterfaces.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly List<Producto> _productos = new();

        public IEnumerable<Producto> GetAll() => _productos;

        public Producto? GetById(int id) => _productos.FirstOrDefault(p => p.Id == id);

        public void Add(Producto producto)
        {
            producto.Id = _productos.Count + 1;
            _productos.Add(producto);
        }

        public void Update(Producto producto)
        {
            var existente = GetById(producto.Id);
            if (existente != null)
            {
                existente.Nombre = producto.Nombre;
                existente.Precio = producto.Precio;
            }
        }

        public void Delete(int id)
        {
            var producto = GetById(id);
            if (producto != null)
                _productos.Remove(producto);
        }
    }
}