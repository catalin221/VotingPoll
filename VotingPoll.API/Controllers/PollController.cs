using Microsoft.AspNetCore.Mvc;
using VotingPoll.Infrastructure.Database;

namespace VotingPoll.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PollController : Controller
    {
        private readonly PollContext _context;
        private readonly ILogger _logger;

        public PollController(PollContext context, ILogger<PollContext> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllPolls()
        {
            var polls = _context.Polls.ToList();

            _logger.LogInformation("Seeded data:");
            foreach (var poll in polls)
            {
                _logger.LogInformation($"Poll: {poll.Id}, {poll.Title}, {poll.Description}");
            }

            return Ok(polls);
        }
    }
}
