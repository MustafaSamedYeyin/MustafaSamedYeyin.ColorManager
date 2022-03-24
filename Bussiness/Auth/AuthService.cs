using Core.Interfaces.Bussiness.Auth;
using Core.Interfaces.Bussiness.Services.AuthServices;
using Core.Interfaces.Data.IUnitOfWork;
using DTOs.Concrete.AuthDtos;

namespace Bussiness.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IUnitOfWork _unitOfWork;

        public AuthService(IUserService userService, IRoleService roleService, IUnitOfWork unitOfWork)
        {
            _userService = userService;
            _roleService = roleService;
            _unitOfWork = unitOfWork;
        }

        public Task<TokenDto> LoginAsync(LoginDto loginDto)
        {
            throw new NotImplementedException();
        }

        public async Task RegisterAsync(RegisterDto registerDto)
        {
            var isUserExixst = await _userService.GetByEmailAsync(registerDto.Email);
            if (isUserExixst == null)
            {
               await  _userService.CreateUserAsync(registerDto);
            }
            //await _unitOfWork.SaveChangesAsync();

        }
    }
}