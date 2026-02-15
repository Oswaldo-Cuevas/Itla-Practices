using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoundJournal.API.Data;
using SoundJournal.API.Data.Entities;
using SoundJournal.API.Models.DTOs;

namespace SoundJournal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodcastEpisodesController : ControllerBase
    {
        private readonly SoundJournalContext _context;

        public PodcastEpisodesController(SoundJournalContext context)
        {
            _context = context;
        }

        // GET: api/PodcastEpisodes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var episodes = await _context.PodcastEpisodes
                .Include(p => p.GuestSpeaker)
                .ToListAsync();

            return Ok(episodes);
        }

        // GET: api/PodcastEpisodes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var episode = await _context.PodcastEpisodes
                .Include(p => p.GuestSpeaker)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (episode == null)
                return NotFound();

            return Ok(episode);
        }

        // POST
        [HttpPost]
        public async Task<IActionResult> Post(PodcastEpisodeDto dto)
        {
            var episode = new PodcastEpisode
            {
                Title = dto.Title,
                Description = dto.Description,
                DurationMinutes = dto.DurationMinutes,
                ReleaseDate = dto.ReleaseDate,
                GuestSpeakerId = dto.GuestSpeakerId
            };

            _context.PodcastEpisodes.Add(episode);
            await _context.SaveChangesAsync();

            return Ok(episode);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PodcastEpisodeDto dto)
        {
            var episode = await _context.PodcastEpisodes.FindAsync(id);

            if (episode == null)
                return NotFound();

            episode.Title = dto.Title;
            episode.Description = dto.Description;
            episode.DurationMinutes = dto.DurationMinutes;
            episode.ReleaseDate = dto.ReleaseDate;
            episode.GuestSpeakerId = dto.GuestSpeakerId;

            await _context.SaveChangesAsync();

            return Ok(episode);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var episode = await _context.PodcastEpisodes.FindAsync(id);

            if (episode == null)
                return NotFound();

            _context.PodcastEpisodes.Remove(episode);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}