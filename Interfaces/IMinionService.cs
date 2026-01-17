using OverlordAPI.Models.DTOs;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Interfaces
{
    public interface IMinionService
    {
        Task<IEnumerable<MinionReadDto>> GetAllMinionsAsync();
        Task<MinionReadDto?> GetMinionByIdAsync(int id);
        Task<bool> CreateMinionAsync(MinionCreateDto dto);
    }
}
