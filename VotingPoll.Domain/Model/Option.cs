namespace VotingPoll.Domain.Model
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int VotesCount { get; set; } = 0;
        public int PollId { get; set; }
        public Poll Poll { get; set; }
        public ICollection<UserOption>? UserOptions { get; set; }
        public ICollection<PollOption>? PollOptions { get; set; }
    }
}