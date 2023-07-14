namespace VotingPoll.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int PollId { get; set; }
        public Poll Poll { get; set; }
        public ICollection<UserOption>? UserOptions { get; set; }
    }
}