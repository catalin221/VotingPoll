using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class UserOptionDTO
    {
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public int OptionId { get; set; }
        public OptionDTO Option { get; set; }
    }
}