using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Core.Interfaces.Bussiness.Auth;
using Core.Interfaces.Bussiness.Services.AuthServices;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;

namespace WebApi.Middleware
{
    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;
        public AuthMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _configuration = configuration;
        }
        public async Task Invoke(HttpContext context, IUserService userService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            int userId;
            if (token == null)
            { 
                var tokenHandler = ValidateToken(token);
                userId = GetUserIdFromJWT(tokenHandler);
                attachUserToContext(context, userService,userId);
            }
            await _next(context);
        }

        private void attachUserToContext(HttpContext context, IUserService userService, int userId)
        {
            try
            {
                // attach user to context on successful jwt validation
                context.Items["User"] = userService.GetById(userId);
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }
        }
        private int GetUserIdFromJWT(JwtSecurityToken token)
        {
            var userId = int.Parse(token.Claims.First(x => x.Type == "id").Value);
            return userId;
        }
        private JwtSecurityToken ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration["AppSettings:Secret"]);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = true,
                ValidateAudience = true,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            return jwtToken;
        }
    }
}