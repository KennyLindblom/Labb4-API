using Labb4__API.Data;
using Labb4__API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb4__API.Services
{
    public class PersonRepository : IPersonRepository
    {
        private MyDbContext _dbContext;
        public PersonRepository(MyDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Link> AddLink(int personId, int interestId, string url)
        {
            var link = new Link
            {
                PersonId = personId,
                InterestId = interestId,
                Url = url
            };
            await _dbContext.Links.AddAsync(link);
            await _dbContext.SaveChangesAsync();

            return link;
        }

        public async Task<PersonInterest> AddPersonInterest(int personId, int interestId)
        {
            var personIntrest = new PersonInterest
            {
                PersonId = personId,
                InterestId = interestId
            };

            await _dbContext.PersonInterests.AddAsync(personIntrest);
            await _dbContext.SaveChangesAsync();

            return personIntrest;
        }

        public async Task<IEnumerable<Person>> GetAllPersons()
        {
            return await _dbContext.Persons.ToListAsync();
        }

        public async Task<IEnumerable<Intrest>> GetInterestsByPersonId(int personId)
        {
            var personInterests = await _dbContext.PersonInterests
                .Include(pi => pi.Interest)
                .Where(pi => pi.PersonId == personId)
                .Select(pi => pi.Interest)
                .ToListAsync();

            return personInterests;

        }

        public async Task<IEnumerable<Link>> GetLinksByPersonId(int personId)
        {
            var personLinks = await _dbContext.Links.
                Where(l => l.PersonId == personId).ToListAsync();

            return personLinks;
        }

        public async Task<Person> GetPersonByIdAsync(int id)
        {
            return await _dbContext.Persons.FindAsync(id);
        }
    }
}
