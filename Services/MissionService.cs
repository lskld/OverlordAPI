using OverlordAPI.Interfaces;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Services
{
    public class MissionService : IMissionService
    {
        private readonly IMissionRepository _repository;

        public MissionService(IMissionRepository repository)
        {
            _repository = repository;
        }
        public async Task<bool> CreateMissionAsync(Mission mission)
        {
            if (mission.Difficulty < 1 || mission.Difficulty > 10)
                return false;

            await _repository.AddAsync(mission);
            await _repository.SaveAsync();
            return true;
        }
    }
}
