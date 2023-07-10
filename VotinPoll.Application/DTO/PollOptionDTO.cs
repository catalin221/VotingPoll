using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class PollOptionDTO
    {
        public int PollId { get; set; }
        public PollDTO Poll { get; set; }
        public int OptionId { get; set; }
        public OptionDTO Option { get; set; }
    }
}