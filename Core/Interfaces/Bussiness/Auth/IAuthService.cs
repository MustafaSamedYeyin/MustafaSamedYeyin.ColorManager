using DTOs.Concrete.AuthDtos;

namespace Core.Interfaces.Bussiness.Auth
{
    public interface IAuthService
    {
        Task<TokenDto> LoginAsync(LoginDto loginDto);
        Task RegisterAsync(RegisterDto registerDto);

    }
}