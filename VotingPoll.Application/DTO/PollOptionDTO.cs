using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class PollOptionDTO
    {
        public int? PollId { get; set; }
        public string PollName { get; set; } = string.Empty;
        public string? PollDescription { get; set; } = string.Empty;
        public bool IsClosed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? OptionId { get; set; }
        public OptionDTO Option { get; set; }
    }
}