using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundJournal.Domain.Entities
{
    public class PodcastEpisode
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public int DurationMinutes { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int GuestSpeakerId { get; set; }

        [ForeignKey("GuestSpeakerId")]
        public GuestSpeaker? GuestSpeaker { get; set; }
    }
}