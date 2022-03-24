using DTOs.Concrete.AuthDtos.UserDtos.CRUD;

namespace WebApi.JwtGenerator.Interface
{
    public interface IJwtGenerator
    {
         Task<string> JwtGenerate(GetUserDto getUserDto);
    }
}