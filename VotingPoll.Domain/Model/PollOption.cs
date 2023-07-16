namespace VotingPoll.Domain.Model
{
    public class PollOption
    {
        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
        public int? OptionId { get; set; }
        public Option? Option { get; set; }
    }
}
