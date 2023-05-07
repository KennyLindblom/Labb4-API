using Labb4__API.Data;
using Labb4__API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4__API.Services
{


    public class IntrestRepository : IInterestRepository
    {
        private MyDbContext _dbContext;
        public IntrestRepository(MyDbContext context)
        {
            _dbContext = context;
        }
        public async Task<IEnumerable<Intrest>> GetAllInterests()
        {
            return await _dbContext.Interests.ToListAsync();
        }

        public async Task<Intrest> GetInterestById(int id)
        {
            return await _dbContext.Interests.FindAsync(id);
        }

        public async Task<Intrest> AddIntrest(Intrest intrest)
        {
            _dbContext.Interests.Add(intrest);
            await _dbContext.SaveChangesAsync();
            return intrest;
        }


    }
}
