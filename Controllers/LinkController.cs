using Labb4__API.Models;
using Labb4__API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb4__API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkRepository _linkRepository;

        public LinkController(ILinkRepository linkRepository)
        {
            _linkRepository = linkRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Link>>> GetAllLinks()
        {
            var links = await _linkRepository.GetAllLinks();
            return Ok(links);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Link>> GetLinkById(int id)
        {
            var link = await _linkRepository.GetLinkById(id);
            if (link == null)
            {
                return NotFound();
            }
            return Ok(link);
        }
    }
}

