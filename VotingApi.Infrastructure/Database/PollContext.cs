using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using VotingPoll.Domain.Model;

namespace VotingPoll.Infrastructure.Database
{
    public class PollContext : DbContext
    {
        private static ILogger _logger;
        public PollContext(DbContextOptions<PollContext> options, ILogger<PollContext> logger) : base(options)
        {
            _logger = logger;
        }
        public DbSet<Option> Options { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Poll> Polls { get; set; }
        public DbSet<UserOption> UserOptions { get; set; }
        public DbSet<UserPoll> UserPolls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserOption>(entity =>
            {
                entity.HasKey(uo => new { uo.UserId, uo.OptionId });

                entity.HasOne(uo => uo.User)
                    .WithMany()
                    .HasForeignKey(uo => uo.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(uo => uo.Option)
                    .WithMany()
                    .HasForeignKey(uo => uo.OptionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserPoll>(entity =>
            {
                entity.HasKey(up => new { up.UserId, up.PollId });

                entity.HasOne(up => up.User)
                    .WithMany()
                    .HasForeignKey(up => up.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(up => up.Poll)
                    .WithMany()
                    .HasForeignKey(up => up.PollId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<PollOption>(entity =>
            {
                entity.HasKey(po => new { po.PollId, po.OptionId });

                entity.HasOne(po => po.Poll)
                    .WithMany()
                    .HasForeignKey(po => po.PollId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(po => po.Option)
                    .WithMany()
                    .HasForeignKey(po => po.OptionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Seed(_logger);
        }
    }
}
