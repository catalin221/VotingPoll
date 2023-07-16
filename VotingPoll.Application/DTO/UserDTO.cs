using VotingPoll.Application.DTO;

namespace VotinPoll.Application.DTO
{
    public class UserDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<UserOptionDTO>? UserOptions { get; set; }
        public List<UserPollDTO>? UserPolls { get; set; }
    }
}
