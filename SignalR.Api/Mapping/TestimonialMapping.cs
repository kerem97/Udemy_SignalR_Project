using AutoMapper;
using SignalR.DtoLayer.TestimonialDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetByIDTestimonialDto>().ReverseMap();
        }
    }
}
