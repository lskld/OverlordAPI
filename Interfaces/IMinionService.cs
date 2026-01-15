using OverlordAPI.Models.DTOs;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Interfaces
{
    public interface IMinionService
    {
        Task<IEnumerable<Minion>> GetAllMinionsAsync();
        Task<bool> CreateMinionAsync(MinionCreateDto dto);
    }
}
