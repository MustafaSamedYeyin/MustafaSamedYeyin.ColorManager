using Bussiness.GenericService;
using Core.Interfaces.Bussiness.Services.AuthServices;
using DTOs.Concrete.AuthDtos.UserDtos;

namespace Bussiness.Services.AuthServices
{
    public class UserService :  GenericService<UserGenericDto>,IUserService
    {

    }
}