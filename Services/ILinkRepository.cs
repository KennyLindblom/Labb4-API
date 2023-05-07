using Labb4__API.Models;

namespace Labb4__API.Services
{
    public interface ILinkRepository
    {
        Task<IEnumerable<Link>> GetAllLinks();
        Task<Link> GetLinkById(int id);
    }
}
