using AutoMapper;
using SignalR.DtoLayer.BookingDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class BookingMapping : Profile
    {
        public BookingMapping()
        {
            CreateMap<Booking, ResultBookingDto>().ReverseMap();
            CreateMap<Booking, CreateBookingDto>().ReverseMap();
            CreateMap<Booking, UpdateBookingDto>().ReverseMap();
            CreateMap<Booking, GetByIDBookingDto>().ReverseMap();
        }
    }
}
