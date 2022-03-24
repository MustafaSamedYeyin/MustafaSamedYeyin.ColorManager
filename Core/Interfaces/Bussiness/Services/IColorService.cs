using Core.Entities;
using Core.Interfaces.Bussiness.GenericService;
using DTOs.Concrete.ServiceDtos.ColorDtos;
using DTOs.Concrete.ServiceDtos.ColorDtos.CRUD;
using ColorGenericDto = DTOs.Concrete.ServiceDtos.ColorDtos.ColorGenericDto;

namespace Core.Interfaces.Bussiness.Services
{
    public interface IColorService : IGenericService<ColorGenericDto, Color>
    {
       
        Task<List<ColorGenericDto>> GetColorsByUserId(int id);

    }
}