using VotingPoll.Application.DTO;

namespace VotinPoll.Application.DTO
{
    public class OptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int VotesCount { get; set; }
        public List<UserDTO>? Users { get; set; }
    }
}
