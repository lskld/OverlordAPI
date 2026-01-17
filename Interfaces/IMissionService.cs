using OverlordAPI.Models.DTOs;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Interfaces
{
    public interface IMissionService
    {
        Task<IEnumerable<MissionReadDto>> GetAllMissionsAsync();
        Task<MissionReadDto?> GetMissionByIdAsync(int id);
        Task<bool> CreateMissionAsync(MissionCreateDto dto);
        Task<IEnumerable<MinionReadDto>?> GetMinionsInMissionAsync(int id);
        Task<bool> AssignMinionToMissionAsync(int minionId, int missionId);
    }
}
