using Microsoft.AspNetCore.Mvc;
using SoundJournal.Domain.Entities;
using SoundJournal.Domain.Repository;
using SoundJournal.API.Models.DTOs;

namespace SoundJournal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PodcastEpisodesController : ControllerBase
    {
        private readonly IPodcastEpisodeRepository _repository;

        public PodcastEpisodesController(IPodcastEpisodeRepository repository)
        {
            _repository = repository;
        }

        // GET: api/PodcastEpisodes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var episodes = await _repository.GetAll();
            return Ok(episodes);
        }

        // GET: api/PodcastEpisodes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var episode = await _repository.GetById(id);

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

            await _repository.Add(episode);

            return Ok(episode);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PodcastEpisodeDto dto)
        {
            var episode = await _repository.GetById(id);

            if (episode == null)
                return NotFound();

            episode.Title = dto.Title;
            episode.Description = dto.Description;
            episode.DurationMinutes = dto.DurationMinutes;
            episode.ReleaseDate = dto.ReleaseDate;
            episode.GuestSpeakerId = dto.GuestSpeakerId;

            await _repository.Update(episode);

            return Ok(episode);
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.Delete(id);
            return Ok();
        }
    }
}