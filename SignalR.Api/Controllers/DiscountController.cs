﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ContactDtos;
using SignalR.DtoLayer.DiscountDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImageUrl = createDiscountDto.ImageUrl,
                Title = createDiscountDto.Title,
                Status = false
            });

            return Ok("İndirim bilgisi başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim bilgisi başarılı bir şekilde silindi");
        }

        [HttpPut]

        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageUrl = updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title,
                Status = updateDiscountDto.Status,

                DiscountID = updateDiscountDto.DiscountID
            });

            return Ok("İndirim bilgisi başarılı bir şekilde güncellendi");

        }

        [HttpGet("{id}")]

        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetByID(id);
            return Ok(value);
        }

        [HttpGet("ChangeStatusToTrue/{id}")]

        public IActionResult ChangeStatusToTrue(int id)
        {
            _discountService.TChangeStatusToTrue(id);
            return Ok("İndirim Durumu Güncellendi");
        }

        [HttpGet("ChangeStatusToFalse/{id}")]

        public IActionResult ChangeStatusToFalse(int id)
        {
            _discountService.TChangeStatusToTrue(id);
            return Ok("İndirim Durumu Güncellendi");
        }

        [HttpGet("GetListByStatusTrue")]

        public IActionResult GetListByStatusTrue()
        {
            var values = _discountService.TGetListByStatusTrue();
            return Ok(values);
        }
    }
}
