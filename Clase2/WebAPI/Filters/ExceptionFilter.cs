using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebAPI.Models;

namespace WebAPI.Filters;

public class ExceptionFilter : Attribute, IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        List<Type> errors401 = new List<Type>()
        {
        };
        List<Type> errors404 = new List<Type>()
        {
            typeof(KeyNotFoundException)
        };
        List<Type> errors409 = new List<Type>()
        {

        };
        List<Type> errors422 = new List<Type>()
        {
            typeof(FormatException)
        };

        ErrorDto response = new ErrorDto()
        {
            IsSuccess = false,
            ErrorMessage = context.Exception.Message
        };
            
        Type errorType = context.Exception.GetType();
        if (errors401.Contains(errorType))
        {
            response.Content = context.Exception.Message;
            response.Code = 401;
        }
        else if (errors404.Contains(errorType))
        {
            response.Content = context.Exception.Message;
            response.Code = 404;
        }
        else if (errors409.Contains(errorType))
        {
            response.Content = context.Exception.Message;
            response.Code = 409;
        }
        else if (errors422.Contains(errorType))
        {
            response.Content = context.Exception.Message;
            response.Code = 422;
        }
        else
        {
            response.Content = context.Exception.Message;
            response.Code = 500;
            Console.WriteLine(context.Exception);
        }

        context.Result = new ObjectResult(response)
        {
            StatusCode = response.Code
        };
    }
}