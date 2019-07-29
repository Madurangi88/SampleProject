using AutoMapper;
using Test.Business.Models;
using Test.Data.Entities;

namespace Test.Api.Helpers
{
    public class Automapper : Profile
    {
        public Automapper()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Destination, DestinationDto>().ReverseMap();
        }
    }
}
