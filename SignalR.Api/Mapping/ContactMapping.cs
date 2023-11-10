﻿using AutoMapper;
using SignalR.DtoLayer.ContactDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {

            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetByIDContactDto>().ReverseMap();
        }
    }
}
