using CrudApiConInterfaces.Interfaces;
using CrudApiConInterfaces.Models;
using Microsoft.AspNetCore.Mvc;

namespace CrudApiConInterfaces.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoRepository _repo;

        public ProductosController(IProductoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_repo.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var producto = _repo.GetById(id);
            return producto == null ? NotFound() : Ok(producto);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            _repo.Add(producto);
            return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            producto.Id = id;
            _repo.Update(producto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return NoContent();
        }
    }
}