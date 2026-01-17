using OverlordAPI.Models.Entities;

namespace OverlordAPI.Interfaces
{
    public interface IMissionRepository
    {
        Task<IEnumerable<Mission>> GetAllAsync();
        Task<Mission?> GetByIdAsync(int id);
        Task AddAsync(Mission mission);
        Task SaveAsync();
    }
}
