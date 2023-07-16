using AutoMapper;
using VotingPoll.Application.DTO;
using VotingPoll.Domain.Model;
using VotinPoll.Application.DTO;

namespace VotingPoll.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<Option, OptionDTO>();
            //CreateMap<Poll, PollDTO>();
            //CreateMap<UserOption, UserOptionDTO>();
            CreateMap<PollOption, PollOptionDTO>();
            CreateMap<UserPoll, UserPollDTO>();

        }
    }
}
