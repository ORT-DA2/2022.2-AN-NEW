using System.Security.Authentication;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using WebAPI.Models;

namespace WebAPI.Filters;

public class FilterAuthentication: Attribute, IAuthorizationFilter
{
    private IUserService? userService;

    public FilterAuthentication(IUserService userService)
    {
        this.userService = userService;
    }
    
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        this.userService = context.HttpContext.RequestServices.GetService<IUserService>();
        Exception exception = new AuthenticationException("You are not allowed to do this action");
        ErrorDto error=new ErrorDto()
        {
            IsSuccess = false,
            ErrorMessage = exception.Message,
            Content = exception.Message,
            Code = 401
        };
            
        StringValues token;
        context.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
        if (token.Count == 0 || token == "")
        {
            context.Result = new ObjectResult(error)
            {
                StatusCode = error.Code
            };
        }
        else
        {
            try
            {
                userService.GetUserByToken(token);
            }
            catch (KeyNotFoundException)
            {
                context.Result = new ObjectResult(error)
                {
                    StatusCode = error.Code
                };
            }
        }
    }
}