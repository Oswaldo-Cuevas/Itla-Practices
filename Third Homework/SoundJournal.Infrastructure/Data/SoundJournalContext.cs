using Microsoft.EntityFrameworkCore;
using SoundJournal.Domain.Entities;

namespace SoundJournal.Infrastructure.Data
{
    public class SoundJournalContext : DbContext
    {
        public SoundJournalContext(DbContextOptions<SoundJournalContext> options)
            : base(options)
        {
        }

        // Ejemplo
        public DbSet<PodcastEpisode> PodcastEpisodes { get; set; }
    }
}