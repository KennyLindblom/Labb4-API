using Labb4__API.Models;

namespace Labb4__API.Services
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetAllPersons();
        Task<Person> GetPersonByIdAsync(int id);
        Task<IEnumerable<Intrest>> GetInterestsByPersonId(int personId);
        Task<IEnumerable<Link>> GetLinksByPersonId(int personId);
        Task<PersonInterest> AddPersonInterest(int personId, int interestId);
        Task<Link> AddLink(int personId, int interestId, string url);
    }


}

