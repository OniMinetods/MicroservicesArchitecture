using AutoMapper;
using MicroservicesArchitecture.Dtos;
using MicroservicesArchitecture.Models;

namespace MicroservicesArchitecture.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
