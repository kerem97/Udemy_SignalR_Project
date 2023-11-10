using AutoMapper;
using SignalR.DtoLayer.AboutDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetByIDAboutDto>().ReverseMap();
        }
    }
}
