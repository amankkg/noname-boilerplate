using Microsoft.AspNetCore.Mvc.Filters;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace server.WebApi.Infrastructure
{
  class GlobalExceptionFilter<T4xxException, T5xxException> : IExceptionFilter
    where T4xxException : Exception
    where T5xxException : Exception
  {
    private readonly ILogger _logger;

    public GlobalExceptionFilter(ILoggerFactory logger)
    {
      if (logger == null) throw new ArgumentNullException(nameof(logger));

      _logger = logger.CreateLogger(nameof(GlobalExceptionFilter<T4xxException, T5xxException>.GetType));
    }

    public void OnException(ExceptionContext context)
    {
      if (context == null) throw new ArgumentNullException(nameof(context));

      var response = new { message = context.Exception.Message };
      switch (context.Exception)
      {
        case T4xxException usersucks:
          context.Result = new BadRequestObjectResult(response);
          break;
        case T5xxException wesuck:
        default:
          context.Result = new ObjectResult(response) { StatusCode = 500 };
          break;
      }

      _logger.LogError(nameof(OnException), context.Exception);
    }
  }
}
