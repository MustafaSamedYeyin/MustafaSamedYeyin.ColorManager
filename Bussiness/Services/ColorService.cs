using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services;
using Data.EfCore.Context;
using DTOs.Concrete.ServiceDtos.ColorDtos;

namespace Bussiness.Services
{
    public class ColorService : GenericService<ColorGenericDto, Color>, IColorService
    {
        public ColorService(ColorManagerContext context) : base(context)
        {
        }
    }
}