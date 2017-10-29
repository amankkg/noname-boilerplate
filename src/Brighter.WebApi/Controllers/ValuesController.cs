using Brighter.Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using Paramore.Brighter;
using System.Collections.Generic;

namespace Brighter.WebApi.Controllers
{
  [Route("api/[controller]")]
  public class ValuesController : Controller
  {
    private readonly IAmACommandProcessor _commandProcessor;

    public ValuesController(IAmACommandProcessor commandProcessor)
    {
      _commandProcessor = commandProcessor;
    }

    // GET api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] {"value1", "value2"};
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] string value)
    {
      var command = new CreateValueCommand(value);
      _commandProcessor.Send(command);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
