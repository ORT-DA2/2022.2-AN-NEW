using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebAPI.Models;

namespace WebAPI.Filters;

public class FilterExceptions : Attribute, IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        List<Type> errors401 = new List<Type>()
        {

        };
        List<Type> errors404 = new List<Type>()
        {

        };
        List<Type> errors422 = new List<Type>()
        {
            typeof(FormatException)
        };

        ErrorDto errorDto = new ErrorDto()
        {
            IsSuccess = false,
            ErrorMessage = context.Exception.Message
        };

        Type errorType = context.Exception.GetType();

        if (errors422.Contains(errorType))
        {
            errorDto.Content = context.Exception.Message;
            errorDto.Code = 422;
        }
        else if (errors404.Contains(errorType)){
            
        errorDto.Content = context.Exception.Message;
            errorDto.Code = 404;
        }
        else if (errors401.Contains(errorType))
        {
            errorDto.Content = context.Exception.Message;
            errorDto.Code = 401;
        }
        else
        {
            errorDto.Code = 500;
            errorDto.Content = context.Exception.Message;
        }

        context.Result = new ObjectResult(errorDto)
        {
            StatusCode = errorDto.Code
        };
    }
}