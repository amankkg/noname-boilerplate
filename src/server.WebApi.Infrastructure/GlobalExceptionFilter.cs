using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;

namespace server.WebApi.Infrastructure
{
  class GlobalExceptionFilter<TBadRequestException, TServerErrorException> : IExceptionFilter
    where TBadRequestException : Exception
    where TServerErrorException : Exception
  {
    private readonly ILogger _logger;

    public GlobalExceptionFilter(ILoggerFactory logger)
    {
      if (logger == null) throw new ArgumentNullException(nameof(logger));

      _logger = logger.CreateLogger(nameof(GlobalExceptionFilter<TBadRequestException, TServerErrorException>));
    }

    public void OnException(ExceptionContext context)
    {
      if (context == null) throw new ArgumentNullException(nameof(context));

      var response = new {message = context.Exception.Message};
      switch (context.Exception)
      {
        case TBadRequestException usersucks:
          context.Result = new BadRequestObjectResult(response);
          break;
        case TServerErrorException wesuck:
        default:
          context.Result = new ObjectResult(response) {StatusCode = 500};
          break;
      }

      _logger.LogError(nameof(OnException), context.Exception);
    }
  }
}
