using Microsoft.EntityFrameworkCore;
using SoundJournal.Domain.Entities;
using SoundJournal.Domain.Repository;
using SoundJournal.Infrastructure.Context;

namespace SoundJournal.Infrastructure.Repositories
{
    public class PodcastEpisodeRepository : IPodcastEpisodeRepository
    {
        private readonly SoundJournalContext _context;

        public PodcastEpisodeRepository(SoundJournalContext context)
        {
            _context = context;
        }

        public async Task<List<PodcastEpisode>> GetAll()
        {
            return await _context.PodcastEpisodes.ToListAsync();
        }

        public async Task<PodcastEpisode?> GetById(int id)
        {
            return await _context.PodcastEpisodes.FindAsync(id);
        }

        public async Task Add(PodcastEpisode entity)
        {
            _context.PodcastEpisodes.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(PodcastEpisode entity)
        {
            _context.PodcastEpisodes.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _context.PodcastEpisodes.FindAsync(id);
            if (entity != null)
            {
                _context.PodcastEpisodes.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}