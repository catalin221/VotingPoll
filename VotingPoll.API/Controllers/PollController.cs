using Microsoft.AspNetCore.Mvc;
using VotingPoll.Application.Services;
using VotingPoll.Infrastructure.Database;

namespace VotingPoll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollController : ControllerBase
    {
        private readonly PollContext _context;
        private readonly PollService _pollService;

        public PollController(PollContext context, PollService pollService)
        {
            _context = context;
            _pollService = pollService;
        }

        [HttpGet]
        public IActionResult GetAllPolls()
        {
            var polls = _pollService.GetAllPolls();

            return Ok(polls);
        }
    }
}
