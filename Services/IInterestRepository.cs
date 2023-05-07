using Labb4__API.Models;

namespace Labb4__API.Services
{
    public interface IInterestRepository
    {
        Task<IEnumerable<Intrest>> GetAllInterests();
        Task<Intrest> GetInterestById(int id);
    }
}
