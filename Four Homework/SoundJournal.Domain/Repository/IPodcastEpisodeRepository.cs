using SoundJournal.Domain.Entities;

namespace SoundJournal.Domain.Repository
{
    public interface IPodcastEpisodeRepository
    {
        Task<List<PodcastEpisode>> GetAll();
        Task<PodcastEpisode?> GetById(int id);
        Task Add(PodcastEpisode entity);
        Task Update(PodcastEpisode entity);
        Task Delete(int id);
    }
}