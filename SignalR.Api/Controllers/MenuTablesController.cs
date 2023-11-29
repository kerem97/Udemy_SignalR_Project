using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.MenuTableDtos;
using SignalR.EntityLayer.Entities;

namespace SignalR.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;

        public MenuTablesController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }
        [HttpGet("MenuTableCount")]
        public IActionResult MenuTableCount()
        {
            var value = _menuTableService.TMenuTableCount();
            return Ok(value);
        }


        [HttpGet]
        public IActionResult MenuTableList()
        {
            var values = _menuTableService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]

        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            MenuTable menuTable = new MenuTable()
            {
                Name = createMenuTableDto.Name,
                Status = false


            };

            _menuTableService.TAdd(menuTable);
            return Ok("Başarılı bir şekilde eklendi");
        }

        [HttpDelete("{id}")]

        public IActionResult DeleteMenuTable(int id)
        {
            var value = _menuTableService.TGetByID(id);
            _menuTableService.TDelete(value);
            return Ok("Başarılı bir şekilde silindi");
        }

        [HttpPut]

        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
            MenuTable menuTable = new MenuTable()
            {
                MenuTableID = updateMenuTableDto.MenuTableID,
                Status = updateMenuTableDto.Status,
                Name = updateMenuTableDto.Name

            };
            _menuTableService.TUpdate(menuTable);
            return Ok("Başarılı bir şekilde güncellendi");
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var value = _menuTableService.TGetByID(id);
            return Ok(value);
        }


    }
}
