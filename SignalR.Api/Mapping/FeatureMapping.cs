using AutoMapper;
using SignalR.DtoLayer.FeatureDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {

            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIDFeatureDto>().ReverseMap();
        }
    }
}
