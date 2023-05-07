using Labb4__API.Models;
using Labb4__API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb4__API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntrestController : ControllerBase
    {
        private readonly IInterestRepository _intrestRepository;

        public IntrestController(IInterestRepository intrestRepository)
        {
            _intrestRepository = intrestRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Intrest>> GetAllIntrests()
        {
            return await _intrestRepository.GetAllInterests();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Intrest>> GetIntrestById(int id)
        {
            var intrest = await _intrestRepository.GetInterestById(id);

            if (intrest == null)
            {
                return NotFound();
            }

            return intrest;
        }

        
    }
}
