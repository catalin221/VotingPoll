using VotingPoll.Domain.Model;

namespace VotinPoll.Application.DTO
{
    public class OptionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int VotesCount { get; set; }
        public List<UserOption>? UserOptions { get; set;}
        public List<PollOption>? PollOptions { get; set;}
    }
}
