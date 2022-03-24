using Core.Entities;
using Core.Interfaces.Bussiness.GenericService;
using DTOs.Concrete.AuthDtos;
using DTOs.Concrete.AuthDtos.RoleDtos.CRUD;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Core.Interfaces.Bussiness.Services.AuthServices
{
    public interface IUserService : IGenericService<UserGenericDto,User>
    {
         Task<GetUserDto> GetByEmailAsync(string Email);
         Task<GetRoleDto> GetUserRoleByIdAsync(int userId);
         Task CreateUserAsync(RegisterDto registerDto );
         Task<UserGenericDto> GetByIdAsync(int id);
        
    }
}