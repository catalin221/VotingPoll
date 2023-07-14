using Microsoft.EntityFrameworkCore;
using VotingPoll.Domain.Model;

namespace VotingPoll.Infrastructure.Database
{
    public class PollContext : DbContext
    {
        public PollContext(DbContextOptions<PollContext> options) : base(options) { }
        public DbSet<Option> Options { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Poll> Polls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poll>()
                .HasMany(p => p.Users);
            modelBuilder.Entity<Poll>()
                .HasMany(p => p.Options);
            modelBuilder.Entity<Poll>()
                .HasMany(p => p.UserOptions);

            modelBuilder.Entity<UserOption>(entity =>
            {
                entity.HasKey(uo => new { uo.UserId, uo.OptionId, uo.PollId });

                entity.HasOne(uo => uo.User)
                    .WithMany(u => u.UserOptions)
                    .HasForeignKey(uo => uo.UserId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(uo => uo.Option)
                    .WithMany(o => o.UserOptions)
                    .HasForeignKey(uo => uo.OptionId)
                    .OnDelete(DeleteBehavior.Cascade);

                entity.HasOne(uo => uo.Poll)
                    .WithMany(p => p.UserOptions)
                    .HasForeignKey(uo => uo.PollId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UserPoll>()
                .HasKey(up => new { up.UserId, up.PollId });

            modelBuilder.Entity<PollOption>(entity =>
            {
                entity.HasKey(po => new { po.PollId, po.OptionId });

                entity.HasOne(po => po.Poll)
                    .WithMany(p => p.PollOptions)
                    .HasForeignKey(po => po.PollId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(po => po.Option)
                    .WithMany(o => o.PollOptions)
                    .HasForeignKey(po => po.OptionId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Seed();
        }
    }
}