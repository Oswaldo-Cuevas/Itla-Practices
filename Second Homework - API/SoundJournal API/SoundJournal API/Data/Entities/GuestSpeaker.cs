using System.ComponentModel.DataAnnotations;

namespace SoundJournal.API.Data.Entities
{
    public class GuestSpeaker
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Expertise { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public List<PodcastEpisode> PodcastEpisodes { get; set; } = new List<PodcastEpisode>();
    }
}