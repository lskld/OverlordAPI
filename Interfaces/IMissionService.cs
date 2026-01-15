using OverlordAPI.Models.DTOs;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Interfaces
{
    public interface IMissionService
    {
        Task<bool> CreateMissionAsync(MissionCreateDto dto);
    }
}
