
using Core.StringValues;
using DTOs.Concrete.AuthDtos.AuthAttiributesDto;
using DTOs.Concrete.AuthDtos.UserDtos;
using DTOs.Concrete.AuthDtos.UserDtos.CRUD;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace WebApi.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private string _role;

        public AuthorizeAttribute(string role)
        {
            _role = role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {

            var user = (UserGenericDto) context.HttpContext.Items["User"];
            
            if (user == null)
            {
                // not logged in
                context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
            else
            {
                _role = user.Role;
            }
        }
        
    }
}
