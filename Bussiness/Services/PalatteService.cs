using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services;
using Data.EfCore.Context;
using DTOs.Concrete.ServiceDtos.PalatteDtos;

namespace Bussiness.Services
{
    public class PalatteService : GenericService<PalatteGenericDto, Palatte>, IPalatteService
    {
        public PalatteService(ColorManagerContext context) : base(context)
        {
        }
    }
}