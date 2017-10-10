using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace server.WebApi.Infrastructure
{
  public class BaseController : Controller
  {
    protected async Task<OkObjectResult> Ok<T>(Task<T> task) => Ok(await task);

    protected async Task<IActionResult> Created<T>(Func<T, string> createUri, Task<T> task)
    {
      var result = await task;
      return Created(createUri(result), result);
    }

    protected async Task<IActionResult> NoContent(Task task)
    {
      await task;
      return NoContent();
    }
  }
}
