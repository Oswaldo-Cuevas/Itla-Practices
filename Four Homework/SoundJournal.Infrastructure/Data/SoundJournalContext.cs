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

        public DbSet<PodcastEpisode> PodcastEpisodes { get; set; }
        public DbSet<GuestSpeaker> GuestSpeakers { get; set; }
        public DbSet<Department> Departments { get; set; } // 👈 agrega si usas Department
    }