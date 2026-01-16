using OverlordAPI.Interfaces;
using OverlordAPI.Models.DTOs;
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
        public async Task<bool> CreateMissionAsync(MissionCreateDto dto)
        {
            if (dto.Difficulty < 1 || dto.Difficulty > 10)
                return false;

            var mission = new Mission
            {
                Title = dto.Title,
                Difficulty = dto.Difficulty,
                isCompleted = dto.isCompleted
            };

            await _repository.AddAsync(mission);
            await _repository.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<MissionReadDto>> GetAllMissionsAsync()
        {
            var missions = await _repository.GetAllAsync();

            return missions.Select(m => new MissionReadDto
            {
                Id = m.Id,
                Title = m.Title,
                Difficulty = m.Difficulty,
                isCompleted = m.isCompleted
            });
        }

        public async Task<MissionReadDto?> GetMissionByIdAsync(int id)
        {
            var mission = await _repository.GetByIdAsync(id);

            if (mission == null)
                return null;

            return new MissionReadDto
            {
                Id = mission.Id,
                Title = mission.Title,
                Difficulty = mission.Difficulty,
                isCompleted = mission.isCompleted
            };
        }
    }
}
