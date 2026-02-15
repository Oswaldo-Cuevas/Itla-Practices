using Microsoft.EntityFrameworkCore;
using SoundJournal.API.Data.Entities;

namespace SoundJournal.API.Data
{
    public class SoundJournalContext : DbContext
    {
        public SoundJournalContext(DbContextOptions<SoundJournalContext> options)
            : base(options)
        {
        }

        public DbSet<GuestSpeaker> GuestSpeakers { get; set; }
        public DbSet<PodcastEpisode> PodcastEpisodes { get; set; }
    }
}