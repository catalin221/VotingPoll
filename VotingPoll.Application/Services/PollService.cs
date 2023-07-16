using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VotingPoll.Application.DTO;
using VotingPoll.Infrastructure.Database;
using VotinPoll.Application.DTO;

namespace VotingPoll.Application.Services
{
    public class PollService
    {
        private readonly PollContext _context;
        private readonly IMapper _mapper;

        public PollService(PollContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<PollDTO> GetAllPolls()
        {
            var polls = _context.Polls
                .Include(p => p.UserOptions)
                    .ThenInclude(uo => uo.Option)
                .Include(p => p.UserOptions)
                    .ThenInclude(uo => uo.User)
                .ToList();

            var pollDTOs = polls.Select(poll => new PollDTO
            {
                Id = poll.Id,
                Title = poll.Title,
                Description = poll.Description,
                IsClosed = poll.IsClosed,
                StartDate = poll.StartDate,
                EndDate = poll.EndDate,
                UserOptions = poll.UserOptions.Select(uo => new UserOptionDTO
                {
                    UserId = uo.UserId,
                    UserName = uo.User.Name,
                    OptionId = uo.OptionId,
                    OptionName = uo.Option.Name
                }).ToList()
            }).ToList();

            return pollDTOs;
        }
    }
}
