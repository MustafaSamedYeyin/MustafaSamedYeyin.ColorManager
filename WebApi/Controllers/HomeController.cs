using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces.Bussiness.Auth;
using DTOs.Concrete.AuthDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApi.JwtGenerator.Interface;

namespace WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IAuthService _authService;

        public HomeController(IConfiguration config, IJwtGenerator jwtGenerator, IAuthService authService)
        {
            _config = config;
            _jwtGenerator = jwtGenerator;
            _authService = authService;
        }
        [HttpPost]
        [Route("[action]")]
        public async Task Register(RegisterDto registerDto)
        {
            await _authService.RegisterAsync(registerDto);

        }
        [HttpGet]
        [Route("[action]")]
        public async Task<string> Login(GetUserDto getUserDto)
        {
            return await _jwtGenerator.JwtGenerate(getUserDto);
        }
    }
}