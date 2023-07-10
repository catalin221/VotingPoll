namespace VotingPoll.Domain.Model
{
    public class Option
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int VotesCount { get; set; }
    }
}