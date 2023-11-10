using AutoMapper;
using SignalR.DtoLayer.SocialMediaDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class SocialMediaMapping : Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, GetByIDSocialMediaDto>().ReverseMap();

        }
    }
}
