﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]

        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]

        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Description = createProductDto.Description,
                ImageUrl = createProductDto.ImageUrl,
                Name = createProductDto.Name,
                Price = createProductDto.Price,
                Status = createProductDto.Status,
                CategoryID = createProductDto.CategoryID,
            });

            return Ok("Ürün başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return Ok("Ürün başarılı bir şekilde silindi");
        }

        [HttpPut]

        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Name = updateProductDto.Name,
                Price = updateProductDto.Price,
                Status = updateProductDto.Status,
                ProductID = updateProductDto.ProductID,
                CategoryID = updateProductDto.CategoryID,
            });

            return Ok("Ürün başarılı bir şekilde güncellendi");

        }

        [HttpGet("{id}")]

        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetByID(id);
            return Ok(value);
        }
        [HttpGet("ProductListWithCategory")]

        public IActionResult ProductListWithCategory()
        {
            var values = _mapper.Map<List<ResultProductWithCategory>>(_productService.TGetProductsWithCategories());
            return Ok(values);
        }

        [HttpGet("ProductCount")]

        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }
        [HttpGet("ProductCountByNameHamburger")]

        public IActionResult ProductCountByNameHamburger()
        {
            return Ok(_productService.TProductCountByCategoryNameHamburger());
        }
        [HttpGet("ProductCountByNameDrink")]

        public IActionResult ProductCountByNameDrink()
        {
            return Ok(_productService.TProductCountByCategoryNameDrink());
        }
        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }
        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }
        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }

        [HttpGet("ProductAvgPriceByHamburger")]

        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());
        }
    }
}
