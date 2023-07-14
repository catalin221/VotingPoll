namespace VotingPoll.Domain.Model
{
    public class Poll
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public bool IsClosed { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Option>? Options { get; set; }
        public ICollection<User>? Users { get; set; }
        public ICollection<UserOption>? UserOptions { get; set; }
        public ICollection<PollOption>? PollOptions { get; set; }
    }
}