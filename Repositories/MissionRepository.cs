using Microsoft.EntityFrameworkCore;
using OverlordAPI.Data;
using OverlordAPI.Interfaces;
using OverlordAPI.Models.Entities;

namespace OverlordAPI.Repositories
{
    public class MissionRepository : IMissionRepository
    {
        private readonly OverlordDbContext _context;

        public MissionRepository(OverlordDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Mission>> GetAllAsync()
        {
            return await _context.Missions.Include(m => m.Minions).ToListAsync();
        }

        public async Task<Mission?> GetByIdAsync(int id)
        {
            return await _context.Missions.Include(m => m.Minions).FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task AddAsync(Mission mission)
        {
            await _context.Missions.AddAsync(mission); 
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
