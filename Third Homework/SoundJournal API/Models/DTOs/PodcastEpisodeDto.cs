namespace SoundJournal.API.Models.DTOs
{
    public class PodcastEpisodeDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int GuestSpeakerId { get; set; }
    }
}