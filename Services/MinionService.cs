using OverlordAPI.Interfaces;
using OverlordAPI.Models.DTOs;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Services
{
    public class MinionService : IMinionService
    {
        private readonly IMinionRepository _repository;

        public MinionService(IMinionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<MinionReadDto>> GetAllMinionsAsync()
        {
            var minions = await _repository.GetAllAsync();

            return minions.Select(m => new MinionReadDto
            {
                Id = m.Id,
                Name = m.Name,
                Description = m.Description,
                Type = m.Type.ToString(),
                EvilLevel = m.EvilLevel,
                EvilLairName = m.EvilLair?.Name ?? string.Empty
            });
        }

        public async Task<bool> CreateMinionAsync(MinionCreateDto dto)
        {
            if (dto.EvilLevel < 1 || dto.EvilLevel > 10)
                return false;

            var minion = new Minion
            {
                Name = dto.Name,
                Description = dto.Description,
                Type = dto.Type,
                EvilLevel = dto.EvilLevel,
                EvilLairId = dto.EvilLairId
            };

            await _repository.AddAsync(minion);
            await _repository.SaveAsync();
            return true;
        }
    }
}
