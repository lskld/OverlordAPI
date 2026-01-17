using OverlordAPI.Models.Entities;

namespace OverlordAPI.Interfaces
{
    public interface IMinionRepository
    {
        Task<IEnumerable<Minion>> GetAllAsync();
        Task<Minion?> GetByIdAsync(int id);
        Task AddAsync(Minion minion);
        Task SaveAsync();
    }
}
