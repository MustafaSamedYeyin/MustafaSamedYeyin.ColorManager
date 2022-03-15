using Core.Entities;
using Core.Interfaces.Bussiness.GenericService;
using DTOs.Concrete.ServiceDtos.ColorDtos;

namespace Core.Interfaces.Bussiness.Services
{
    public interface IColorService : IGenericService<ColorGenericDto,Color>
    {

    }
}