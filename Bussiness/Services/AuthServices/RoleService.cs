using Bussiness.GenericService;
using Core.Entities;
using Core.Interfaces.Bussiness.Services.AuthServices;
using Data.EfCore.Context;
using DTOs.Concrete.AuthDtos.RoleDtos;

namespace Bussiness.Services.AuthServices
{
    public class RoleService : GenericService<RoleGenericDto, Role>, IRoleService
    {
        public RoleService(ColorManagerContext context) : base(context)
        {
        }
    }
}