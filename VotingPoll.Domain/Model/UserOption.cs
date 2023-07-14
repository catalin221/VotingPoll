namespace VotingPoll.Domain.Model
{
    public class UserOption
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }
        public int PollId { get; set; }
        public Poll Poll { get; set; }
    }
}
