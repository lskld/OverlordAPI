using Microsoft.EntityFrameworkCore;
using OverlordAPI.Data;
using OverlordAPI.Interfaces;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Repositories
{
    public class MinionRepository : IMinionRepository
    {
        private readonly OverlordDbContext _context;

        public MinionRepository(OverlordDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Minion>> GetAllAsync()
        {
            return await _context.Minions.Include(m => m.EvilLair).ToListAsync();
        }

        public async Task<Minion?> GetByIdAsync(int id)
        {
            return await _context.Minions.Include(m => m.EvilLair).FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task AddAsync(Minion minion)
        {
            await _context.Minions.AddAsync(minion);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
