using Labb4__API.Data;
using Labb4__API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4__API.Services
{
    public class LinkRepository : ILinkRepository
    {
        private MyDbContext _dbContext;
        public LinkRepository(MyDbContext context)
        {
            _dbContext = context;
        }
        public async Task<IEnumerable<Link>> GetAllLinks()
        {
            return await _dbContext.Links.ToListAsync();
        }

        public async Task<Link> GetLinkById(int id)
        {
            return await _dbContext.Links.FindAsync(id);
        }
    }
}
