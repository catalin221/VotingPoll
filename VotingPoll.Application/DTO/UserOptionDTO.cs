using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class UserOptionDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int OptionId { get; set; }
        public string OptionName { get; set; }
    }
}