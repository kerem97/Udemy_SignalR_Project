﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalR.Web.UI.Dtos.BasketDtos;
using SignalR.Web.UI.Dtos.ProductDtos;
using System.Text;

namespace SignalR.Web.UI.Controllers
{
    [AllowAnonymous]
    public class MenuController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7294/api/Product");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddBasket(int id)
        {
            CreateBasketDto createBasketDto = new CreateBasketDto();
            createBasketDto.ProductID = id;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBasketDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7294/api/Basket", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
