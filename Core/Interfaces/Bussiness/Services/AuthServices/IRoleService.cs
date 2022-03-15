using Core.Entities;
using Core.Interfaces.Bussiness.GenericService;
using DTOs.Concrete.AuthDtos.RoleDtos;

namespace Core.Interfaces.Bussiness.Services.AuthServices
{
    public interface IRoleService : IGenericService<RoleGenericDto,Role>
    {

    }
}