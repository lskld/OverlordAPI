using OverlordAPI.Interfaces;
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

        public async Task<bool> CreateMinionAsync(Minion minion)
        {
            if (minion.EvilLevel < 1 || minion.EvilLevel > 10)
                return false;

            await _repository.AddAsync(minion);
            await _repository.SaveAsync();
            return true;
        }
    }
}
