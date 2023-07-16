using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using System.Reflection;
using VotingPoll.Domain.Model;

namespace VotingPoll.Infrastructure.Database
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var polls = new[]
            {
                new Poll { Id = 1, Title = "Favorite Color", Description = "What is your favorite color?", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddDays(7) },
                new Poll { Id = 2, Title = "Favorite Animal", Description = "What is your favorite animal?", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow.AddDays(7) }
            };

            var options = new[]
            {
                new Option { Id = 1, Name = "Red", PollId = 1 },
                new Option { Id = 2, Name = "Blue", PollId = 1 },
                new Option { Id = 3, Name = "Green", PollId = 1 },
                new Option { Id = 4, Name = "Dog" , PollId = 2 },
                new Option { Id = 5, Name = "Cat", PollId = 2 }
            };

            var users = new[]
            {
                new User { Id = 1, Name = "John" },
                new User { Id = 2, Name = "Jane" }
            };

            var userPolls = new[]
            {
                new UserPoll { UserId = 1, PollId = 1 },
                new UserPoll { UserId = 2, PollId = 2 }
            };

            var userOptions = new[]
            {
                new UserOption { UserId = 1, OptionId = 1, PollId = 1 },
                new UserOption { UserId = 2, OptionId = 4, PollId = 2 },
                new UserOption { UserId = 2, OptionId = 5, PollId = 2 }
            };

            var pollOptions = new[]
            {
                new PollOption { PollId = 1, OptionId = 1 },
                new PollOption { PollId = 1, OptionId = 2 },
                new PollOption { PollId = 1, OptionId = 3 },
                new PollOption { PollId = 2, OptionId = 4 },
                new PollOption { PollId = 2, OptionId = 5 }
            };

            modelBuilder.Entity<Poll>().HasData(polls);
            modelBuilder.Entity<Option>().HasData(options);
            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<UserPoll>().HasData(userPolls);
            modelBuilder.Entity<UserOption>().HasData(userOptions);
            modelBuilder.Entity<PollOption>().HasData(pollOptions);
        }
    }
}