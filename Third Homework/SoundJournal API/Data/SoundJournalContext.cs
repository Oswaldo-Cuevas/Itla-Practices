using Microsoft.EntityFrameworkCore;
using SoundJournal.Domain.Entities;

namespace SoundJournal.Infrastructure.Context
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