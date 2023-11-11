﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContactDto.FooterDescription,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,
                PhoneNumber = createContactDto.PhoneNumber
            });

            return Ok("İletişim bilgisi başarılı bir şekilde eklendi");
        }

        [HttpDelete]

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletişim bilgisi başarılı bir şekilde silindi");
        }

        [HttpPut]

        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                FooterDescription = updateContactDto.FooterDescription,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,
                PhoneNumber = updateContactDto.PhoneNumber,
                ContactID = updateContactDto.ContactID

            });

            return Ok("İletişim bilgisi başarılı bir şekilde güncellendi");

        }

        [HttpGet("GetContact")]

        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }
    }
}