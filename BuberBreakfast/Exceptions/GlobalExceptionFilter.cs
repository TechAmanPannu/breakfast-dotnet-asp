using System.ComponentModel.DataAnnotations;
using System.Net;
using BuberBreakfast.Contracts.Error;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberBreakfast.Excetions;

public class GlobalExceptionFilter : IExceptionFilter
{
    private readonly ILogger<GlobalExceptionFilter> _logger;

    public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
    {
        _logger = logger;
    }

    public void OnException(ExceptionContext context)
    {
        _logger.LogError(context.Exception, context.Exception.Message);
        var errors = new string[1];
        errors[0] = context.Exception.StackTrace;
        var errorResponse = new ErrorResponse
        {
            Status = "500",
            Title = context.Exception.Message,
            Errors = errors
        };

        switch (context.Exception)
        {
            case EntityNotFoundException _:
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.NotFound;
                errorResponse.Status = "404";
                break;
            default:
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                break;
        }

        context.Result = new JsonResult(errorResponse);
        context.ExceptionHandled = true; // Mark the exception as handled
    }
}
