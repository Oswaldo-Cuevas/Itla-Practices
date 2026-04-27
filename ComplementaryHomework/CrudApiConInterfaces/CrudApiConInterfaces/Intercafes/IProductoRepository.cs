using CrudApiConInterfaces.Models;
using System.Collections.Generic;

namespace CrudApiConInterfaces.Interfaces
{
    public interface IProductoRepository
    {
        IEnumerable<Producto> GetAll();
        Producto? GetById(int id);
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}

