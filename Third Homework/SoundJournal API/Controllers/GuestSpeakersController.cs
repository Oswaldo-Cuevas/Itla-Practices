using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoundJournal.API.Data;
using SoundJournal.API.Data.Entities;
using SoundJournal.API.Models.DTOs;

namespace SoundJournal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestSpeakersController : ControllerBase
    {
        private readonly SoundJournalContext _context;

        public GuestSpeakersController(SoundJournalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.GuestSpeakers.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Post(GuestSpeakerDto dto)
        {
            var speaker = new GuestSpeaker
            {
                Name = dto.Name,
                Expertise = dto.Expertise,
                Email = dto.Email
            };

            _context.GuestSpeakers.Add(speaker);
            await _context.SaveChangesAsync();

            return Ok(speaker);
        }
    }
}