using Labb4__API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb4__API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            var persons = await _personRepository.GetAllPersons();

            return Ok(persons);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonById(int id)
        {
            var person = await _personRepository.GetPersonByIdAsync(id);

            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        [HttpGet("{id}/interests")]
        public async Task<IActionResult> GetInterestsByPersonId(int id)
        {
            var interests = await _personRepository.GetInterestsByPersonId(id);

            if (interests == null)
            {
                return NotFound();
            }

            return Ok(interests);
        }

        [HttpGet("{id}/links")]
        public async Task<IActionResult> GetLinksByPersonId(int id)
        {
            var links = await _personRepository.GetLinksByPersonId(id);

            if (links == null)
            {
                return NotFound();
            }

            return Ok(links);
        }

        [HttpPost("{personId}/interests/{interestId}")]
        public async Task<IActionResult> AddPersonInterest(int personId, int interestId)
        {
            var personInterest = await _personRepository.AddPersonInterest(personId, interestId);

            return CreatedAtAction(nameof(GetPersonById), new { id = personId }, personInterest);
        }

        [HttpPost("{personId}/interests/{interestId}/links")]
        public async Task<IActionResult> AddLink(int personId, int interestId, [FromBody] string url)
        {
            var link = await _personRepository.AddLink(personId, interestId, url);

            return CreatedAtAction(nameof(GetLinksByPersonId), new { id = link.Id }, link);
        }
    }
}
