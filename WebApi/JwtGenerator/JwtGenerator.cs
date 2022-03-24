using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Core.Interfaces.Bussiness.Services.AuthServices;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;
using Microsoft.IdentityModel.Tokens;
using WebApi.JwtGenerator.Interface;

namespace WebApi.JwtGenerator
{
    public class JwtGenerator : IJwtGenerator
    {
        private readonly IConfiguration _config;
        private readonly IUserService _userService;

        public JwtGenerator(IConfiguration config, IUserService userService)
        {
            _config = config;
            _userService = userService;
        }

        public async Task<string> JwtGenerate(GetUserDto getUserDto)
        {
            var user =await  _userService.GetByEmailAsync(getUserDto.Email);
            var roles = await _userService.GetUserRoleByIdAsync(user.Id);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["AppSettings:Secret"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]{
                    new Claim("id", user.Id.ToString()),
                    new Claim("Role", roles.Name)
                    }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Audience = "localhost",
                Issuer= "localhost"
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}