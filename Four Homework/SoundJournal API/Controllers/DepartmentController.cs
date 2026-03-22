using Microsoft.AspNetCore.Mvc;
using SoundJournal.Application.Contract;
using SoundJournal.Application.Dtos;

namespace SoundJournal.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _service;

        public DepartmentController(IDepartmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _service.GetAll();
            return Ok(result.Data);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _service.GetById(id);
            if (!result.Success) return NotFound(result.Message);
            return Ok(result.Data);
        }

        [HttpPost]
        public IActionResult Add([FromBody] DepartmentDto dto)
        {
            var result = _service.Add(dto);
            if (!result.Success) return BadRequest(result.Message);
            return Ok(result.Message);
        }
    }
}