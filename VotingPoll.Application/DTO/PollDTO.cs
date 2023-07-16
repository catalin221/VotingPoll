using Microsoft.Extensions.Options;
using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class PollDTO
    {
        public int? Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsClosed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<UserOptionDTO>? UserOptions { get; set; }
    }
}
