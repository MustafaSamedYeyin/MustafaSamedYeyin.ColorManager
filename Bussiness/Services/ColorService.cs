using Bussiness.AutoMappers;
using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services;
using Core.Interfaces.Data.Repository;
using Data.EfCore.Context;
using DTOs.Concrete.ServiceDtos.ColorDtos;
using DTOs.Concrete.ServiceDtos.ColorDtos.CRUD;

namespace Bussiness.Services
{
    public class ColorService : GenericService<DTOs.Concrete.ServiceDtos.ColorDtos.ColorGenericDto, Color>, IColorService
    {
        private readonly IColorRepository _colorRepository;
        public ColorService(ColorManagerContext context, IColorRepository colorRepository) : base(context)
        {
            _colorRepository = colorRepository;
        }

        public async Task<List<ColorGenericDto>> GetColorsByUserId(int id)
        {
            return Mapping.EfMap().Map<List<ColorGenericDto>>(await _colorRepository.GetColorsByUserId(id));
        }
    }
}