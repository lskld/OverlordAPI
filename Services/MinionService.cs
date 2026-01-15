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

        public async Task<IEnumerable<Minion>> GetAllMinionsAsync()
        {
            return await _repository.GetAllAsync();
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
