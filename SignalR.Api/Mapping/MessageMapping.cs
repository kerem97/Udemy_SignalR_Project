﻿using AutoMapper;
using SignalR.DtoLayer.MessageDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class MessageMapping : Profile
    {
        public MessageMapping()
        {
            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
        }
    }
}
