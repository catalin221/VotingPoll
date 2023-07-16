using VotinPoll.Application.DTO;

namespace VotingPoll.Application.DTO
{
    public class UserOptionDTO
    {
        public int? UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public int? OptionId { get; set; }
        public string OptionName { get; set; } = string.Empty;
    }
}