using System.Security.Authentication;
using Domain;
using IBusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using WebAPI.Models;

namespace WebAPI.Filters;

public class ProtectFilter : Attribute, IActionFilter
{
   
    private IUserService? _userService;
    private readonly RoleType _role;
    public ProtectFilter(RoleType role)
    {
        this._role = role;
    }

    public void OnActionExecuted(ActionExecutedContext context) { }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        this._userService = context.HttpContext.RequestServices.GetService<IUserService>();
        StringValues token;
        context.HttpContext.Request.Headers.TryGetValue("Authorization", out token);
        Exception exception = new AuthenticationException("You are not allowed to do this action");
        ErrorDto error=new ErrorDto()
        {
            IsSuccess = false,
            ErrorMessage = exception.Message,
            Content = exception.Message,
            Code = 401
        };
        try
        {
            User user = _userService?.GetUserByToken(token);
            if (user != null && user.Role != _role)
            {
                context.Result = new ObjectResult(error)
                {
                    StatusCode = error.Code
                };
            }
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