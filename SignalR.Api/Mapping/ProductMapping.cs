using AutoMapper;
using SignalR.DtoLayer.ProductDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIDProductDto>().ReverseMap();
            CreateMap<Product, ResultProductWithCategory>().ReverseMap();

        }
    }
}
