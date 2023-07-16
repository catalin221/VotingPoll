namespace VotingPoll.Domain.Model
{
    public class UserPoll
    {
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
    }
}