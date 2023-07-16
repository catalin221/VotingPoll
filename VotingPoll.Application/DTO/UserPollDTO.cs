using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class UserPollDTO
    {
        public int? UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int? PollId { get; set; }
        public string PollName { get; set; } = string.Empty;
        public string? PollDescription { get; set; }
        public bool IsClosed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}