using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class UserPollDTO
    {
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public int PollId { get; set; }
        public PollDTO Poll { get; set; }
    }
}