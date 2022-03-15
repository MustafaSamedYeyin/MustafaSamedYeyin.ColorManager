using Core.Entities;
using Core.Interfaces.Bussiness.GenericService;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace Core.Interfaces.Bussiness.Services.AuthServices
{
    public interface IUserService : IGenericService<UserGenericDto,User>
    {
        
    }
}