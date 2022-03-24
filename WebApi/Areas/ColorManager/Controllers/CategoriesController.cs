using Core.Interfaces.Bussiness.Services;
using Core.StringValues;
using DTOs.Concrete.ServiceDtos.ColorDtos;
using DTOs.Concrete.ServiceDtos.ColorDtos.CRUD;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.CustomAttributes;

namespace WebApi.Areas.ColorManager.Controllers
{
    [Route("api/colorManager/[controller]")]
    [ApiController]
    [Authorize(role:"Admin")]
    public class CategoriesController : ControllerBase
    {
        private readonly IColorService _colorService;

        public CategoriesController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<List<ColorGenericDto>> GetColorsByUserId(int id)
        {
            return await _colorService.GetColorsByUserId(id);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<ColorGenericDto> CreateColor(ColorGenericDto createColorDto)
        {
            return await _colorService.Add(createColorDto);
        }
    }
}
