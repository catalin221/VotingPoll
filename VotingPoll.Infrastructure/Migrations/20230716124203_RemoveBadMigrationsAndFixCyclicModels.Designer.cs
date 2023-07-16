﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VotingPoll.Infrastructure.Database;

#nullable disable

namespace VotingPoll.Infrastructure.Migrations
{
    [DbContext(typeof(PollContext))]
    [Migration("20230716124203_RemoveBadMigrationsAndFixCyclicModels")]
    partial class RemoveBadMigrationsAndFixCyclicModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VotingPoll.Domain.Model.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PollId")
                        .HasColumnType("int");

                    b.Property<int>("VotesCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Red",
                            PollId = 1,
                            VotesCount = 0
                        },
                        new
                        {
                            Id = 2,
                            Name = "Blue",
                            PollId = 1,
                            VotesCount = 0
                        },
                        new
                        {
                            Id = 3,
                            Name = "Green",
                            PollId = 1,
                            VotesCount = 0
                        },
                        new
                        {
                            Id = 4,
                            Name = "Dog",
                            PollId = 2,
                            VotesCount = 0
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cat",
                            PollId = 2,
                            VotesCount = 0
                        });
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsClosed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Polls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "What is your favorite color?",
                            EndDate = new DateTime(2023, 7, 23, 12, 42, 3, 639, DateTimeKind.Utc).AddTicks(4056),
                            IsClosed = false,
                            StartDate = new DateTime(2023, 7, 16, 12, 42, 3, 639, DateTimeKind.Utc).AddTicks(4054),
                            Title = "Favorite Color"
                        },
                        new
                        {
                            Id = 2,
                            Description = "What is your favorite animal?",
                            EndDate = new DateTime(2023, 7, 23, 12, 42, 3, 639, DateTimeKind.Utc).AddTicks(4059),
                            IsClosed = false,
                            StartDate = new DateTime(2023, 7, 16, 12, 42, 3, 639, DateTimeKind.Utc).AddTicks(4059),
                            Title = "Favorite Animal"
                        });
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.PollOption", b =>
                {
                    b.Property<int?>("PollId")
                        .HasColumnType("int");

                    b.Property<int?>("OptionId")
                        .HasColumnType("int");

                    b.HasKey("PollId", "OptionId");

                    b.HasIndex("OptionId");

                    b.ToTable("PollOption");

                    b.HasData(
                        new
                        {
                            PollId = 1,
                            OptionId = 1
                        },
                        new
                        {
                            PollId = 1,
                            OptionId = 2
                        },
                        new
                        {
                            PollId = 1,
                            OptionId = 3
                        },
                        new
                        {
                            PollId = 2,
                            OptionId = 4
                        },
                        new
                        {
                            PollId = 2,
                            OptionId = 5
                        });
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PollId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jane"
                        });
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.UserOption", b =>
                {
                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("OptionId")
                        .HasColumnType("int");

                    b.Property<int?>("PollId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "OptionId", "PollId");

                    b.HasIndex("OptionId");

                    b.HasIndex("PollId");

                    b.ToTable("UserOption");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            OptionId = 1,
                            PollId = 1
                        },
                        new
                        {
                            UserId = 2,
                            OptionId = 4,
                            PollId = 2
                        },
                        new
                        {
                            UserId = 2,
                            OptionId = 5,
                            PollId = 2
                        });
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.UserPoll", b =>
                {
                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("PollId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PollId");

                    b.HasIndex("PollId");

                    b.ToTable("UserPoll");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            PollId = 1
                        },
                        new
                        {
                            UserId = 2,
                            PollId = 2
                        });
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.Option", b =>
                {
                    b.HasOne("VotingPoll.Domain.Model.Poll", "Poll")
                        .WithMany("Options")
                        .HasForeignKey("PollId");

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.PollOption", b =>
                {
                    b.HasOne("VotingPoll.Domain.Model.Option", "Option")
                        .WithMany("PollOptions")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VotingPoll.Domain.Model.Poll", "Poll")
                        .WithMany("PollOptions")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.User", b =>
                {
                    b.HasOne("VotingPoll.Domain.Model.Poll", "Poll")
                        .WithMany("Users")
                        .HasForeignKey("PollId");

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.UserOption", b =>
                {
                    b.HasOne("VotingPoll.Domain.Model.Option", "Option")
                        .WithMany("UserOptions")
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VotingPoll.Domain.Model.Poll", "Poll")
                        .WithMany("UserOptions")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VotingPoll.Domain.Model.User", "User")
                        .WithMany("UserOptions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Option");

                    b.Navigation("Poll");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.UserPoll", b =>
                {
                    b.HasOne("VotingPoll.Domain.Model.Poll", "Poll")
                        .WithMany()
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VotingPoll.Domain.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");

                    b.Navigation("User");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.Option", b =>
                {
                    b.Navigation("PollOptions");

                    b.Navigation("UserOptions");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.Poll", b =>
                {
                    b.Navigation("Options");

                    b.Navigation("PollOptions");

                    b.Navigation("UserOptions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("VotingPoll.Domain.Model.User", b =>
                {
                    b.Navigation("UserOptions");
                });
#pragma warning restore 612, 618
        }
    }
}
