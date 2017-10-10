using Paramore.Brighter;
using System;

namespace Brighter.Domain.Commands
{
  public class CreateValueCommand : IRequest
  {
    public CreateValueCommand(string value)
    {
      Id = new Guid();
      Value = value;
    }

    public Guid Id { get; set; }
    public string Value { get; }
  }
}
